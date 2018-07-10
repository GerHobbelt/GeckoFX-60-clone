namespace Gecko.WebIDL
{
    using System;
    
    
    public class OscillatorNode : WebIDLBase
    {
        
        public OscillatorNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public OscillatorType Type
        {
            get
            {
                return this.GetProperty<OscillatorType>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public nsISupports Frequency
        {
            get
            {
                return this.GetProperty<nsISupports>("frequency");
            }
        }
        
        public nsISupports Detune
        {
            get
            {
                return this.GetProperty<nsISupports>("detune");
            }
        }
        
        public void SetPeriodicWave(nsISupports periodicWave)
        {
            this.CallVoidMethod("setPeriodicWave", periodicWave);
        }
    }
}
