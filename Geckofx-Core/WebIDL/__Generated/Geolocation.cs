namespace Gecko.WebIDL
{
    using System;
    
    
    public class Geolocation : WebIDLBase
    {
        
        public Geolocation(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void ClearWatch(int watchId)
        {
            this.CallVoidMethod("clearWatch", watchId);
        }
    }
}
