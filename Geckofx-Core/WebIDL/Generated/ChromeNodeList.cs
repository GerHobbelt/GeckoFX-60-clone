namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChromeNodeList : WebIDLBase
    {
        
        public ChromeNodeList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Append(nsIDOMNode aNode)
        {
            this.CallVoidMethod("append", aNode);
        }
        
        public void Remove(nsIDOMNode aNode)
        {
            this.CallVoidMethod("remove", aNode);
        }
    }
}
