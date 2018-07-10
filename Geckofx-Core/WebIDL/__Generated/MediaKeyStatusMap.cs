namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyStatusMap : WebIDLBase
    {
        
        public MediaKeyStatusMap(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
        }
        
        public bool Has(IntPtr keyId)
        {
            return this.CallMethod<bool>("has", keyId);
        }
        
        public object Get(IntPtr keyId)
        {
            return this.CallMethod<object>("get", keyId);
        }
    }
}
