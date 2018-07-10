namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSFontFeatureValuesRule : WebIDLBase
    {
        
        public CSSFontFeatureValuesRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string FontFamily
        {
            get
            {
                return this.GetProperty<string>("fontFamily");
            }
            set
            {
                this.SetProperty("fontFamily", value);
            }
        }
        
        public string ValueText
        {
            get
            {
                return this.GetProperty<string>("valueText");
            }
            set
            {
                this.SetProperty("valueText", value);
            }
        }
    }
}
