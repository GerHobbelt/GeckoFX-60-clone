namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLProgressElement : WebIDLBase
    {
        
        public HTMLProgressElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public double Max
        {
            get
            {
                return this.GetProperty<double>("max");
            }
            set
            {
                this.SetProperty("max", value);
            }
        }
        
        public double Position
        {
            get
            {
                return this.GetProperty<double>("position");
            }
        }
        
        public nsISupports Labels
        {
            get
            {
                return this.GetProperty<nsISupports>("labels");
            }
        }
    }
}
