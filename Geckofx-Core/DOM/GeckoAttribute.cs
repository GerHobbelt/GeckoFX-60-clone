using System;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM attribute.
    /// </summary>
    public class GeckoAttribute : GeckoNode
    {
        internal GeckoAttribute(nsISupports window, /*nsIDOMAttr*/ nsIDOMElement attr) : base(window, attr)
        {
            this.DomAttr = attr;
        }

        internal /*nsIDOMAttr*/ nsIDOMElement DomAttr;

        internal static GeckoAttribute CreateAttributeWrapper(nsISupports window,/*nsIDOMAttr*/ nsIDOMElement attr)
        {
            return (attr == null) ? null : new GeckoAttribute(window, attr);
        }

        /// <summary>
        /// Gets the name of the attribute.
        /// </summary>
        public string Name
        {
            get { /*return nsString.Get(DomAttr.GetNameAttribute);*/ throw new NotImplementedException();}
        }

        /// <summary>
        /// Gets the <see cref="GeckoHtmlElement"/> which contains this attribute.
        /// </summary>
        public GeckoNode OwnerDocument
        {
            get
            {
                throw new NotImplementedException();
#if PORTFF60
                return GeckoNode.Create((/* nsIDOMHTMLElement */nsISupports) DomAttr.GetOwnerDocumentAttribute());
#endif

            }
        }

        /// <summary>
        /// Gets a value indicating whether the attribute is specified.
        /// </summary>
        public bool Specified
        {
            get { /*return DomAttr.GetSpecifiedAttribute();*/throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the value of the attribute.
        /// </summary>
        public string Value
        {
            get { /*return nsString.Get(DomAttr.GetValueAttribute);*/throw new NotImplementedException(); }
            set {/* nsString.Set(DomAttr.SetValueAttribute, value);*/throw new NotImplementedException(); }
        }
    }
}