namespace Gecko.WebIDL
{
    using System;
    
    
    public class Worklet : WebIDLBase
    {
        
        public Worklet(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise Import(USVString moduleURL)
        {
            return this.CallMethod<Promise>("import", moduleURL);
        }
    }
}
