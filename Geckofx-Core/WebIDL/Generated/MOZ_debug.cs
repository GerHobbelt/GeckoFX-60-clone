namespace Gecko.WebIDL
{
    using System;
    
    
    public class MOZ_debug : WebIDLBase
    {
        
        public MOZ_debug(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object GetParameter(uint pname)
        {
            return this.CallMethod<object>("getParameter", pname);
        }
    }
}
