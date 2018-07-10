namespace Gecko.WebIDL
{
    using System;
    
    
    public class FlexLine : WebIDLBase
    {
        
        public FlexLine(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public FlexLineGrowthState GrowthState
        {
            get
            {
                return this.GetProperty<FlexLineGrowthState>("growthState");
            }
        }
        
        public double CrossStart
        {
            get
            {
                return this.GetProperty<double>("crossStart");
            }
        }
        
        public double CrossSize
        {
            get
            {
                return this.GetProperty<double>("crossSize");
            }
        }
        
        public double FirstBaselineOffset
        {
            get
            {
                return this.GetProperty<double>("firstBaselineOffset");
            }
        }
        
        public double LastBaselineOffset
        {
            get
            {
                return this.GetProperty<double>("lastBaselineOffset");
            }
        }
        
        public nsISupports[] GetItems()
        {
            return this.CallMethod<nsISupports[]>("getItems");
        }
    }
}
