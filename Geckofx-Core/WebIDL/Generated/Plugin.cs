namespace Gecko.WebIDL
{
    using System;
    
    
    public class Plugin : WebIDLBase
    {
        
        public Plugin(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Description
        {
            get
            {
                return this.GetProperty<string>("description");
            }
        }
        
        public string Filename
        {
            get
            {
                return this.GetProperty<string>("filename");
            }
        }
        
        public string Version
        {
            get
            {
                return this.GetProperty<string>("version");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports Item(uint index)
        {
            return this.CallMethod<nsISupports>("item", index);
        }
        
        public nsISupports NamedItem(string name)
        {
            return this.CallMethod<nsISupports>("namedItem", name);
        }
    }
}
