namespace Gecko.WebIDL
{
    using System;
    
    
    public class Credential : WebIDLBase
    {
        
        public Credential(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Id
        {
            get
            {
                return this.GetProperty<USVString>("id");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
    }
}
