namespace Gecko.WebIDL
{
    using System;
    
    
    public class MIDIOutput : WebIDLBase
    {
        
        public MIDIOutput(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Send(byte[] data)
        {
            this.CallVoidMethod("send", data);
        }
        
        public void Send(byte[] data, double timestamp)
        {
            this.CallVoidMethod("send", data, timestamp);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
    }
}
