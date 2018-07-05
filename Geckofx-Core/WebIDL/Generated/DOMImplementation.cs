namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMImplementation : WebIDLBase
    {
        
        public DOMImplementation(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool HasFeature()
        {
            return this.CallMethod<bool>("hasFeature");
        }
        
        public nsISupports CreateDocumentType(string qualifiedName, string publicId, string systemId)
        {
            return this.CallMethod<nsISupports>("createDocumentType", qualifiedName, publicId, systemId);
        }
        
        public nsIDOMDocument CreateDocument(string @namespace, string qualifiedName)
        {
            return this.CallMethod<nsIDOMDocument>("createDocument", @namespace, qualifiedName);
        }
        
        public nsIDOMDocument CreateDocument(string @namespace, string qualifiedName, nsISupports doctype)
        {
            return this.CallMethod<nsIDOMDocument>("createDocument", @namespace, qualifiedName, doctype);
        }
        
        public nsIDOMDocument CreateHTMLDocument()
        {
            return this.CallMethod<nsIDOMDocument>("createHTMLDocument");
        }
        
        public nsIDOMDocument CreateHTMLDocument(string title)
        {
            return this.CallMethod<nsIDOMDocument>("createHTMLDocument", title);
        }
    }
}
