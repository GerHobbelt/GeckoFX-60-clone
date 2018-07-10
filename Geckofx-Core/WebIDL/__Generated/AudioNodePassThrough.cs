namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioNodePassThrough : WebIDLBase
    {
        
        public AudioNodePassThrough(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool PassThrough
        {
            get
            {
                return this.GetProperty<bool>("passThrough");
            }
            set
            {
                this.SetProperty("passThrough", value);
            }
        }
    }
}
