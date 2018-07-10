namespace Gecko.WebIDL
{
    using System;
    
    
    public class CommandEvent : WebIDLBase
    {
        
        public CommandEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Command
        {
            get
            {
                return this.GetProperty<string>("command");
            }
        }
    }
}
