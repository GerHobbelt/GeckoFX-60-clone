namespace Gecko.WebIDL
{
    using System;
    
    
    public class AccessibleNode : WebIDLBase
    {
        
        public AccessibleNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Role
        {
            get
            {
                return this.GetProperty<string>("role");
            }
        }
        
        public string[] States
        {
            get
            {
                return this.GetProperty<string[]>("states");
            }
        }
        
        public string[] Attributes
        {
            get
            {
                return this.GetProperty<string[]>("attributes");
            }
        }
        
        public nsIDOMNode DOMNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("DOMNode");
            }
        }
        
        public bool Is(string states)
        {
            return this.CallMethod<bool>("is", states);
        }
        
        public bool Has(string attributes)
        {
            return this.CallMethod<bool>("has", attributes);
        }
        
        public object Get(string attribute)
        {
            return this.CallMethod<object>("get", attribute);
        }
    }
}
