namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeContentView : WebIDLBase
    {
        
        public TreeContentView(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement GetItemAtIndex(int row)
        {
            return this.CallMethod<nsIDOMElement>("getItemAtIndex", row);
        }
        
        public int GetIndexOfItem(nsIDOMElement item)
        {
            return this.CallMethod<int>("getIndexOfItem", item);
        }
    }
}
