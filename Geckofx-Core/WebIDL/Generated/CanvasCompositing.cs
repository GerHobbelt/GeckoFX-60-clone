namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasCompositing : WebIDLBase
    {
        
        public CanvasCompositing(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double GlobalAlpha
        {
            get
            {
                return this.GetProperty<double>("globalAlpha");
            }
            set
            {
                this.SetProperty("globalAlpha", value);
            }
        }
        
        public string GlobalCompositeOperation
        {
            get
            {
                return this.GetProperty<string>("globalCompositeOperation");
            }
            set
            {
                this.SetProperty("globalCompositeOperation", value);
            }
        }
    }
}
