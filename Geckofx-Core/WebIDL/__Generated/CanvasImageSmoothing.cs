namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasImageSmoothing : WebIDLBase
    {
        
        public CanvasImageSmoothing(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool ImageSmoothingEnabled
        {
            get
            {
                return this.GetProperty<bool>("imageSmoothingEnabled");
            }
            set
            {
                this.SetProperty("imageSmoothingEnabled", value);
            }
        }
    }
}
