namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasHitRegions : WebIDLBase
    {
        
        public CanvasHitRegions(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddHitRegion()
        {
            this.CallVoidMethod("addHitRegion");
        }
        
        public void AddHitRegion(object options)
        {
            this.CallVoidMethod("addHitRegion", options);
        }
        
        public void RemoveHitRegion(string id)
        {
            this.CallVoidMethod("removeHitRegion", id);
        }
        
        public void ClearHitRegions()
        {
            this.CallVoidMethod("clearHitRegions");
        }
    }
}
