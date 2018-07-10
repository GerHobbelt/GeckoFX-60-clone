namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSetLoadEvent : WebIDLBase
    {
        
        public FontFaceSetLoadEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] Fontfaces
        {
            get
            {
                return this.GetProperty<nsISupports[]>("fontfaces");
            }
        }
    }
}
