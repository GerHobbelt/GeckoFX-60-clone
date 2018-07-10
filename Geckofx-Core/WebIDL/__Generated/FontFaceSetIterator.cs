namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSetIterator : WebIDLBase
    {
        
        public FontFaceSetIterator(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Next()
        {
            return this.CallMethod<object>("next");
        }
    }
}
