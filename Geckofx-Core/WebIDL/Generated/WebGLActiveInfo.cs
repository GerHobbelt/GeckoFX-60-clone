namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLActiveInfo : WebIDLBase
    {
        
        public WebGLActiveInfo(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Size
        {
            get
            {
                return this.GetProperty<int>("size");
            }
        }
        
        public uint Type
        {
            get
            {
                return this.GetProperty<uint>("type");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
    }
}
