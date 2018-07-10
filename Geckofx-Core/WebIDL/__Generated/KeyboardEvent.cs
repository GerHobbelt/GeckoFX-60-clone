namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyboardEvent : WebIDLBase
    {
        
        public KeyboardEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint CharCode
        {
            get
            {
                return this.GetProperty<uint>("charCode");
            }
        }
        
        public uint KeyCode
        {
            get
            {
                return this.GetProperty<uint>("keyCode");
            }
        }
        
        public bool AltKey
        {
            get
            {
                return this.GetProperty<bool>("altKey");
            }
        }
        
        public bool CtrlKey
        {
            get
            {
                return this.GetProperty<bool>("ctrlKey");
            }
        }
        
        public bool ShiftKey
        {
            get
            {
                return this.GetProperty<bool>("shiftKey");
            }
        }
        
        public bool MetaKey
        {
            get
            {
                return this.GetProperty<bool>("metaKey");
            }
        }
        
        public uint Location
        {
            get
            {
                return this.GetProperty<uint>("location");
            }
        }
        
        public bool Repeat
        {
            get
            {
                return this.GetProperty<bool>("repeat");
            }
        }
        
        public bool IsComposing
        {
            get
            {
                return this.GetProperty<bool>("isComposing");
            }
        }
        
        public string Key
        {
            get
            {
                return this.GetProperty<string>("key");
            }
        }
        
        public string Code
        {
            get
            {
                return this.GetProperty<string>("code");
            }
        }
        
        public object InitDict
        {
            get
            {
                return this.GetProperty<object>("initDict");
            }
        }
        
        public bool GetModifierState(string key)
        {
            return this.CallMethod<bool>("getModifierState", key);
        }
        
        public void InitKeyboardEvent(string typeArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg, uint locationArg)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg, locationArg);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg, uint locationArg, bool ctrlKey)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg, locationArg, ctrlKey);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg, uint locationArg, bool ctrlKey, bool altKey)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg, locationArg, ctrlKey, altKey);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg, uint locationArg, bool ctrlKey, bool altKey, bool shiftKey)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg, locationArg, ctrlKey, altKey, shiftKey);
        }
        
        public void InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, nsIDOMWindow viewArg, string keyArg, uint locationArg, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey)
        {
            this.CallVoidMethod("initKeyboardEvent", typeArg, bubblesArg, cancelableArg, viewArg, keyArg, locationArg, ctrlKey, altKey, shiftKey, metaKey);
        }
    }
}
