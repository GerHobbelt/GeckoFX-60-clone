namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChildNode : WebIDLBase
    {
        
        public ChildNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Before(WebIDLUnion<nsIDOMNode,System.String> nodes)
        {
            this.CallVoidMethod("before", nodes);
        }
        
        public void After(WebIDLUnion<nsIDOMNode,System.String> nodes)
        {
            this.CallVoidMethod("after", nodes);
        }
        
        public void ReplaceWith(WebIDLUnion<nsIDOMNode,System.String> nodes)
        {
            this.CallVoidMethod("replaceWith", nodes);
        }
        
        public void Remove()
        {
            this.CallVoidMethod("remove");
        }
    }
}
