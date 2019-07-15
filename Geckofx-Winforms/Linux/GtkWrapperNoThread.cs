
#if GTK
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Gdk;
using Gtk;
using System.Runtime.InteropServices;

namespace GtkDotNet
{	
	/// <summary>
	/// Allows embeding of a Gtk Window in Winforms control. The gtk event loop is run using  Winform idle processing.
	/// </summary>
	public class GtkWrapperNoThread : IDisposable
	{
        #region PInvokes

        [DllImport("libgdk-3.so.0", EntryPoint = "gdk_pixbuf_get_from_window")]
        public static extern IntPtr PixBufFromGdkWindow(IntPtr gdk, int x, int y, int width, int height);

        #endregion

        #region fields

        /// <summary>
        /// The Gtk window which is embeded into m_parent.
        /// </summary>
        protected Gtk.Window _popupWindow;
		
		/// <summary>
		/// stores if the passed popup windows has been created.
		/// </summary>
		protected bool _popupWindowCreated = false;

        #endregion

        protected bool IsDisposed { get; set; }
		
		protected GtkWrapperNoThread()
		{
		}
		
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// </summary>
		public GtkWrapperNoThread(Gtk.Window popupWindow)
		{
			_popupWindow = popupWindow;	
			
			System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;			
		}

		protected void HandleSystemWindowsFormsApplicationIdle(object sender, EventArgs e)
		{
			try
			{
				Init();
				ProcessPendingGtkEvents(5);
				_popupWindow?.Window?.ProcessUpdates(true);

			}
			catch(ObjectDisposedException)
			{
				Cleanup();
			}
		}

		protected virtual void Cleanup()
		{							
			System.Windows.Forms.Application.Idle -= HandleSystemWindowsFormsApplicationIdle;
			if (_popupWindow != null)
			{
				_popupWindow.Destroy();
				_popupWindow.Dispose();
				_popupWindow = null;
			}
		}

		public virtual void SetInputFocus()
		{
		}
		
		public virtual void RemoveInputFocus()
		{
		}
		
		public virtual bool HasInputFocus()
		{
			return false;	
		}

#region IDisposable implementation
		public void Dispose()
		{
			Cleanup();
			IsDisposed = true;
			System.GC.SuppressFinalize(this);
		}
#endregion
		
		public Gtk.Window BrowserWindow
		{
			get { return _popupWindow; }	
		}

		protected Gdk.Pixbuf GetPixbufOfWebBrowser(int width, int height)
		{
			return new Pixbuf(PixBufFromGdkWindow(BrowserWindow.Window.Handle, 0, 0, width, height));
		}
		
		internal Bitmap GetBitmap(int width, int height)
		{			
			Gdk.Pixbuf pb = GetPixbufOfWebBrowser(width, height);
			byte[] buffer = pb.SaveToBuffer("bmp");			
			MemoryStream s = new MemoryStream(buffer);
			
			return new Bitmap(s);			
		}

		public virtual void Init()
		{
			if (_popupWindowCreated)
				return;
			
			GtkOnceOnly.Init();
			
			lock(this)
			{
				if (_popupWindowCreated == true)
					return;
				
				CreatePopWindowOffScreen();				
				_popupWindowCreated = true;
			}
		}

		public static void ProcessPendingGtkEvents(int max = 2048)
		{
			try
			{
				int counter = 0;
				while (Gtk.Application.EventsPending()) {
					Gtk.Application.RunIteration(false);
				counter++;
				if (counter > max)
					break;
				}
			}catch(Exception e)
			{
				// Ignore any exceptions to improve stablity.
				Debug.WriteLine(e);
			}		
		}

		protected void CreatePopWindowOffScreen()
		{
			_popupWindow.ShowNow();
			_popupWindow.DoubleBuffered = false;
			_popupWindow.Move(-5000, -5000);
			
			while (_popupWindow.Window == null)
				ProcessPendingGtkEvents();
		}
	}
}
#endif
