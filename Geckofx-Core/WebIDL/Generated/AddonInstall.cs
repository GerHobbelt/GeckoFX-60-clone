namespace Gecko.WebIDL
{
    using System;
    
    
    public class AddonInstall : WebIDLBase
    {
        
        public AddonInstall(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string State
        {
            get
            {
                return this.GetProperty<string>("state");
            }
        }
        
        public string Error
        {
            get
            {
                return this.GetProperty<string>("error");
            }
        }
        
        public long Progress
        {
            get
            {
                return this.GetProperty<long>("progress");
            }
        }
        
        public long MaxProgress
        {
            get
            {
                return this.GetProperty<long>("maxProgress");
            }
        }
        
        public Promise Install()
        {
            return this.CallMethod<Promise>("install");
        }
        
        public Promise Cancel()
        {
            return this.CallMethod<Promise>("cancel");
        }
    }
}
