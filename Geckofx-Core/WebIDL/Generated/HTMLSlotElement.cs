namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLSlotElement : WebIDLBase
    {
        
        public HTMLSlotElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsIDOMNode[] AssignedNodes()
        {
            return this.CallMethod<nsIDOMNode[]>("assignedNodes");
        }
        
        public nsIDOMNode[] AssignedNodes(object options)
        {
            return this.CallMethod<nsIDOMNode[]>("assignedNodes", options);
        }
    }
}
