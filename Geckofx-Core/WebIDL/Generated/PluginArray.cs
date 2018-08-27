namespace Gecko.WebIDL
{
    using System;
    
    
    public class PluginArray : WebIDLBase
    {
        
        public PluginArray(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Item(uint index)
        {
            return this.CallMethod<nsISupports>("item", index);
        }
        
        public nsISupports NamedItem(string name)
        {
            return this.CallMethod<nsISupports>("namedItem", name);
        }
        
        public void Refresh()
        {
            this.CallVoidMethod("refresh");
        }
        
        public void Refresh(bool reloadDocuments)
        {
            this.CallVoidMethod("refresh", reloadDocuments);
        }
    }
}
