namespace Gecko.WebIDL
{
    using System;
    
    
    public class MutationEvent : WebIDLBase
    {
        
        public MutationEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode RelatedNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("relatedNode");
            }
        }
        
        public string PrevValue
        {
            get
            {
                return this.GetProperty<string>("prevValue");
            }
        }
        
        public string NewValue
        {
            get
            {
                return this.GetProperty<string>("newValue");
            }
        }
        
        public string AttrName
        {
            get
            {
                return this.GetProperty<string>("attrName");
            }
        }
        
        public ushort AttrChange
        {
            get
            {
                return this.GetProperty<ushort>("attrChange");
            }
        }
        
        public void InitMutationEvent(string type)
        {
            this.CallVoidMethod("initMutationEvent", type);
        }
        
        public void InitMutationEvent(string type, bool canBubble)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue, string newValue)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue, string newValue, string attrName)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue, attrName);
        }
        
        public void InitMutationEvent(string type, bool canBubble, bool cancelable, nsIDOMNode relatedNode, string prevValue, string newValue, string attrName, ushort attrChange)
        {
            this.CallVoidMethod("initMutationEvent", type, canBubble, cancelable, relatedNode, prevValue, newValue, attrName, attrChange);
        }
    }
}
