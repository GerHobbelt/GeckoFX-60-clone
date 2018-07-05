namespace Gecko.WebIDL
{
    using System;
    
    
    public class StreamFilter : WebIDLBase
    {
        
        public StreamFilter(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public StreamFilterStatus Status
        {
            get
            {
                return this.GetProperty<StreamFilterStatus>("status");
            }
        }
        
        public string Error
        {
            get
            {
                return this.GetProperty<string>("error");
            }
        }
        
        public void Suspend()
        {
            this.CallVoidMethod("suspend");
        }
        
        public void Resume()
        {
            this.CallVoidMethod("resume");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
        
        public void Write(WebIDLUnion<IntPtr,IntPtr> data)
        {
            this.CallVoidMethod("write", data);
        }
    }
}
