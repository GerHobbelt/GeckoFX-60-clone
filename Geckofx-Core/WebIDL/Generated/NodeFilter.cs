namespace Gecko.WebIDL
{
    using System;
    
    
    public class NodeFilter : WebIDLBase
    {
        
        public NodeFilter(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort AcceptNode(nsIDOMNode node)
        {
            return this.CallMethod<ushort>("acceptNode", node);
        }
    }
}
