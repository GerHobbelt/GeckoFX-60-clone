namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBKeyRange : WebIDLBase
    {
        
        public IDBKeyRange(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Lower
        {
            get
            {
                return this.GetProperty<object>("lower");
            }
        }
        
        public object Upper
        {
            get
            {
                return this.GetProperty<object>("upper");
            }
        }
        
        public bool LowerOpen
        {
            get
            {
                return this.GetProperty<bool>("lowerOpen");
            }
        }
        
        public bool UpperOpen
        {
            get
            {
                return this.GetProperty<bool>("upperOpen");
            }
        }
        
        public bool Includes(object key)
        {
            return this.CallMethod<bool>("includes", key);
        }
    }
}
