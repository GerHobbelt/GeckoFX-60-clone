namespace Gecko.WebIDL
{
    using System;
    
    
    public class EXT_disjoint_timer_query : WebIDLBase
    {
        
        public EXT_disjoint_timer_query(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateQueryEXT()
        {
            return this.CallMethod<nsISupports>("createQueryEXT");
        }
        
        public void DeleteQueryEXT(nsISupports query)
        {
            this.CallVoidMethod("deleteQueryEXT", query);
        }
        
        public bool IsQueryEXT(nsISupports query)
        {
            return this.CallMethod<bool>("isQueryEXT", query);
        }
        
        public void BeginQueryEXT(uint target, nsISupports query)
        {
            this.CallVoidMethod("beginQueryEXT", target, query);
        }
        
        public void EndQueryEXT(uint target)
        {
            this.CallVoidMethod("endQueryEXT", target);
        }
        
        public void QueryCounterEXT(nsISupports query, uint target)
        {
            this.CallVoidMethod("queryCounterEXT", query, target);
        }
        
        public object GetQueryEXT(uint target, uint pname)
        {
            return this.CallMethod<object>("getQueryEXT", target, pname);
        }
        
        public object GetQueryObjectEXT(nsISupports query, uint pname)
        {
            return this.CallMethod<object>("getQueryObjectEXT", query, pname);
        }
    }
}
