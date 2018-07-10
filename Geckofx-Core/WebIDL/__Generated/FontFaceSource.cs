namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSource : WebIDLBase
    {
        
        public FontFaceSource(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Fonts
        {
            get
            {
                return this.GetProperty<nsISupports>("fonts");
            }
        }
    }
}
