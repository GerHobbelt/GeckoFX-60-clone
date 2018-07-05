namespace Gecko.WebIDL
{
    using System;
    
    
    public class GetUserMediaRequest : WebIDLBase
    {
        
        public GetUserMediaRequest(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong WindowID
        {
            get
            {
                return this.GetProperty<ulong>("windowID");
            }
        }
        
        public ulong InnerWindowID
        {
            get
            {
                return this.GetProperty<ulong>("innerWindowID");
            }
        }
        
        public string CallID
        {
            get
            {
                return this.GetProperty<string>("callID");
            }
        }
        
        public string RawID
        {
            get
            {
                return this.GetProperty<string>("rawID");
            }
        }
        
        public string MediaSource
        {
            get
            {
                return this.GetProperty<string>("mediaSource");
            }
        }
        
        public bool IsSecure
        {
            get
            {
                return this.GetProperty<bool>("isSecure");
            }
        }
        
        public bool IsHandlingUserInput
        {
            get
            {
                return this.GetProperty<bool>("isHandlingUserInput");
            }
        }
        
        public object GetConstraints()
        {
            return this.CallMethod<object>("getConstraints");
        }
    }
}
