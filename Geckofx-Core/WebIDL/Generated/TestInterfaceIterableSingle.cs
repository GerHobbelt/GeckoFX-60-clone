namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestInterfaceIterableSingle : WebIDLBase
    {
        
        public TestInterfaceIterableSingle(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public int IndexedGetter(uint index)
        {
            return this.CallMethod<int>("IndexedGetter", index);
        }
    }
}
