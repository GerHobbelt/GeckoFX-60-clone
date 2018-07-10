namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisEvent : WebIDLBase
    {
        
        public SpeechSynthesisEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Utterance
        {
            get
            {
                return this.GetProperty<nsISupports>("utterance");
            }
        }
        
        public uint CharIndex
        {
            get
            {
                return this.GetProperty<uint>("charIndex");
            }
        }
        
        public System.Nullable<uint> CharLength
        {
            get
            {
                return this.GetProperty<System.Nullable<uint>>("charLength");
            }
        }
        
        public float ElapsedTime
        {
            get
            {
                return this.GetProperty<float>("elapsedTime");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
    }
}
