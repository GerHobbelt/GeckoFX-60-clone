namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnonymousContent : WebIDLBase
    {
        
        public AnonymousContent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string GetTextContentForElement(string elementId)
        {
            return this.CallMethod<string>("getTextContentForElement", elementId);
        }
        
        public void SetTextContentForElement(string elementId, string text)
        {
            this.CallVoidMethod("setTextContentForElement", elementId, text);
        }
        
        public string GetAttributeForElement(string elementId, string attributeName)
        {
            return this.CallMethod<string>("getAttributeForElement", elementId, attributeName);
        }
        
        public void SetAttributeForElement(string elementId, string attributeName, string value)
        {
            this.CallVoidMethod("setAttributeForElement", elementId, attributeName, value);
        }
        
        public void RemoveAttributeForElement(string elementId, string attributeName)
        {
            this.CallVoidMethod("removeAttributeForElement", elementId, attributeName);
        }
        
        public nsISupports GetCanvasContext(string elementId, string contextId)
        {
            return this.CallMethod<nsISupports>("getCanvasContext", elementId, contextId);
        }
        
        public nsISupports SetAnimationForElement(string elementId, object keyframes)
        {
            return this.CallMethod<nsISupports>("setAnimationForElement", elementId, keyframes);
        }
        
        public nsISupports SetAnimationForElement(string elementId, object keyframes, WebIDLUnion<System.Double,System.Object> options)
        {
            return this.CallMethod<nsISupports>("setAnimationForElement", elementId, keyframes, options);
        }
        
        public void SetCutoutRectsForElement(string elementId, nsISupports[] rects)
        {
            this.CallVoidMethod("setCutoutRectsForElement", elementId, rects);
        }
        
        public string GetComputedStylePropertyValue(string elementId, string propertyName)
        {
            return this.CallMethod<string>("getComputedStylePropertyValue", elementId, propertyName);
        }
    }
}
