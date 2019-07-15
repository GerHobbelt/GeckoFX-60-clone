
#if GTK
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gdk;
using Gecko;

namespace GtkDotNet
{
    // A GtkReparentingWrapperNoThread implementation that doesn't use XSetInputFocus
    // (XSetInputFocus was breaking things badly on gnome 3)
    public class GtkKeyboardAwareReparentingWrapperNoThread : GtkReparentingWrapperNoThreadBase
    {
        static GtkKeyboardAwareReparentingWrapperNoThread()
        {
            Gdk.Window.AddFilterForAll(FilterFunc);
        }

        #region PInvokes

        [DllImport("libX11")]
        public extern static int XGrabKey(IntPtr display, int keycode, uint modifiers, IntPtr grab_window, int owner_events, int pointer_mode, int keyboard_mode);

        [DllImport("libX11")]
        public extern static void XUngrabKey(IntPtr display, int keycode, uint modifiers, IntPtr grab_window);

        #endregion

        /// <summary>
        /// popupWindow must be a Gtk.Window of type WindowType.Popup
        /// parent is winform control which the popupWindow is embeded into.
        /// </summary>
        public GtkKeyboardAwareReparentingWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent) : base(parent)
        {
            m_popupWindow = popupWindow;
        }

        public override void Init()
        {
            base.Init();

            EmbedWidgetIntoWinFormPanel();
        }

        private static Assembly _monoWinFormsAssembly;

        // internal mono WinForms type
        private static Type _hwnd;

        // internal mono WinForms Hwnd.whole_window
        private static FieldInfo _wholeWindow;

        // internal mono WinForms method Hwnd.ObjectFromHandle
        private static MethodInfo _objectFromHandle;

        private static MethodInfo _sendMessage;

        // internal mono WinForms type
        private static Type _xplatUI;

        internal static Assembly MonoWinFormsAssembly
        {
            get
            {
                if (_monoWinFormsAssembly == null)
#pragma warning disable 0618 // Using Obsolete method LoadWithPartialName.
                    _monoWinFormsAssembly = Assembly.LoadWithPartialName("System.Windows.Forms");
#pragma warning restore 0618

                return _monoWinFormsAssembly;
            }
        }


        private static Type Hwnd
        {
            get
            {
                if (_hwnd == null)
                    _hwnd = MonoWinFormsAssembly.GetType("System.Windows.Forms.Hwnd");

                return _hwnd;
            }
        }

        private static object GetHwnd(IntPtr handle)
        {
            // first call call Hwnd.ObjectFromHandle to get the hwnd.
            if (_objectFromHandle == null)
                _objectFromHandle = Hwnd.GetMethod("ObjectFromHandle", BindingFlags.Public | BindingFlags.Static);

            return _objectFromHandle.Invoke(null, new object[] { handle });
        }

        /// <summary>
        /// Get an x11 Window Id from a winforms Control handle
        /// </summary>
        public static IntPtr MonoGetX11Window(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                return IntPtr.Zero;

            object hwnd = GetHwnd(handle);

            if (_wholeWindow == null)
                _wholeWindow = Hwnd.GetField("whole_window", BindingFlags.NonPublic | BindingFlags.Instance);

            return (IntPtr)_wholeWindow.GetValue(hwnd);
        }

        private static Type XplatUI
        {
            get
            {
                if (_xplatUI == null)
                    _xplatUI = MonoWinFormsAssembly.GetType("System.Windows.Forms.XplatUI");

                return _xplatUI;
            }
        }

