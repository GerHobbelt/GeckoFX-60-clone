namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataTransferItemList : WebIDLBase
    {
        
        public DataTransferItemList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports Add(string data, string type)
        {
            return this.CallMethod<nsISupports>("add", data, type);
        }
        
        public nsISupports Add(nsISupports data)
        {
            return this.CallMethod<nsISupports>("add", data);
        }
        
        public void Remove(uint index)
        {
            this.CallVoidMethod("remove", index);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
    }
}
