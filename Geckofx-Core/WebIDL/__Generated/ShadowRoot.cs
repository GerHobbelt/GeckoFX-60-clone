namespace Gecko.WebIDL
{
    using System;
    
    
    public class ShadowRoot : WebIDLBase
    {
        
        public ShadowRoot(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ShadowRootMode Mode
        {
            get
            {
                return this.GetProperty<ShadowRootMode>("mode");
            }
        }
        
        public nsIDOMElement Host
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("host");
            }
        }
        
        public string InnerHTML
        {
            get
            {
                return this.GetProperty<string>("innerHTML");
            }
            set
            {
                this.SetProperty("innerHTML", value);
            }
        }
        
        public nsIDOMElement GetElementById(string elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsISupports GetElementsByTagName(string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagName", localName);
        }
        
        public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagNameNS", @namespace, localName);
        }
        
        public nsISupports GetElementsByClassName(string classNames)
        {
            return this.CallMethod<nsISupports>("getElementsByClassName", classNames);
        }
    }
}
