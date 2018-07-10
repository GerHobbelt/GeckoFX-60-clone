namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorAutomationInformation : WebIDLBase
    {
        
        public NavigatorAutomationInformation(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Webdriver
        {
            get
            {
                return this.GetProperty<bool>("webdriver");
            }
        }
    }
}
