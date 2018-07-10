namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSCounterStyleRule : WebIDLBase
    {
        
        public CSSCounterStyleRule(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public string System
        {
            get
            {
                return this.GetProperty<string>("system");
            }
            set
            {
                this.SetProperty("system", value);
            }
        }
        
        public string Symbols
        {
            get
            {
                return this.GetProperty<string>("symbols");
            }
            set
            {
                this.SetProperty("symbols", value);
            }
        }
        
        public string AdditiveSymbols
        {
            get
            {
                return this.GetProperty<string>("additiveSymbols");
            }
            set
            {
                this.SetProperty("additiveSymbols", value);
            }
        }
        
        public string Negative
        {
            get
            {
                return this.GetProperty<string>("negative");
            }
            set
            {
                this.SetProperty("negative", value);
            }
        }
        
        public string Prefix
        {
            get
            {
                return this.GetProperty<string>("prefix");
            }
            set
            {
                this.SetProperty("prefix", value);
            }
        }
        
        public string Suffix
        {
            get
            {
                return this.GetProperty<string>("suffix");
            }
            set
            {
                this.SetProperty("suffix", value);
            }
        }
        
        public string Range
        {
            get
            {
                return this.GetProperty<string>("range");
            }
            set
            {
                this.SetProperty("range", value);
            }
        }
        
        public string Pad
        {
            get
            {
                return this.GetProperty<string>("pad");
            }
            set
            {
                this.SetProperty("pad", value);
            }
        }
        
        public string SpeakAs
        {
            get
            {
                return this.GetProperty<string>("speakAs");
            }
            set
            {
                this.SetProperty("speakAs", value);
            }
        }
        
        public string Fallback
        {
            get
            {
                return this.GetProperty<string>("fallback");
            }
            set
            {
                this.SetProperty("fallback", value);
            }
        }
    }
}
