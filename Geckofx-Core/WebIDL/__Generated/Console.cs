namespace Gecko.WebIDL
{
    using System;
    
    
    public class console : WebIDLBase
    {
        
        public console(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Assert()
        {
            this.CallVoidMethod("assert");
        }
        
        public void Assert(bool condition)
        {
            this.CallVoidMethod("assert", condition);
        }
        
        public void Assert(bool condition, object data)
        {
            this.CallVoidMethod("assert", condition, data);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public void Count()
        {
            this.CallVoidMethod("count");
        }
        
        public void Count(string label)
        {
            this.CallVoidMethod("count", label);
        }
        
        public void Debug(object data)
        {
            this.CallVoidMethod("debug", data);
        }
        
        public void Error(object data)
        {
            this.CallVoidMethod("error", data);
        }
        
        public void Info(object data)
        {
            this.CallVoidMethod("info", data);
        }
        
        public void Log(object data)
        {
            this.CallVoidMethod("log", data);
        }
        
        public void Table(object data)
        {
            this.CallVoidMethod("table", data);
        }
        
        public void Trace(object data)
        {
            this.CallVoidMethod("trace", data);
        }
        
        public void Warn(object data)
        {
            this.CallVoidMethod("warn", data);
        }
        
        public void Dir(object data)
        {
            this.CallVoidMethod("dir", data);
        }
        
        public void Dirxml(object data)
        {
            this.CallVoidMethod("dirxml", data);
        }
        
        public void Group(object data)
        {
            this.CallVoidMethod("group", data);
        }
        
        public void GroupCollapsed(object data)
        {
            this.CallVoidMethod("groupCollapsed", data);
        }
        
        public void GroupEnd()
        {
            this.CallVoidMethod("groupEnd");
        }
        
        public void Time()
        {
            this.CallVoidMethod("time");
        }
        
        public void Time(string label)
        {
            this.CallVoidMethod("time", label);
        }
        
        public void TimeEnd()
        {
            this.CallVoidMethod("timeEnd");
        }
        
        public void TimeEnd(string label)
        {
            this.CallVoidMethod("timeEnd", label);
        }
        
        public void _exception(object data)
        {
            this.CallVoidMethod("_exception", data);
        }
        
        public void TimeStamp()
        {
            this.CallVoidMethod("timeStamp");
        }
        
        public void TimeStamp(object data)
        {
            this.CallVoidMethod("timeStamp", data);
        }
        
        public void Profile(object data)
        {
            this.CallVoidMethod("profile", data);
        }
        
        public void ProfileEnd(object data)
        {
            this.CallVoidMethod("profileEnd", data);
        }
        
        public nsISupports CreateInstance()
        {
            return this.CallMethod<nsISupports>("createInstance");
        }
        
        public nsISupports CreateInstance(object options)
        {
            return this.CallMethod<nsISupports>("createInstance", options);
        }
    }
}
