namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULElement : WebIDLBase
    {
        
        public XULElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Dir
        {
            get
            {
                return this.GetProperty<string>("dir");
            }
            set
            {
                this.SetProperty("dir", value);
            }
        }
        
        public string Flex
        {
            get
            {
                return this.GetProperty<string>("flex");
            }
            set
            {
                this.SetProperty("flex", value);
            }
        }
        
        public string FlexGroup
        {
            get
            {
                return this.GetProperty<string>("flexGroup");
            }
            set
            {
                this.SetProperty("flexGroup", value);
            }
        }
        
        public string Ordinal
        {
            get
            {
                return this.GetProperty<string>("ordinal");
            }
            set
            {
                this.SetProperty("ordinal", value);
            }
        }
        
        public string Orient
        {
            get
            {
                return this.GetProperty<string>("orient");
            }
            set
            {
                this.SetProperty("orient", value);
            }
        }
        
        public string Pack
        {
            get
            {
                return this.GetProperty<string>("pack");
            }
            set
            {
                this.SetProperty("pack", value);
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.GetProperty<bool>("hidden");
            }
            set
            {
                this.SetProperty("hidden", value);
            }
        }
        
        public bool Collapsed
        {
            get
            {
                return this.GetProperty<bool>("collapsed");
            }
            set
            {
                this.SetProperty("collapsed", value);
            }
        }
        
        public string Observes
        {
            get
            {
                return this.GetProperty<string>("observes");
            }
            set
            {
                this.SetProperty("observes", value);
            }
        }
        
        public string Menu
        {
            get
            {
                return this.GetProperty<string>("menu");
            }
            set
            {
                this.SetProperty("menu", value);
            }
        }
        
        public string ContextMenu
        {
            get
            {
                return this.GetProperty<string>("contextMenu");
            }
            set
            {
                this.SetProperty("contextMenu", value);
            }
        }
        
        public string Tooltip
        {
            get
            {
                return this.GetProperty<string>("tooltip");
            }
            set
            {
                this.SetProperty("tooltip", value);
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
        
        public string MinWidth
        {
            get
            {
                return this.GetProperty<string>("minWidth");
            }
            set
            {
                this.SetProperty("minWidth", value);
            }
        }
        
        public string MinHeight
        {
            get
            {
                return this.GetProperty<string>("minHeight");
            }
            set
            {
                this.SetProperty("minHeight", value);
            }
        }
        
        public string MaxWidth
        {
            get
            {
                return this.GetProperty<string>("maxWidth");
            }
            set
            {
                this.SetProperty("maxWidth", value);
            }
        }
        
        public string MaxHeight
        {
            get
            {
                return this.GetProperty<string>("maxHeight");
            }
            set
            {
                this.SetProperty("maxHeight", value);
            }
        }
        
        public string Persist
        {
            get
            {
                return this.GetProperty<string>("persist");
            }
            set
            {
                this.SetProperty("persist", value);
            }
        }
        
        public string Left
        {
            get
            {
                return this.GetProperty<string>("left");
            }
            set
            {
                this.SetProperty("left", value);
            }
        }
        
        public string Top
        {
            get
            {
                return this.GetProperty<string>("top");
            }
            set
            {
                this.SetProperty("top", value);
            }
        }
        
        public string TooltipText
        {
            get
            {
                return this.GetProperty<string>("tooltipText");
            }
            set
            {
                this.SetProperty("tooltipText", value);
            }
        }
        
        public string StatusText
        {
            get
            {
                return this.GetProperty<string>("statusText");
            }
            set
            {
                this.SetProperty("statusText", value);
            }
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
        
        public bool AllowEvents
        {
            get
            {
                return this.GetProperty<bool>("allowEvents");
            }
            set
            {
                this.SetProperty("allowEvents", value);
            }
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public nsISupports BoxObject
        {
            get
            {
                return this.GetProperty<nsISupports>("boxObject");
            }
        }
        
        public nsISupports Style
        {
            get
            {
                return this.GetProperty<nsISupports>("style");
            }
        }
        
        public void Focus()
        {
            this.CallVoidMethod("focus");
        }
        
        public void Blur()
        {
            this.CallVoidMethod("blur");
        }
        
        public void Click()
        {
            this.CallVoidMethod("click");
        }
        
        public void DoCommand()
        {
            this.CallVoidMethod("doCommand");
        }
        
        public nsISupports GetElementsByAttribute(string name, string value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttribute", name, value);
        }
        
        public nsISupports GetElementsByAttributeNS(string namespaceURI, string name, string value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttributeNS", namespaceURI, name, value);
        }
    }
}
