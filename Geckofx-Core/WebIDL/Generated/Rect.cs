namespace Gecko.WebIDL
{
    using System;
    
    
    public class Rect : WebIDLBase
    {
        
        public Rect(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Top
        {
            get
            {
                return this.GetProperty<nsISupports>("top");
            }
        }
        
        public nsISupports Right
        {
            get
            {
                return this.GetProperty<nsISupports>("right");
            }
        }
        
        public nsISupports Bottom
        {
            get
            {
                return this.GetProperty<nsISupports>("bottom");
            }
        }
        
        public nsISupports Left
        {
            get
            {
                return this.GetProperty<nsISupports>("left");
            }
        }
    }
}
