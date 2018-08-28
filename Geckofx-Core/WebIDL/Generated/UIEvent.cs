namespace Gecko.WebIDL
{
    using System;
    
    
    public class UIEvent : WebIDLBase
    {
        
        public UIEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public mozIDOMWindow View
        {
            get
            {
                return this.GetProperty<mozIDOMWindow>("view");
            }
        }
        
        public int Detail
        {
            get
            {
                return this.GetProperty<int>("detail");
            }
        }
        
        public void InitUIEvent(string aType)
        {
            this.CallVoidMethod("initUIEvent", aType);
        }
        
        public void InitUIEvent(string aType, bool aCanBubble)
        {
            this.CallVoidMethod("initUIEvent", aType, aCanBubble);
        }
        
        public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable)
        {
            this.CallVoidMethod("initUIEvent", aType, aCanBubble, aCancelable);
        }
        
        public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, nsIDOMWindow aView)
        {
            this.CallVoidMethod("initUIEvent", aType, aCanBubble, aCancelable, aView);
        }
        
        public void InitUIEvent(string aType, bool aCanBubble, bool aCancelable, nsIDOMWindow aView, int aDetail)
        {
            this.CallVoidMethod("initUIEvent", aType, aCanBubble, aCancelable, aView, aDetail);
        }
        
        public int LayerX
        {
            get
            {
                return this.GetProperty<int>("layerX");
            }
        }
        
        public int LayerY
        {
            get
            {
                return this.GetProperty<int>("layerY");
            }
        }
        
        public int PageX
        {
            get
            {
                return this.GetProperty<int>("pageX");
            }
        }
        
        public int PageY
        {
            get
            {
                return this.GetProperty<int>("pageY");
            }
        }
        
        public uint Which
        {
            get
            {
                return this.GetProperty<uint>("which");
            }
        }
        
        public nsIDOMNode RangeParent
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("rangeParent");
            }
        }
        
        public int RangeOffset
        {
            get
            {
                return this.GetProperty<int>("rangeOffset");
            }
        }
    }
}
