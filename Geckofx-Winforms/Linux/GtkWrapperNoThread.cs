
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
		/// <summary>
		/// The Gtk window which is embeded into m_parent.
		/// </summary>
		protected Gtk.Window m_popupWindow;
		
		/// <summary>
		/// stores if the passed popup windows has been created.
		/// </summary>
		protected bool m_popupWindowCreated = false;

		protected bool IsDisposed { get; set; }
		
		protected GtkWrapperNoThread()
		{
		}
		
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// </summary>
		public GtkWrapperNoThread(Gtk.Window popupWindow)
		{
			m_popupWindow = popupWindow;	
			
			System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;			
		}

		protected void HandleSystemWindowsFormsApplicationIdle(object sender, EventArgs e)
		{
			try
			{
				Init();
				ProcessPendingGtkEvents(5);
				m_popupWindow?.GdkWindow?.ProcessUpdates(true);

			}
			catch(ObjectDisposedException)
			{
				Cleanup();
			}
		}

		protected virtual void Cleanup()
		{							
			System.Windows.Forms.Application.Idle -= HandleSystemWindowsFormsApplicationIdle;
			if (m_popupWindow != null)
			{
				m_popupWindow.Destroy();
				m_popupWindow.Dispose();
				m_popupWindow = null;
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
			get { return m_popupWindow; }	
		}
				

		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_pixbuf_get_from_window")]
		public static extern IntPtr PixBufFromGdkWindow(IntPtr gdk, int x, int y, int width, int height);         

		protected Gdk.Pixbuf GetPixbufOfWebBrowser(int width, int height)
		{
			return new Pixbuf(PixBufFromGdkWindow(BrowserWindow.GdkWindow.Handle, 0, 0, width, height));
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
			if (m_popupWindowCreated)
				return;
			
			GtkOnceOnly.Init();
			
			lock(this)
			{
				if (m_popupWindowCreated == true)
					return;
				
				CreatePopWindowOffScreen();				
				m_popupWindowCreated = true;
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
			m_popupWindow.ShowNow();
			m_popupWindow.DoubleBuffered = false;
			m_popupWindow.Move(-5000, -5000);
			
			while (m_popupWindow.GdkWindow == null)
			{
				ProcessPendingGtkEvents();
			}
		}
	}
}
#endif
