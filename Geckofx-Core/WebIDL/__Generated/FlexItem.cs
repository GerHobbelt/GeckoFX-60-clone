namespace Gecko.WebIDL
{
    using System;
    
    
    public class FlexItem : WebIDLBase
    {
        
        public FlexItem(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode Node
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("node");
            }
        }
        
        public double MainBaseSize
        {
            get
            {
                return this.GetProperty<double>("mainBaseSize");
            }
        }
        
        public double MainDeltaSize
        {
            get
            {
                return this.GetProperty<double>("mainDeltaSize");
            }
        }
        
        public double MainMinSize
        {
            get
            {
                return this.GetProperty<double>("mainMinSize");
            }
        }
        
        public double MainMaxSize
        {
            get
            {
                return this.GetProperty<double>("mainMaxSize");
            }
        }
        
        public double CrossMinSize
        {
            get
            {
                return this.GetProperty<double>("crossMinSize");
            }
        }
        
        public double CrossMaxSize
        {
            get
            {
                return this.GetProperty<double>("crossMaxSize");
            }
        }
    }
}
