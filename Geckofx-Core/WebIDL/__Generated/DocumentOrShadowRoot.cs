namespace Gecko.WebIDL
{
    using System;
    
    
    public class DocumentOrShadowRoot : WebIDLBase
    {
        
        public DocumentOrShadowRoot(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement ActiveElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("activeElement");
            }
        }
        
        public nsISupports StyleSheets
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheets");
            }
        }
        
        public nsIDOMElement PointerLockElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("pointerLockElement");
            }
        }
        
        public nsIDOMElement FullscreenElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("fullscreenElement");
            }
        }
        
        public nsIDOMElement MozFullScreenElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("mozFullScreenElement");
            }
        }
        
        public nsIDOMElement ElementFromPoint(float x, float y)
        {
            return this.CallMethod<nsIDOMElement>("elementFromPoint", x, y);
        }
        
        public nsIDOMElement[] ElementsFromPoint(float x, float y)
        {
            return this.CallMethod<nsIDOMElement[]>("elementsFromPoint", x, y);
        }
    }
}
