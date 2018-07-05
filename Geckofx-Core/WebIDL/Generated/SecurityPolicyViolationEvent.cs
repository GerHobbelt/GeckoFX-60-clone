namespace Gecko.WebIDL
{
    using System;
    
    
    public class SecurityPolicyViolationEvent : WebIDLBase
    {
        
        public SecurityPolicyViolationEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string DocumentURI
        {
            get
            {
                return this.GetProperty<string>("documentURI");
            }
        }
        
        public string Referrer
        {
            get
            {
                return this.GetProperty<string>("referrer");
            }
        }
        
        public string BlockedURI
        {
            get
            {
                return this.GetProperty<string>("blockedURI");
            }
        }
        
        public string ViolatedDirective
        {
            get
            {
                return this.GetProperty<string>("violatedDirective");
            }
        }
        
        public string EffectiveDirective
        {
            get
            {
                return this.GetProperty<string>("effectiveDirective");
            }
        }
        
        public string OriginalPolicy
        {
            get
            {
                return this.GetProperty<string>("originalPolicy");
            }
        }
        
        public string SourceFile
        {
            get
            {
                return this.GetProperty<string>("sourceFile");
            }
        }
        
        public string Sample
        {
            get
            {
                return this.GetProperty<string>("sample");
            }
        }
        
        public SecurityPolicyViolationEventDisposition Disposition
        {
            get
            {
                return this.GetProperty<SecurityPolicyViolationEventDisposition>("disposition");
            }
        }
        
        public ushort StatusCode
        {
            get
            {
                return this.GetProperty<ushort>("statusCode");
            }
        }
        
        public int LineNumber
        {
            get
            {
                return this.GetProperty<int>("lineNumber");
            }
        }
        
        public int ColumnNumber
        {
            get
            {
                return this.GetProperty<int>("columnNumber");
            }
        }
    }
}
