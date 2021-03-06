namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextEncoder : WebIDLBase
    {
        
        public TextEncoder(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Encoding
        {
            get
            {
                return this.GetProperty<string>("encoding");
            }
        }
        
        public IntPtr Encode()
        {
            return this.CallMethod<IntPtr>("encode");
        }
        
        public IntPtr Encode(string input)
        {
            return this.CallMethod<IntPtr>("encode", input);
        }
    }
}
