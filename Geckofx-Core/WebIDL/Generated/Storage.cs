namespace Gecko.WebIDL
{
    using System;
    
    
    public class Storage : WebIDLBase
    {
        
        public Storage(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public bool IsSessionOnly
        {
            get
            {
                return this.GetProperty<bool>("isSessionOnly");
            }
        }
        
        public string Key(uint index)
        {
            return this.CallMethod<string>("key", index);
        }
        
        public string GetItem(string key)
        {
            return this.CallMethod<string>("getItem", key);
        }
    }
}
