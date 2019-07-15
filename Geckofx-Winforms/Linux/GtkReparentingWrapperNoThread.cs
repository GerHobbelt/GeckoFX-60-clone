
#if GTK
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gdk;

namespace GtkDotNet
{
    public abstract class GtkReparentingWrapperNoThreadBase : GtkWrapperNoThread
    {
        #region fields

        /// <summary>
        /// Use to help figure out what is the last Resize event.
        /// </summary>
        private Timer _refreshTimer;

        /// <summary>
        /// The window we have reparented from.
        /// </summary>
        private Gdk.Window _originalParent;

        /// <summary>
        /// Gdk wrapper created from m_parent handle.
        /// </summary>
        protected Gdk.Window _gdkWrapperOfForm;

        /// <summary>
        /// X Display Ptr.
        /// Need to call various X11 functions.
        /// </summary>
        protected IntPtr _xDisplayPointer;

        /// <summary>
        /// Creating windows generates a bunch of resize events
        /// This is set to true when we thing we have received the last resize event.
        /// </summary>
        protected bool _resizeHasHappened;

        /// <summary>
        /// The Winform control that m_popupWindow is reparented into.
        /// </summary>
        protected Control _parent;

        #endregion fields

        public GtkReparentingWrapperNoThreadBase(Control parent)
        {
            Gdk.Display display = Gdk.Display.Default;
            _xDisplayPointer = gdk_x11_display_get_xdisplay(display.Handle);

            _parent = parent;
            parent.HandleCreated += HandleParentCreated;
            parent.Resize += HandleParentResize;
        }

        #region PInvokes

        [DllImport("libX11")]
        public extern static int XResizeWindow(IntPtr display, IntPtr window, uint width, uint height);

        [DllImport("libgdk-3-0.dll")]
        internal static extern IntPtr gdk_x11_window_get_xid(IntPtr gdkDrawable);

        [DllImport("libgdk-3-0.dll")]
        internal static extern IntPtr gdk_x11_display_get_xdisplay(IntPtr display);

        [DllImport("libgdk-3-0.dll", EntryPoint = "gdk_x11_window_foreign_new_for_display")]
        public static extern IntPtr ForeignNewForDisplay(IntPtr display, IntPtr window);

        #endregion

        protected virtual void EmbedWidgetIntoWinFormPanel()
        {
            if (_gdkWrapperOfForm != null)
                return;

            if (_parent == null)
                return;

            if (!_resizeHasHappened)
                return;

            // Wraps the panel native (X) window handle in a GdkWrapper

            IntPtr gdkHandle = ForeignNewForDisplay(Gdk.Display.Default.Handle, _parent.Handle);
            _gdkWrapperOfForm = new Gdk.Window(gdkHandle);
            System.Windows.Forms.Application.DoEvents();
            ProcessPendingGtkEvents();

            // embed _popupWindow into winform (m_parent)
            _originalParent = _popupWindow.Window.Parent;
            _popupWindow.Window.Reparent(_gdkWrapperOfForm, 0, 0);
            ProcessPendingGtkEvents();
        }

        void HandleParentCreated(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;
        }

        void HandleParentResize(object sender, EventArgs e)
        {
            try
            {
                HandleParentResizeInternal(sender, e);
            }
#pragma warning disable RECS0022 // A catch clause that catches System.Exception and has an empty body
            catch { }
#pragma warning restore RECS0022 // A catch clause that catches System.Exception and has an empty body
        }

        void HandleParentResizeInternal(object sender, EventArgs e)
        {
            _refreshTimer?.Stop();

            if (_resizeHasHappened)
            {
                IntPtr xWindow = gdk_x11_window_get_xid(_popupWindow.Window.Handle);
                XResizeWindow(_xDisplayPointer, xWindow, (uint)_parent.Width, (uint)_parent.Height);
                return;
            }

            // The general idea here is to delay the reparenting of the GTK window until after last Resize event.
            _refreshTimer = new Timer();
            var reparentDelayString = Environment.GetEnvironmentVariable("GECKOFX_REPARENTDELAY") ?? "5";
            int reparentDelay = 5;
            Int32.TryParse(reparentDelayString, out reparentDelay);
            _refreshTimer.Interval = reparentDelay;
            int counter = 0;
            _refreshTimer.Tick += (a, b) =>
            {
                // On a heavy loaded system these WM_TIMER messages will likely be delayed. (which is what we want)
                // This is why we are doing N * 10 (instead of just making N 10 times larger)
                counter++;
                if (counter == 10 && !_resizeHasHappened)
                {
                    _popupWindow?.Resize(_parent.Width, _parent.Height);
                    _resizeHasHappened = true;
                    _refreshTimer.Stop();
                }
            };
            if (!_resizeHasHappened)
                _refreshTimer.Start();
        }

