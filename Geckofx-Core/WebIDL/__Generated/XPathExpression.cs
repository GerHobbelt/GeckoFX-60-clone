namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathExpression : WebIDLBase
    {
        
        public XPathExpression(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Evaluate(nsIDOMNode contextNode)
        {
            return this.CallMethod<nsISupports>("evaluate", contextNode);
        }
        
        public nsISupports Evaluate(nsIDOMNode contextNode, ushort type)
        {
            return this.CallMethod<nsISupports>("evaluate", contextNode, type);
        }
        
        public nsISupports Evaluate(nsIDOMNode contextNode, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluate", contextNode, type, result);
        }
        
        public nsISupports EvaluateWithContext(nsIDOMNode contextNode, uint contextPosition, uint contextSize)
        {
            return this.CallMethod<nsISupports>("evaluateWithContext", contextNode, contextPosition, contextSize);
        }
        
        public nsISupports EvaluateWithContext(nsIDOMNode contextNode, uint contextPosition, uint contextSize, ushort type)
        {
            return this.CallMethod<nsISupports>("evaluateWithContext", contextNode, contextPosition, contextSize, type);
        }
        
        public nsISupports EvaluateWithContext(nsIDOMNode contextNode, uint contextPosition, uint contextSize, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluateWithContext", contextNode, contextPosition, contextSize, type, result);
        }
    }
}
