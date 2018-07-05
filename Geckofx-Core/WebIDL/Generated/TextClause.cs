namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextClause : WebIDLBase
    {
        
        public TextClause(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int StartOffset
        {
            get
            {
                return this.GetProperty<int>("startOffset");
            }
        }
        
        public int EndOffset
        {
            get
            {
                return this.GetProperty<int>("endOffset");
            }
        }
        
        public bool IsCaret
        {
            get
            {
                return this.GetProperty<bool>("isCaret");
            }
        }
        
        public bool IsTargetClause
        {
            get
            {
                return this.GetProperty<bool>("isTargetClause");
            }
        }
    }
}
