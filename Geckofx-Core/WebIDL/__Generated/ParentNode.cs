namespace Gecko.WebIDL
{
    using System;
    
    
    public class ParentNode : WebIDLBase
    {
        
        public ParentNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Children
        {
            get
            {
                return this.GetProperty<nsISupports>("children");
            }
        }
        
        public nsIDOMElement FirstElementChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("firstElementChild");
            }
        }
        
        public nsIDOMElement LastElementChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("lastElementChild");
            }
        }
        
        public uint ChildElementCount
        {
            get
            {
                return this.GetProperty<uint>("childElementCount");
            }
        }
        
        public void Prepend(WebIDLUnion<nsIDOMNode,System.String> nodes)
        {
            this.CallVoidMethod("prepend", nodes);
        }
        
        public void Append(WebIDLUnion<nsIDOMNode,System.String> nodes)
        {
            this.CallVoidMethod("append", nodes);
        }
    }
}
