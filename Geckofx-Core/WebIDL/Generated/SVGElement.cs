namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGElement : WebIDLBase
    {
        
        public SVGElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public nsISupports ClassName
        {
            get
            {
                return this.GetProperty<nsISupports>("className");
            }
        }
        
        public nsISupports Dataset
        {
            get
            {
                return this.GetProperty<nsISupports>("dataset");
            }
        }
        
        public nsISupports Style
        {
            get
            {
                return this.GetProperty<nsISupports>("style");
            }
        }
        
        public nsISupports OwnerSVGElement
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerSVGElement");
            }
        }
        
        public nsISupports ViewportElement
        {
            get
            {
                return this.GetProperty<nsISupports>("viewportElement");
            }
        }
        
        public int TabIndex
        {
            get
            {
                return this.GetProperty<int>("tabIndex");
            }
            set
            {
                this.SetProperty("tabIndex", value);
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
    }
}
