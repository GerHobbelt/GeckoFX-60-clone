namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLContextEvent : WebIDLBase
    {
        
        public WebGLContextEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string StatusMessage
        {
            get
            {
                return this.GetProperty<string>("statusMessage");
            }
        }
    }
}
