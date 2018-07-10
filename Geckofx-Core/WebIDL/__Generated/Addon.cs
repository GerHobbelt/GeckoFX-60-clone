namespace Gecko.WebIDL
{
    using System;
    
    
    public class Addon : WebIDLBase
    {
        
        public Addon(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Version
        {
            get
            {
                return this.GetProperty<string>("version");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Description
        {
            get
            {
                return this.GetProperty<string>("description");
            }
        }
        
        public bool IsEnabled
        {
            get
            {
                return this.GetProperty<bool>("isEnabled");
            }
        }
        
        public bool IsActive
        {
            get
            {
                return this.GetProperty<bool>("isActive");
            }
        }
        
        public bool CanUninstall
        {
            get
            {
                return this.GetProperty<bool>("canUninstall");
            }
        }
        
        public Promise <bool> Uninstall()
        {
            return this.CallMethod<Promise <bool>>("uninstall");
        }
        
        public Promise SetEnabled(bool value)
        {
            return this.CallMethod<Promise>("setEnabled", value);
        }
    }
}
