namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLIFrameElement : WebIDLBase
    {
        
        public HTMLIFrameElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Src
        {
            get
            {
                return this.GetProperty<string>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public string Srcdoc
        {
            get
            {
                return this.GetProperty<string>("srcdoc");
            }
            set
            {
                this.SetProperty("srcdoc", value);
            }
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
        
        public nsISupports Sandbox
        {
            get
            {
                return this.GetProperty<nsISupports>("sandbox");
            }
        }
        
        public bool AllowFullscreen
        {
            get
            {
                return this.GetProperty<bool>("allowFullscreen");
            }
            set
            {
                this.SetProperty("allowFullscreen", value);
            }
        }
        
        public bool AllowPaymentRequest
        {
            get
            {
                return this.GetProperty<bool>("allowPaymentRequest");
            }
            set
            {
                this.SetProperty("allowPaymentRequest", value);
            }
        }
        
        public string Width
        {
            get
            {
                return this.GetProperty<string>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public string Height
        {
            get
            {
                return this.GetProperty<string>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public string ReferrerPolicy
        {
            get
            {
                return this.GetProperty<string>("referrerPolicy");
            }
            set
            {
                this.SetProperty("referrerPolicy", value);
            }
        }
        
        public nsIDOMDocument ContentDocument
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("contentDocument");
            }
        }
        
        public mozIDOMWindow ContentWindow
        {
            get
            {
                return this.GetProperty<mozIDOMWindow>("contentWindow");
            }
        }
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Scrolling
        {
            get
            {
                return this.GetProperty<string>("scrolling");
            }
            set
            {
                this.SetProperty("scrolling", value);
            }
        }
        
        public string FrameBorder
        {
            get
            {
                return this.GetProperty<string>("frameBorder");
            }
            set
            {
                this.SetProperty("frameBorder", value);
            }
        }
        
        public string LongDesc
        {
            get
            {
                return this.GetProperty<string>("longDesc");
            }
            set
            {
                this.SetProperty("longDesc", value);
            }
        }
        
        public string MarginHeight
        {
            get
            {
                return this.GetProperty<string>("marginHeight");
            }
            set
            {
                this.SetProperty("marginHeight", value);
            }
        }
        
        public string MarginWidth
        {
            get
            {
                return this.GetProperty<string>("marginWidth");
            }
            set
            {
                this.SetProperty("marginWidth", value);
            }
        }
        
        public nsIDOMDocument GetSVGDocument()
        {
            return this.CallMethod<nsIDOMDocument>("getSVGDocument");
        }
        
        public bool Mozbrowser
        {
            get
            {
                return this.GetProperty<bool>("mozbrowser");
            }
            set
            {
                this.SetProperty("mozbrowser", value);
            }
        }
    }
}
