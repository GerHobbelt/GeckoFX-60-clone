namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGZoomAndPanValues : WebIDLBase
    {
        
        public SVGZoomAndPanValues(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort ZoomAndPan
        {
            get
            {
                return this.GetProperty<ushort>("zoomAndPan");
            }
            set
            {
                this.SetProperty("zoomAndPan", value);
            }
        }
    }
}
