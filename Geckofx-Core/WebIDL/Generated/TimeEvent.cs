namespace Gecko.WebIDL
{
    using System;
    
    
    public class TimeEvent : WebIDLBase
    {
        
        public TimeEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Detail
        {
            get
            {
                return this.GetProperty<int>("detail");
            }
        }
        
        public mozIDOMWindow View
        {
            get
            {
                return this.GetProperty<mozIDOMWindow>("view");
            }
        }
        
        public void InitTimeEvent(string aType)
        {
            this.CallVoidMethod("initTimeEvent", aType);
        }
        
        public void InitTimeEvent(string aType, nsIDOMWindow aView)
        {
            this.CallVoidMethod("initTimeEvent", aType, aView);
        }
        
        public void InitTimeEvent(string aType, nsIDOMWindow aView, int aDetail)
        {
            this.CallVoidMethod("initTimeEvent", aType, aView, aDetail);
        }
    }
}