        protected override void Cleanup()
        {
            _parent.HandleCreated -= HandleParentCreated;
            _parent.Resize -= HandleParentResize;
            _parent = null;

            _popupWindow?.Window?.Reparent(_originalParent, 0, 0);
            ProcessPendingGtkEvents();

            base.Cleanup();
        }
    }

    public class GtkReparentingWrapperNoThread : GtkReparentingWrapperNoThreadBase
    {           
        #region XSetInputFocus

        public enum RevertTo
        {
            None = 0,
            PointerRoot = 1,
            Parent = 2
        }
    
        [DllImport ("libX11")]
        public extern static int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);
        
        [DllImport ("libX11")]
        public extern static int XGetInputFocus(IntPtr display, out IntPtr focus_return, out RevertTo revert_to_return);

        [DllImport("libX11")]
        public extern static int XFlush(IntPtr display);

        #endregion

        #region fields

        private bool _filterAdded;

        #endregion


        /// <summary>
        /// popupWindow must be a Gtk.Window of type WindowType.Popup
        /// parent is winform control which the popupWindow is embeded into.
        /// </summary>
        public GtkReparentingWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent) : base(parent)
        {
            _popupWindow = popupWindow;
        }
        
        public override void Init()
        {
            base.Init();
                        
            EmbedWidgetIntoWinFormPanel();
        }
        
        void HandleParentCreated(object sender, EventArgs e)
        {           
            System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;
        }

        protected override void EmbedWidgetIntoWinFormPanel()
        {
            if (_gdkWrapperOfForm != null)
                return;

            base.EmbedWidgetIntoWinFormPanel();

            if (_parent == null)
                return;

            if (!_resizeHasHappened)
                return;

            _popupWindow.Window.AddFilter(FilterFunc);
            _filterAdded = true;
        }

        private FilterReturn FilterFunc (IntPtr xevent, Event evnt)
        {
            if (xevent == IntPtr.Zero)
                return FilterReturn.Continue;

            var e = (X11.XEvent)Marshal.PtrToStructure(xevent, typeof(X11.XEvent));
            
            // Dropping these events is non standard but so is embeding a Gtk into
            // a X11 Window.
            if (e.type == X11.XEventName.FocusOut ||
                e.type == X11.XEventName.LeaveNotify)
            {
                return FilterReturn.Remove;
            }

            // Everything else just process as normal
            return FilterReturn.Continue;
        }
        
        protected override void Cleanup()
        {
            if (_popupWindow?.Window != null)
            {
                if (_filterAdded)
                    _popupWindow.Window.RemoveFilter(FilterFunc);
                _filterAdded = false;
                _popupWindow.Window.Destroy();
            }
            _parent.HandleCreated -= HandleParentCreated;

            _popupWindow?.Destroy();
            _popupWindow?.Dispose();
            _popupWindow = null;
            _xDisplayPointer = IntPtr.Zero;

            base.Cleanup();
        }
        
        public override void SetInputFocus()
        {
            if (IsDisposed)
                throw new ObjectDisposedException("GtkReparentingWrapperNoThread");

            if (_xDisplayPointer == IntPtr.Zero)
                throw new InvalidOperationException("_xDisplayPointer");
            
            IntPtr xWindow = gdk_x11_window_get_xid(_popupWindow.Window.Handle);
            XSetInputFocus(_xDisplayPointer, xWindow, RevertTo.Parent, IntPtr.Zero);
        }
        
        public override void RemoveInputFocus()
        {
            if (_xDisplayPointer == IntPtr.Zero)
                throw new InvalidOperationException("_xDisplayPointer");
                        
            XSetInputFocus(_xDisplayPointer, IntPtr.Zero, RevertTo.Parent, IntPtr.Zero);
        }
        
        public override bool HasInputFocus()
        {
            if (_xDisplayPointer == IntPtr.Zero)
                return false;
                        
            IntPtr xWindow = gdk_x11_window_get_xid(_popupWindow.Window.Handle);
            if (xWindow == IntPtr.Zero)
                return false;
                        
            IntPtr focus_return;
            RevertTo val;
            XGetInputFocus(_xDisplayPointer, out focus_return, out val);
            return focus_return == xWindow;
        }   
    }
}
#endif
