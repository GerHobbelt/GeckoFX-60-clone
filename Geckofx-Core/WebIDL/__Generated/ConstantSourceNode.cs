namespace Gecko.WebIDL
{
    using System;
    
    
    public class ConstantSourceNode : WebIDLBase
    {
        
        public ConstantSourceNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Offset
        {
            get
            {
                return this.GetProperty<nsISupports>("offset");
            }
        }
    }
}
