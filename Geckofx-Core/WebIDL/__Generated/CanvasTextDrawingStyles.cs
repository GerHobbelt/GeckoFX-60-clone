namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasTextDrawingStyles : WebIDLBase
    {
        
        public CanvasTextDrawingStyles(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Font
        {
            get
            {
                return this.GetProperty<string>("font");
            }
            set
            {
                this.SetProperty("font", value);
            }
        }
        
        public string TextAlign
        {
            get
            {
                return this.GetProperty<string>("textAlign");
            }
            set
            {
                this.SetProperty("textAlign", value);
            }
        }
        
        public string TextBaseline
        {
            get
            {
                return this.GetProperty<string>("textBaseline");
            }
            set
            {
                this.SetProperty("textBaseline", value);
            }
        }
    }
}
