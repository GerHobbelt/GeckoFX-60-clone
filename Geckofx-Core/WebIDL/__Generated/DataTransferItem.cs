namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataTransferItem : WebIDLBase
    {
        
        public DataTransferItem(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsISupports GetAsFile()
        {
            return this.CallMethod<nsISupports>("getAsFile");
        }
        
        public nsISupports WebkitGetAsEntry()
        {
            return this.CallMethod<nsISupports>("webkitGetAsEntry");
        }
    }
}
