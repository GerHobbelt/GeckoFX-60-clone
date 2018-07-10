namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozFrameLoaderOwner : WebIDLBase
    {
        
        public MozFrameLoaderOwner(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports FrameLoader
        {
            get
            {
                return this.GetProperty<nsISupports>("frameLoader");
            }
        }
        
        public void PresetOpenerWindow(mozIDOMWindowProxy window)
        {
            this.CallVoidMethod("presetOpenerWindow", window);
        }
        
        public void SwapFrameLoaders(nsISupports aOtherLoaderOwner)
        {
            this.CallVoidMethod("swapFrameLoaders", aOtherLoaderOwner);
        }
    }
}
