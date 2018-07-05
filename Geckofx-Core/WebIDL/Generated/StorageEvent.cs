namespace Gecko.WebIDL
{
    using System;
    
    
    public class StorageEvent : WebIDLBase
    {
        
        public StorageEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Key
        {
            get
            {
                return this.GetProperty<string>("key");
            }
        }
        
        public string OldValue
        {
            get
            {
                return this.GetProperty<string>("oldValue");
            }
        }
        
        public string NewValue
        {
            get
            {
                return this.GetProperty<string>("newValue");
            }
        }
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
            }
        }
        
        public nsISupports StorageArea
        {
            get
            {
                return this.GetProperty<nsISupports>("storageArea");
            }
        }
        
        public void InitStorageEvent(string type)
        {
            this.CallVoidMethod("initStorageEvent", type);
        }
        
        public void InitStorageEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue, url);
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, nsISupports storageArea)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue, url, storageArea);
        }
    }
}
