namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionResult : WebIDLBase
    {
        
        public SpeechRecognitionResult(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
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
        
        public bool IsFinal
        {
            get
            {
                return this.GetProperty<bool>("isFinal");
            }
        }
        
        public nsISupports Item(uint index)
        {
            return this.CallMethod<nsISupports>("item", index);
        }
    }
}
