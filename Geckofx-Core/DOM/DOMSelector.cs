using System;
using System.Collections.Generic;
using System.Text;

namespace Gecko.DOM
{
    internal static class DOMSelector
    {
        private static readonly Dictionary<string, GeckoClassDesc> _dictionary =
            new Dictionary<string, GeckoClassDesc>();

        private struct GeckoClassDesc
        {
            public string TagName { get; set; }
            public Type InterfaceType { get; set; }
            public Type GeckoElement { get; set; }

            public ObjectCreator CreationMethod { get; set; }

            public delegate GeckoHtmlElement ObjectCreator(nsISupports window, object htmlElementInterface);
        }

        private static void Add(GeckoClassDesc classDesc)
        {
            _dictionary.Add(classDesc.TagName.ToLowerInvariant(), classDesc);
        }

        static DOMSelector()
        {
            Add(new GeckoClassDesc()
            {
                TagName = "a",
                InterfaceType = typeof (/* nsIDOMHTMLAnchorElement */ nsISupports),
                GeckoElement = typeof (GeckoAnchorElement),
                CreationMethod = (window, x) => new GeckoAnchorElement(window, (/* nsIDOMHTMLAnchorElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "applet",
                InterfaceType = typeof (/* nsIDOMHTMLAppletElement */ nsISupports),
                GeckoElement = typeof (GeckoAppletElement),
                CreationMethod = (window,x) => new GeckoAppletElement(window, (/* nsIDOMHTMLAppletElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "area",
                InterfaceType = typeof (/* nsIDOMHTMLAreaElement */ nsISupports),
                GeckoElement = typeof (GeckoAreaElement),
                CreationMethod = (window,x) => new GeckoAreaElement(window, (/* nsIDOMHTMLAreaElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "base",
                InterfaceType = typeof (/* nsIDOMHTMLBaseElement */ nsISupports),
                GeckoElement = typeof (GeckoBaseElement),
                CreationMethod = (window,x) => new GeckoBaseElement(window, (/* nsIDOMHTMLBaseElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "body",
                InterfaceType = typeof (/* nsIDOMHTMLBodyElement */ nsISupports),
                GeckoElement = typeof (GeckoBodyElement),
                CreationMethod = (window,x) => new GeckoBodyElement(window,(/* nsIDOMHTMLBodyElement */ nsIDOMElement) x)
            });
#if NO_LONGER_EXISTS_GECKO45
			Add(new GeckoClassDesc() { TagName = "br", InterfaceType = typeof(nsIDOMHTMLBRElement), GeckoElement = typeof(GeckoBRElement), 
				CreationMethod = (window,x) => new GeckoBRElement((nsIDOMHTMLBRElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "button",
                InterfaceType = typeof (/* nsIDOMHTMLButtonElement */ nsISupports),
                GeckoElement = typeof (GeckoButtonElement),
                CreationMethod = (window,x) => new GeckoButtonElement(window, (/* nsIDOMHTMLButtonElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "canvas",
                InterfaceType = typeof (/* nsIDOMHTMLCanvasElement */ nsISupports),
                GeckoElement = typeof (GeckoCanvasElement),
                CreationMethod = (window,x) => new GeckoCanvasElement(window, (/* nsIDOMHTMLCanvasElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "dir",
                InterfaceType = typeof (/* nsIDOMHTMLDirectoryElement */ nsISupports),
                GeckoElement = typeof (GeckoDirectoryElement),
                CreationMethod = (window,x) => new GeckoDirectoryElement(window, (/* nsIDOMHTMLDirectoryElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "embed",
                InterfaceType = typeof (/* nsIDOMHTMLEmbedElement */ nsISupports),
                GeckoElement = typeof (GeckoEmbedElement),
                CreationMethod = (window,x) => new GeckoEmbedElement(window, (/* nsIDOMHTMLEmbedElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "fieldset",
                InterfaceType = typeof (/* nsIDOMHTMLFieldSetElement */ nsISupports),
                GeckoElement = typeof (GeckoFieldSetElement),
                CreationMethod = (window,x) => new GeckoFieldSetElement(window, (/* nsIDOMHTMLFieldSetElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "form",
                InterfaceType = typeof (nsIDOMHTMLFormElement),
                GeckoElement = typeof (GeckoFormElement),
                CreationMethod = (window,x) => new GeckoFormElement(window, (nsIDOMHTMLFormElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "frame",
                InterfaceType = typeof (/* nsIDOMHTMLFrameElement */ nsIDOMElement),
                GeckoElement = typeof (GeckoFrameElement),
                CreationMethod = (window,x) => new GeckoFrameElement(window,/* nsIDOMHTMLFrameElement */ (nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "frameset",
                InterfaceType = typeof (/* nsIDOMHTMLFrameSetElement */ nsISupports),
                GeckoElement = typeof (GeckoFrameSetElement),
                CreationMethod = (window,x) => new GeckoFrameSetElement(window, (/* nsIDOMHTMLFrameSetElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "head",
                InterfaceType = typeof (/* nsIDOMHTMLHeadElement */ nsISupports),
                GeckoElement = typeof (GeckoHeadElement),
                CreationMethod = (window,x) => new GeckoHeadElement(window, (/* nsIDOMHTMLHeadElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "hr",
                InterfaceType = typeof (/* nsIDOMHTMLHRElement */ nsISupports),
                GeckoElement = typeof (GeckoHRElement),
                CreationMethod = (window,x) => new GeckoHRElement(window, (/* nsIDOMHTMLHRElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "html",
                InterfaceType = typeof (/* nsIDOMHTMLHtmlElement */ nsISupports),
                GeckoElement = typeof (GeckoHtmlHtmlElement),
                CreationMethod = (window,x) => new GeckoHtmlHtmlElement(window, (/* nsIDOMHTMLHtmlElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "iframe",
                InterfaceType = typeof (/* nsIDOMHTMLIFrameElement */ nsISupports),
                GeckoElement = typeof (GeckoIFrameElement),
                CreationMethod = (window,x) => new GeckoIFrameElement(window, (/* nsIDOMHTMLIFrameElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "img",
                InterfaceType = typeof (/* nsIDOMHTMLImageElement */ nsISupports),
                GeckoElement = typeof (GeckoImageElement),
                CreationMethod = (window,x) => new GeckoImageElement(window, (/* nsIDOMHTMLImageElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "input",
                InterfaceType = typeof (nsIDOMHTMLInputElement),
                GeckoElement = typeof (GeckoInputElement),
                CreationMethod = (window,x) => new GeckoInputElement(window, (nsIDOMHTMLInputElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "label",
                InterfaceType = typeof (/* nsIDOMHTMLLabelElement */ nsISupports),
                GeckoElement = typeof (GeckoLabelElement),
                CreationMethod = (window,x) => new GeckoLabelElement(window, (/* nsIDOMHTMLLabelElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "li",
                InterfaceType = typeof (/* nsIDOMHTMLLIElement */ nsISupports),
                GeckoElement = typeof (GeckoLIElement),
                CreationMethod = (window,x) => new GeckoLIElement(window, (/* nsIDOMHTMLLIElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "link",
                InterfaceType = typeof (/* nsIDOMHTMLLinkElement */ nsISupports),
                GeckoElement = typeof (GeckoLinkElement),
                CreationMethod = (window,x) => new GeckoLinkElement(window, (/* nsIDOMHTMLLinkElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "map",
                InterfaceType = typeof (/* nsIDOMHTMLMapElement */ nsISupports),
                GeckoElement = typeof (GeckoMapElement),
                CreationMethod = (window,x) => new GeckoMapElement(window, (/* nsIDOMHTMLMapElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "menu",
                InterfaceType = typeof (/* nsIDOMHTMLMenuElement */ nsISupports),
                GeckoElement = typeof (GeckoMenuElement),
                CreationMethod = (window,x) => new GeckoMenuElement(window, (/* nsIDOMHTMLMenuElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "meta",
                InterfaceType = typeof (/* nsIDOMHTMLMetaElement */ nsISupports),
                GeckoElement = typeof (GeckoMetaElement),
                CreationMethod = (window,x) => new GeckoMetaElement(window, /* nsIDOMHTMLMetaElement */ (nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "object",
                InterfaceType = typeof (/* nsIDOMHTMLObjectElement */ nsISupports),
                GeckoElement = typeof (GeckoObjectElement),
                CreationMethod = (window,x) => new GeckoObjectElement(window, (/* nsIDOMHTMLObjectElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "ol",
                InterfaceType = typeof (/* /* nsIDOMHTMLOListElement*/ nsISupports),
                GeckoElement = typeof (GeckoOListElement),
                CreationMethod = (window,x) => new GeckoOListElement(window, (/* /* nsIDOMHTMLOListElement*/ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "optgroup",
                InterfaceType = typeof (/* nsIDOMHTMLOptGroupElement*/ nsISupports),
                GeckoElement = typeof (GeckoOptGroupElement),
                CreationMethod = (window,x) => new GeckoOptGroupElement(window, (/* nsIDOMHTMLOptGroupElement*/ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "option",
                InterfaceType = typeof (/* nsIDOMHTMLOptionElement */ nsISupports),
                GeckoElement = typeof (GeckoOptionElement),
                CreationMethod = (window,x) => new GeckoOptionElement(window, (/* nsIDOMHTMLOptionElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "p",
                InterfaceType = typeof (/* nsIDOMHTMLParagraphElement */ nsISupports),
                GeckoElement = typeof (GeckoParagraphElement),
                CreationMethod = (window,x) => new GeckoParagraphElement(window, (/* nsIDOMHTMLParagraphElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "pre",
                InterfaceType = typeof (/* nsIDOMHTMLPreElement */ nsISupports),
                GeckoElement = typeof (GeckoPreElement),
                CreationMethod = (window,x) => new GeckoPreElement(window, (/* nsIDOMHTMLPreElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "q",
                InterfaceType = typeof (/* nsIDOMHTMLQuoteElement */ nsISupports),
                GeckoElement = typeof (GeckoQuoteElement),
                CreationMethod = (window,x) => new GeckoQuoteElement(window, (/* nsIDOMHTMLQuoteElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "script",
                InterfaceType = typeof (/* nsIDOMHTMLScriptElement */ nsISupports),
                GeckoElement = typeof (GeckoScriptElement),
                CreationMethod = (window,x) => new GeckoScriptElement(window, (/* nsIDOMHTMLScriptElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "select",
                InterfaceType = typeof (/* nsIDOMHTMLSelectElement */ nsISupports),
                GeckoElement = typeof (GeckoSelectElement),
                CreationMethod = (window,x) => new GeckoSelectElement(window, (/* nsIDOMHTMLSelectElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "style",
                InterfaceType = typeof (/* nsIDOMHTMLStyleElement */ nsISupports),
                GeckoElement = typeof (GeckoStyleElement),
                CreationMethod = (window,x) => new GeckoStyleElement(window, (/* nsIDOMHTMLStyleElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "td",
                InterfaceType = typeof (/* nsIDOMHTMLTableCellElement */ nsISupports),
                GeckoElement = typeof (GeckoTableCellElement),
                CreationMethod = (window,x) => new GeckoTableCellElement(window, (/* nsIDOMHTMLTableCellElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "textarea",
                InterfaceType = typeof (/* nsIDOMHTMLTextAreaElement */ nsISupports),
                GeckoElement = typeof (GeckoTextAreaElement),
                CreationMethod = (window,x) => new GeckoTextAreaElement(window, (/* nsIDOMHTMLTextAreaElement */ nsIDOMElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "ul",
                InterfaceType = typeof (/* nsIDOMHTMLUListElement */ nsISupports),
                GeckoElement = typeof (GeckoUListElement),
                CreationMethod = (window,x) => new GeckoUListElement(window, (/* nsIDOMHTMLUListElement */ nsIDOMElement) x)
            });
        }

        private static GeckoWrapperCache</* nsIDOMHTMLElement */nsISupports, GeckoHtmlElement> m_cache =
            new GeckoWrapperCache</* nsIDOMHTMLElement*/nsISupports, GeckoHtmlElement>(CreateDomHtmlElementWrapper);

        internal static GeckoHtmlElement GetClassFor(nsISupports window,  /* nsIDOMHTMLElement*/nsIDOMElement element)
        {
            GeckoHtmlElement ret = GetClassFor<GeckoHtmlElement>(window, (nsISupports)element);
            if (ret == null)
                ret = new GeckoHtmlElement(window, element);
            return ret;
        }

        internal static T GetClassFor<T>(nsISupports window, /* /* nsIDOMHTMLElement*/nsISupports element) where T : GeckoHtmlElement
        {
            return (T) m_cache.Get(window, element);
        }

        /// <summary>
        /// Creates wrapper for nsIDOMNode object	
        /// </summary>
        /// <param name="domObject"></param>
        /// <returns></returns>
        internal static GeckoNode CreateDomNodeWrapper(nsISupports window, nsIDOMNode domObject)
        {
            // if null -> return null
            if (domObject == null) return null;
            var nodeType = (NodeType)new WebIDL.Node((mozIDOMWindowProxy)window, (nsISupports)domObject).NodeType;

            // by nodeType we can find proper wrapper faster, than perform QueryInterface
            switch (nodeType)
            {
                case NodeType.Element:
                    /* /* nsIDOMHTMLElement*/nsIDOMElement htmlElement = Xpcom.QueryInterface</* /* nsIDOMHTMLElement*/nsIDOMElement>(domObject);
                    if (htmlElement != null) return GeckoHtmlElement.Create(window, htmlElement);
                    nsIDOMElement element = Xpcom.QueryInterface<nsIDOMElement>(domObject);
                    if (element != null) return GeckoElement.CreateDomElementWrapper(window, element);
                    break;
                case NodeType.Attribute:
#if PORTFF60
                    nsIDOMAttr attr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
                    if (attr != null) return GeckoAttribute.CreateAttributeWrapper(attr);
#endif
                    break;
                case NodeType.Comment:
                    nsIDOMComment comment = Xpcom.QueryInterface<nsIDOMComment>(domObject);
                    if (comment != null) return GeckoComment.CreateCommentWrapper(window, comment);
                    break;
                case NodeType.DocumentFragment:
                    nsIDOMDocumentFragment fragment = Xpcom.QueryInterface<nsIDOMDocumentFragment>(domObject);
                    if (fragment != null) return DOM.DocumentFragment.CreateDocumentFragmentWrapper(window, fragment);
                    break;
            }
            // if we don't handle this type - just create GeckoNode
            return new GeckoNode(window, domObject);
        }

        internal static GeckoHtmlElement CreateDomHtmlElementWrapper(nsISupports window, /* /* nsIDOMHTMLElement*/nsISupports instance)
        {
            var lowerTagName = new WebIDL.Element((mozIDOMWindowProxy)window, instance).TagName.ToLowerInvariant();
            GeckoClassDesc desc;

            if (_dictionary.TryGetValue(lowerTagName, out desc))
            {
                object HTMLElement = Xpcom.QueryInterface(instance, desc.InterfaceType.GUID);
                if (HTMLElement != null)
                {
                    GeckoHtmlElement e = desc.CreationMethod(window, HTMLElement);
                    return e;
                }
            }
            return null;
        }
    }
}