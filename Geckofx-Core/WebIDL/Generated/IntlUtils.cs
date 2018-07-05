namespace Gecko.WebIDL
{
    using System;
    
    
    public class IntlUtils : WebIDLBase
    {
        
        public IntlUtils(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object GetDisplayNames(string[] locales)
        {
            return this.CallMethod<object>("getDisplayNames", locales);
        }
        
        public object GetDisplayNames(string[] locales, object options)
        {
            return this.CallMethod<object>("getDisplayNames", locales, options);
        }
        
        public object GetLocaleInfo(string[] locales)
        {
            return this.CallMethod<object>("getLocaleInfo", locales);
        }
    }
}
