namespace Gecko.WebIDL
{
    using System;
    
    
    public class ListBoxObject : WebIDLBase
    {
        
        public ListBoxObject(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int GetRowCount()
        {
            return this.CallMethod<int>("getRowCount");
        }
        
        public int GetRowHeight()
        {
            return this.CallMethod<int>("getRowHeight");
        }
        
        public int GetNumberOfVisibleRows()
        {
            return this.CallMethod<int>("getNumberOfVisibleRows");
        }
        
        public int GetIndexOfFirstVisibleRow()
        {
            return this.CallMethod<int>("getIndexOfFirstVisibleRow");
        }
        
        public void EnsureIndexIsVisible(int rowIndex)
        {
            this.CallVoidMethod("ensureIndexIsVisible", rowIndex);
        }
        
        public void ScrollToIndex(int rowIndex)
        {
            this.CallVoidMethod("scrollToIndex", rowIndex);
        }
        
        public void ScrollByLines(int numLines)
        {
            this.CallVoidMethod("scrollByLines", numLines);
        }
        
        public nsIDOMElement GetItemAtIndex(int index)
        {
            return this.CallMethod<nsIDOMElement>("getItemAtIndex", index);
        }
        
        public int GetIndexOfItem(nsIDOMElement item)
        {
            return this.CallMethod<int>("getIndexOfItem", item);
        }
    }
}
