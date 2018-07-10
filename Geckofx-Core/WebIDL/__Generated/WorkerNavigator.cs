namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerNavigator : WebIDLBase
    {
        
        public WorkerNavigator(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
    }
}