        public static void SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam)
        {
            if (_sendMessage == null)
            {
                Type messageType = MonoWinFormsAssembly.GetType("System.Windows.Forms.Msg");
                _sendMessage = XplatUI.GetMethod("SendMessage",
                    BindingFlags.NonPublic | BindingFlags.Static, null, new[] {
                    typeof(IntPtr),
                    messageType,
                    typeof(IntPtr),
                    typeof(IntPtr)
                }, null);
            }
            _sendMessage.Invoke(null, new object[] { hWnd, (int)Msg, (IntPtr)wParam, (IntPtr)lParam });
        }

        private static FilterReturn FilterFunc(IntPtr xevent, Event evnt)
        {
            if (xevent == IntPtr.Zero)
                return FilterReturn.Continue;

            var e = (X11.XEvent)Marshal.PtrToStructure(xevent, typeof(X11.XEvent));

#if LOGGING
            Console.WriteLine($"evnt = {e.type}");
#endif

            // Dropping LeaveNotify is needed for performance reasons.
            // Otherwise quickly moving mouse in an out of gtk area can cause a
            // delay in typing.
            if (e.type == X11.XEventName.LeaveNotify)
                return FilterReturn.Remove;
            
            if (GtkOnceOnly.Filter.Active == null && e.type == X11.XEventName.FocusIn)
            {
                if (GtkOnceOnly.Filter.LastActiveForm != null)
                    GtkOnceOnly.Filter.LastActiveForm.BringToFront();
            }

            if (e.type == X11.XEventName.KeyPress || e.type == X11.XEventName.KeyRelease)
            {
                var keyEvent = e.KeyEvent;
#if LOGGING
                Console.WriteLine($"event = {evnt} {e.type}");
                Console.WriteLine($"keyEvent.same_screen = {keyEvent.same_screen}");
                Console.WriteLine($"keyEvent.time = {keyEvent.time}");
                Console.WriteLine($"keyEvent.state = {keyEvent.state}");
                Console.WriteLine($"keyEvent.kc = {keyEvent.keycode}");
#endif

                // We could implement things like Alt-Tab (which regretably break with Grab key)
                // but Windows-key tab does the same job.
                // Alt-F4
                if (keyEvent.state == 8 && (keyEvent.keycode == 70))
                {
                    var af = Form.ActiveForm ?? GtkOnceOnly.Filter.LastActiveForm;
                    if (af != null)
                    {
                        const int WM_CLOSE = 0x0010;
                        SendMessage(af.Handle, WM_CLOSE, 0, 0);
                    }

                    return FilterReturn.Continue;
                }
                else
                {
                    if (GtkOnceOnly.Filter.Active != null)
                    {
                        // Consume keypress/keyrelease and process the event on the active window.

                        var active = GtkOnceOnly.Filter.Active.m_popupWindow.Window;
                        // Create a Gdk event from an X11 event.
                        EventKey duplicateEvent = (EventKey)EventHelper.New(e.type == X11.XEventName.KeyPress ? EventType.KeyPress : EventType.KeyRelease);
                        duplicateEvent.Time = Gtk.Global.CurrentEventTime;
                        duplicateEvent.HardwareKeycode = (ushort)keyEvent.keycode;
                        duplicateEvent.State = (Gdk.ModifierType)keyEvent.state;
                        duplicateEvent.Window = active;
                        // Just pick the first Input device (may or may not be correct but supresses the no device warning)
                        var device = Gdk.Display.Default.ListDevices().FirstOrDefault();
                        Gdk.EventHelper.SetDevice(duplicateEvent, device);
                        // Process the event.
                        Gtk.Main.DoEvent(duplicateEvent);
                        // Make sure the effect of the keypress is drawn on screen.
                        active?.ProcessUpdates(true);
                        return FilterReturn.Remove;
                    }
                }

                return FilterReturn.Continue;
            }

            // Everything else just process as normal
            return FilterReturn.Continue;
        }

        protected override void Cleanup()
        {
            RemoveInputFocus();
            if (m_gdkWrapperOfForm != null)
                m_gdkWrapperOfForm.Reparent(m_popupWindow.Window, 0, 0);
            if (m_popupWindow.Window != null)
                m_popupWindow.Window.Destroy();

            m_popupWindow.Destroy();
            m_popupWindow.Dispose();
            m_popupWindow = null;

           base.Cleanup();
        }

        public override void SetInputFocus()
        {
            if (IsDisposed)
                throw new ObjectDisposedException("GtkReparentingWrapperNoThread");

            if (m_xDisplayPointer == IntPtr.Zero)
                throw new ArgumentNullException("m_xDisplayPointer");

            if (GtkOnceOnly.Filter.Active != null)
                GtkOnceOnly.Filter.LastActive = GtkOnceOnly.Filter.Active;
            GtkOnceOnly.Filter.Active = this;

            var activeForm = Form.ActiveForm;
            if (activeForm == null)
                activeForm = GtkOnceOnly.Filter.LastActiveForm;
            if (activeForm != null)
            {
                GtkOnceOnly.Filter.LastActiveForm = activeForm;
                XGrabKey(m_xDisplayPointer, 0, 1 << 15, MonoGetX11Window(activeForm.Handle), 0, 1, 1);
            }
        }

        public override void RemoveInputFocus()
        {
            if (m_xDisplayPointer == IntPtr.Zero)
                return;

            if (GtkOnceOnly.Filter.Active != null)
                GtkOnceOnly.Filter.LastActive = GtkOnceOnly.Filter.Active;
            GtkOnceOnly.Filter.Active = null;
            var activeForm = Form.ActiveForm;
            if (activeForm != null)
                XUngrabKey(m_xDisplayPointer, 0, 1 << 15, MonoGetX11Window(activeForm.Handle));
        }

        public override bool HasInputFocus()
        {
            return GtkOnceOnly.Filter.Active == this;
        }
    }
}
#endif
