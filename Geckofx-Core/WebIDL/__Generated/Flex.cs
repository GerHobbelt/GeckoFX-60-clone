namespace Gecko.WebIDL
{
    using System;
    
    
    public class Flex : WebIDLBase
    {
        
        public Flex(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] GetLines()
        {
            return this.CallMethod<nsISupports[]>("getLines");
        }
    }
}
