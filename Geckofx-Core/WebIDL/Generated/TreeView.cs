namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeView : WebIDLBase
    {
        
        public TreeView(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int RowCount
        {
            get
            {
                return this.GetProperty<int>("rowCount");
            }
        }
        
        public nsISupports Selection
        {
            get
            {
                return this.GetProperty<nsISupports>("selection");
            }
            set
            {
                this.SetProperty("selection", value);
            }
        }
        
        public string GetRowProperties(int row)
        {
            return this.CallMethod<string>("getRowProperties", row);
        }
        
        public string GetCellProperties(int row, nsISupports column)
        {
            return this.CallMethod<string>("getCellProperties", row, column);
        }
        
        public string GetColumnProperties(nsISupports column)
        {
            return this.CallMethod<string>("getColumnProperties", column);
        }
        
        public bool IsContainer(int row)
        {
            return this.CallMethod<bool>("isContainer", row);
        }
        
        public bool IsContainerOpen(int row)
        {
            return this.CallMethod<bool>("isContainerOpen", row);
        }
        
        public bool IsContainerEmpty(int row)
        {
            return this.CallMethod<bool>("isContainerEmpty", row);
        }
        
        public bool IsSeparator(int row)
        {
            return this.CallMethod<bool>("isSeparator", row);
        }
        
        public bool IsSorted()
        {
            return this.CallMethod<bool>("isSorted");
        }
        
        public bool CanDrop(int row, int orientation, nsISupports dataTransfer)
        {
            return this.CallMethod<bool>("canDrop", row, orientation, dataTransfer);
        }
        
        public void Drop(int row, int orientation, nsISupports dataTransfer)
        {
            this.CallVoidMethod("drop", row, orientation, dataTransfer);
        }
        
        public int GetParentIndex(int row)
        {
            return this.CallMethod<int>("getParentIndex", row);
        }
        
        public bool HasNextSibling(int row, int afterIndex)
        {
            return this.CallMethod<bool>("hasNextSibling", row, afterIndex);
        }
        
        public int GetLevel(int row)
        {
            return this.CallMethod<int>("getLevel", row);
        }
        
        public string GetImageSrc(int row, nsISupports column)
        {
            return this.CallMethod<string>("getImageSrc", row, column);
        }
        
        public string GetCellValue(int row, nsISupports column)
        {
            return this.CallMethod<string>("getCellValue", row, column);
        }
        
        public string GetCellText(int row, nsISupports column)
        {
            return this.CallMethod<string>("getCellText", row, column);
        }
        
        public void SetTree(nsISupports tree)
        {
            this.CallVoidMethod("setTree", tree);
        }
        
        public void ToggleOpenState(int row)
        {
            this.CallVoidMethod("toggleOpenState", row);
        }
        
        public void CycleHeader(nsISupports column)
        {
            this.CallVoidMethod("cycleHeader", column);
        }
        
        public void SelectionChanged()
        {
            this.CallVoidMethod("selectionChanged");
        }
        
        public void CycleCell(int row, nsISupports column)
        {
            this.CallVoidMethod("cycleCell", row, column);
        }
        
        public bool IsEditable(int row, nsISupports column)
        {
            return this.CallMethod<bool>("isEditable", row, column);
        }
        
        public bool IsSelectable(int row, nsISupports column)
        {
            return this.CallMethod<bool>("isSelectable", row, column);
        }
        
        public void SetCellValue(int row, nsISupports column, string value)
        {
            this.CallVoidMethod("setCellValue", row, column, value);
        }
        
        public void SetCellText(int row, nsISupports column, string value)
        {
            this.CallVoidMethod("setCellText", row, column, value);
        }
        
        public void PerformAction(string action)
        {
            this.CallVoidMethod("performAction", action);
        }
        
        public void PerformActionOnRow(string action, int row)
        {
            this.CallVoidMethod("performActionOnRow", action, row);
        }
        
        public void PerformActionOnCell(string action, int row, nsISupports column)
        {
            this.CallVoidMethod("performActionOnCell", action, row, column);
        }
    }
}
