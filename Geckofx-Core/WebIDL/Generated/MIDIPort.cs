namespace Gecko.WebIDL
{
    using System;
    
    
    public class MIDIPort : WebIDLBase
    {
        
        public MIDIPort(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Manufacturer
        {
            get
            {
                return this.GetProperty<string>("manufacturer");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Version
        {
            get
            {
                return this.GetProperty<string>("version");
            }
        }
        
        public MIDIPortType Type
        {
            get
            {
                return this.GetProperty<MIDIPortType>("type");
            }
        }
        
        public MIDIPortDeviceState State
        {
            get
            {
                return this.GetProperty<MIDIPortDeviceState>("state");
            }
        }
        
        public MIDIPortConnectionState Connection
        {
            get
            {
                return this.GetProperty<MIDIPortConnectionState>("connection");
            }
        }
        
        public Promise < nsISupports > Open()
        {
            return this.CallMethod<Promise < nsISupports >>("open");
        }
        
        public Promise < nsISupports > Close()
        {
            return this.CallMethod<Promise < nsISupports >>("close");
        }
    }
}
