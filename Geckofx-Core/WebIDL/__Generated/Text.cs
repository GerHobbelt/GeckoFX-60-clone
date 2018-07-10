namespace Gecko.WebIDL
{
    using System;
    
    
    public class Text : WebIDLBase
    {
        
        public Text(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string WholeText
        {
            get
            {
                return this.GetProperty<string>("wholeText");
            }
        }
        
        public nsIDOMText SplitText(uint offset)
        {
            return this.CallMethod<nsIDOMText>("splitText", offset);
        }
        
        public nsISupports AssignedSlot
        {
            get
            {
                return this.GetProperty<nsISupports>("assignedSlot");
            }
        }
    }
}
