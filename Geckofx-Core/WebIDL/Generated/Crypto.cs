namespace Gecko.WebIDL
{
    using System;
    
    
    public class Crypto : WebIDLBase
    {
        
        public Crypto(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Subtle
        {
            get
            {
                return this.GetProperty<nsISupports>("subtle");
            }
        }
        
        public IntPtr GetRandomValues(IntPtr array)
        {
            return this.CallMethod<IntPtr>("getRandomValues", array);
        }
    }
}
