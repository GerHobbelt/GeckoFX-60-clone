namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioScheduledSourceNode : WebIDLBase
    {
        
        public AudioScheduledSourceNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Start()
        {
            this.CallVoidMethod("start");
        }
        
        public void Start(double when)
        {
            this.CallVoidMethod("start", when);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Stop(double when)
        {
            this.CallVoidMethod("stop", when);
        }
    }
}
