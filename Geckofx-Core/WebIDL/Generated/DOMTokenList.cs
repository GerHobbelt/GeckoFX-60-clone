namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMTokenList : WebIDLBase
    {
        
        public DOMTokenList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public string Item(uint index)
        {
            return this.CallMethod<string>("item", index);
        }
        
        public bool Contains(string token)
        {
            return this.CallMethod<bool>("contains", token);
        }
        
        public void Add(string tokens)
        {
            this.CallVoidMethod("add", tokens);
        }
        
        public void Remove(string tokens)
        {
            this.CallVoidMethod("remove", tokens);
        }
        
        public void Replace(string token, string newToken)
        {
            this.CallVoidMethod("replace", token, newToken);
        }
        
        public bool Toggle(string token)
        {
            return this.CallMethod<bool>("toggle", token);
        }
        
        public bool Toggle(string token, bool force)
        {
            return this.CallMethod<bool>("toggle", token, force);
        }
        
        public bool Supports(string token)
        {
            return this.CallMethod<bool>("supports", token);
        }
    }
}
