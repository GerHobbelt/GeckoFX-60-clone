namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLCollection : WebIDLBase
    {
        
        public HTMLCollection(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
    }
}
