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

            public delegate GeckoHtmlElement ObjectCreator(object htmlElementInterface);
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
                CreationMethod = (x) => new GeckoAnchorElement((/* nsIDOMHTMLAnchorElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "applet",
                InterfaceType = typeof (/* nsIDOMHTMLAppletElement */ nsISupports),
                GeckoElement = typeof (GeckoAppletElement),
                CreationMethod = (x) => new GeckoAppletElement((/* nsIDOMHTMLAppletElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "area",
                InterfaceType = typeof (/* nsIDOMHTMLAreaElement */ nsISupports),
                GeckoElement = typeof (GeckoAreaElement),
                CreationMethod = (x) => new GeckoAreaElement((/* nsIDOMHTMLAreaElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "base",
                InterfaceType = typeof (/* nsIDOMHTMLBaseElement */ nsISupports),
                GeckoElement = typeof (GeckoBaseElement),
                CreationMethod = (x) => new GeckoBaseElement((/* nsIDOMHTMLBaseElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "body",
                InterfaceType = typeof (/* nsIDOMHTMLBodyElement */ nsISupports),
                GeckoElement = typeof (GeckoBodyElement),
                CreationMethod = (x) => new GeckoBodyElement((/* nsIDOMHTMLBodyElement */ nsISupports) x)
            });
#if NO_LONGER_EXISTS_GECKO45
			Add(new GeckoClassDesc() { TagName = "br", InterfaceType = typeof(nsIDOMHTMLBRElement), GeckoElement = typeof(GeckoBRElement), 
				CreationMethod = (x) => new GeckoBRElement((nsIDOMHTMLBRElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "button",
                InterfaceType = typeof (/* nsIDOMHTMLButtonElement */ nsISupports),
                GeckoElement = typeof (GeckoButtonElement),
                CreationMethod = (x) => new GeckoButtonElement((/* nsIDOMHTMLButtonElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "canvas",
                InterfaceType = typeof (/* nsIDOMHTMLCanvasElement */ nsISupports),
                GeckoElement = typeof (GeckoCanvasElement),
                CreationMethod = (x) => new GeckoCanvasElement((/* nsIDOMHTMLCanvasElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "dir",
                InterfaceType = typeof (/* nsIDOMHTMLDirectoryElement */ nsISupports),
                GeckoElement = typeof (GeckoDirectoryElement),
                CreationMethod = (x) => new GeckoDirectoryElement((/* nsIDOMHTMLDirectoryElement */ nsISupports) x)
            });
#if NO_LONGER_EXISTS_GECKO45
			Add(new GeckoClassDesc() { TagName = "div", InterfaceType = typeof(nsIDOMHTMLDivElement), GeckoElement = typeof(GeckoDivElement), 
				CreationMethod = (x) => new GeckoDivElement((nsIDOMHTMLDivElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "embed",
                InterfaceType = typeof (/* nsIDOMHTMLEmbedElement */ nsISupports),
                GeckoElement = typeof (GeckoEmbedElement),
                CreationMethod = (x) => new GeckoEmbedElement((/* nsIDOMHTMLEmbedElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "fieldset",
                InterfaceType = typeof (/* nsIDOMHTMLFieldSetElement */ nsISupports),
                GeckoElement = typeof (GeckoFieldSetElement),
                CreationMethod = (x) => new GeckoFieldSetElement((/* nsIDOMHTMLFieldSetElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "form",
                InterfaceType = typeof (nsIDOMHTMLFormElement),
                GeckoElement = typeof (GeckoFormElement),
                CreationMethod = (x) => new GeckoFormElement((nsIDOMHTMLFormElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "frame",
                InterfaceType = typeof (/* nsIDOMHTMLFrameElement */ nsISupports),
                GeckoElement = typeof (GeckoFrameElement),
                CreationMethod = (x) => new GeckoFrameElement((/* nsIDOMHTMLFrameElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "frameset",
                InterfaceType = typeof (/* nsIDOMHTMLFrameSetElement */ nsISupports),
                GeckoElement = typeof (GeckoFrameSetElement),
                CreationMethod = (x) => new GeckoFrameSetElement((/* nsIDOMHTMLFrameSetElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "head",
                InterfaceType = typeof (/* nsIDOMHTMLHeadElement */ nsISupports),
                GeckoElement = typeof (GeckoHeadElement),
                CreationMethod = (x) => new GeckoHeadElement((/* nsIDOMHTMLHeadElement */ nsISupports) x)
            });
#if NO_LONGER_EXISTS_GECKO45
			Add(new GeckoClassDesc() { TagName = "h1", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
			Add(new GeckoClassDesc() { TagName = "h2", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
			Add(new GeckoClassDesc() { TagName = "h3", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
			Add(new GeckoClassDesc() { TagName = "h4", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
			Add(new GeckoClassDesc() { TagName = "h5", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
			Add(new GeckoClassDesc() { TagName = "h6", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement), 
				CreationMethod = (x) => new GeckoHeadingElement((nsIDOMHTMLHeadingElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "hr",
                InterfaceType = typeof (/* nsIDOMHTMLHRElement */ nsISupports),
                GeckoElement = typeof (GeckoHRElement),
                CreationMethod = (x) => new GeckoHRElement((/* nsIDOMHTMLHRElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "html",
                InterfaceType = typeof (/* nsIDOMHTMLHtmlElement */ nsISupports),
                GeckoElement = typeof (GeckoHtmlHtmlElement),
                CreationMethod = (x) => new GeckoHtmlHtmlElement((/* nsIDOMHTMLHtmlElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "iframe",
                InterfaceType = typeof (/* nsIDOMHTMLIFrameElement */ nsISupports),
                GeckoElement = typeof (GeckoIFrameElement),
                CreationMethod = (x) => new GeckoIFrameElement((/* nsIDOMHTMLIFrameElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "img",
                InterfaceType = typeof (/* nsIDOMHTMLImageElement */ nsISupports),
                GeckoElement = typeof (GeckoImageElement),
                CreationMethod = (x) => new GeckoImageElement((/* nsIDOMHTMLImageElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "input",
                InterfaceType = typeof (nsIDOMHTMLInputElement),
                GeckoElement = typeof (GeckoInputElement),
                CreationMethod = (x) => new GeckoInputElement((nsIDOMHTMLInputElement) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "label",
                InterfaceType = typeof (/* nsIDOMHTMLLabelElement */ nsISupports),
                GeckoElement = typeof (GeckoLabelElement),
                CreationMethod = (x) => new GeckoLabelElement((/* nsIDOMHTMLLabelElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "li",
                InterfaceType = typeof (/* nsIDOMHTMLLIElement */ nsISupports),
                GeckoElement = typeof (GeckoLIElement),
                CreationMethod = (x) => new GeckoLIElement((/* nsIDOMHTMLLIElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "link",
                InterfaceType = typeof (/* nsIDOMHTMLLinkElement */ nsISupports),
                GeckoElement = typeof (GeckoLinkElement),
                CreationMethod = (x) => new GeckoLinkElement((/* nsIDOMHTMLLinkElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "map",
                InterfaceType = typeof (/* nsIDOMHTMLMapElement */ nsISupports),
                GeckoElement = typeof (GeckoMapElement),
                CreationMethod = (x) => new GeckoMapElement((/* nsIDOMHTMLMapElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "menu",
                InterfaceType = typeof (/* nsIDOMHTMLMenuElement */ nsISupports),
                GeckoElement = typeof (GeckoMenuElement),
                CreationMethod = (x) => new GeckoMenuElement((/* nsIDOMHTMLMenuElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "meta",
                InterfaceType = typeof (/* nsIDOMHTMLMetaElement */ nsISupports),
                GeckoElement = typeof (GeckoMetaElement),
                CreationMethod = (x) => new GeckoMetaElement((/* nsIDOMHTMLMetaElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "object",
                InterfaceType = typeof (/* nsIDOMHTMLObjectElement */ nsISupports),
                GeckoElement = typeof (GeckoObjectElement),
                CreationMethod = (x) => new GeckoObjectElement((/* nsIDOMHTMLObjectElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "ol",
                InterfaceType = typeof (/* /* nsIDOMHTMLOListElement*/ nsISupports),
                GeckoElement = typeof (GeckoOListElement),
                CreationMethod = (x) => new GeckoOListElement((/* /* nsIDOMHTMLOListElement*/ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "optgroup",
                InterfaceType = typeof (/* nsIDOMHTMLOptGroupElement*/ nsISupports),
                GeckoElement = typeof (GeckoOptGroupElement),
                CreationMethod = (x) => new GeckoOptGroupElement((/* nsIDOMHTMLOptGroupElement*/ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "option",
                InterfaceType = typeof (/* nsIDOMHTMLOptionElement */ nsISupports),
                GeckoElement = typeof (GeckoOptionElement),
                CreationMethod = (x) => new GeckoOptionElement((/* nsIDOMHTMLOptionElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "p",
                InterfaceType = typeof (/* nsIDOMHTMLParagraphElement */ nsISupports),
                GeckoElement = typeof (GeckoParagraphElement),
                CreationMethod = (x) => new GeckoParagraphElement((/* nsIDOMHTMLParagraphElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "pre",
                InterfaceType = typeof (/* nsIDOMHTMLPreElement */ nsISupports),
                GeckoElement = typeof (GeckoPreElement),
                CreationMethod = (x) => new GeckoPreElement((/* nsIDOMHTMLPreElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "q",
                InterfaceType = typeof (/* nsIDOMHTMLQuoteElement */ nsISupports),
                GeckoElement = typeof (GeckoQuoteElement),
                CreationMethod = (x) => new GeckoQuoteElement((/* nsIDOMHTMLQuoteElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "script",
                InterfaceType = typeof (/* nsIDOMHTMLScriptElement */ nsISupports),
                GeckoElement = typeof (GeckoScriptElement),
                CreationMethod = (x) => new GeckoScriptElement((/* nsIDOMHTMLScriptElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "select",
                InterfaceType = typeof (/* nsIDOMHTMLSelectElement */ nsISupports),
                GeckoElement = typeof (GeckoSelectElement),
                CreationMethod = (x) => new GeckoSelectElement((/* nsIDOMHTMLSelectElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "style",
                InterfaceType = typeof (/* nsIDOMHTMLStyleElement */ nsISupports),
                GeckoElement = typeof (GeckoStyleElement),
                CreationMethod = (x) => new GeckoStyleElement((/* nsIDOMHTMLStyleElement */ nsISupports) x)
            });
#if NONO_LONGER_EXISTS_IN_GECKO45
			Add(new GeckoClassDesc() { TagName = "caption", InterfaceType = typeof(nsIDOMHTMLTableCaptionElement), GeckoElement = typeof(GeckoTableCaptionElement),
				CreationMethod = (x) => new GeckoTableCaptionElement((nsIDOMHTMLTableCaptionElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "td",
                InterfaceType = typeof (/* nsIDOMHTMLTableCellElement */ nsISupports),
                GeckoElement = typeof (GeckoTableCellElement),
                CreationMethod = (x) => new GeckoTableCellElement((/* nsIDOMHTMLTableCellElement */ nsISupports) x)
            });
            Add(new GeckoClassDesc()
            {
                TagName = "textarea",
                InterfaceType = typeof (/* nsIDOMHTMLTextAreaElement */ nsISupports),
                GeckoElement = typeof (GeckoTextAreaElement),
                CreationMethod = (x) => new GeckoTextAreaElement((/* nsIDOMHTMLTextAreaElement */ nsISupports) x)
            });
#if NO_LONGER_EXISTS_IN_GECKO45
			Add(new GeckoClassDesc() { TagName = "title", InterfaceType = typeof(nsIDOMHTMLTitleElement), GeckoElement = typeof(GeckoTitleElement), 
				CreationMethod = (x) => new GeckoTitleElement((nsIDOMHTMLTitleElement)x) });
#endif
            Add(new GeckoClassDesc()
            {
                TagName = "ul",
                InterfaceType = typeof (/* nsIDOMHTMLUListElement */ nsISupports),
                GeckoElement = typeof (GeckoUListElement),
                CreationMethod = (x) => new GeckoUListElement((/* nsIDOMHTMLUListElement */ nsISupports) x)
            });
        }

        private static GeckoWrapperCache</* /* nsIDOMHTMLElement */nsISupports, GeckoHtmlElement> m_cache =
            new GeckoWrapperCache</* /* nsIDOMHTMLElement*/nsISupports, GeckoHtmlElement>(CreateDomHtmlElementWrapper);

        internal static GeckoHtmlElement GetClassFor(/* /* nsIDOMHTMLElement*/nsISupports element)
        {
            GeckoHtmlElement ret = GetClassFor<GeckoHtmlElement>(element);
            if (ret == null)
                ret = new GeckoHtmlElement(element);
            return ret;
        }

        internal static T GetClassFor<T>(/* /* nsIDOMHTMLElement*/nsISupports element) where T : GeckoHtmlElement
        {
            return (T) m_cache.Get(element);
        }

        /// <summary>
        /// Creates wrapper for nsIDOMNode object	
        /// </summary>
        /// <param name="domObject"></param>
        /// <returns></returns>
        internal static GeckoNode CreateDomNodeWrapper(nsIDOMNode domObject)
        {
            // if null -> return null
            if (domObject == null) return null;
#if PORTFF60
            var nodeType = (NodeType) domObject.GetNodeTypeAttribute();
            // by nodeType we can find proper wrapper faster, than perform QueryInterface
            switch (nodeType)
            {
                case NodeType.Element:
                    /* /* nsIDOMHTMLElement*/nsISupports htmlElement = Xpcom.QueryInterface</* /* nsIDOMHTMLElement*/nsISupports>(domObject);
                    if (htmlElement != null) return GeckoHtmlElement.Create(htmlElement);
                    nsIDOMElement element = Xpcom.QueryInterface<nsIDOMElement>(domObject);
                    if (element != null) return GeckoElement.CreateDomElementWrapper(element);
                    break;
                case NodeType.Attribute:
                    nsIDOMAttr attr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
                    if (attr != null) return GeckoAttribute.CreateAttributeWrapper(attr);
                    break;
                case NodeType.Comment:
                    nsIDOMComment comment = Xpcom.QueryInterface<nsIDOMComment>(domObject);
                    if (comment != null) return GeckoComment.CreateCommentWrapper(comment);
                    break;
                case NodeType.DocumentFragment:
                    nsIDOMDocumentFragment fragment = Xpcom.QueryInterface<nsIDOMDocumentFragment>(domObject);
                    if (fragment != null) return DOM.DocumentFragment.CreateDocumentFragmentWrapper(fragment);
                    break;
            }
            // if we don't handle this type - just create GeckoNode
            return new GeckoNode(domObject);
#endif
            throw new NotImplementedException();
        }

        internal static GeckoHtmlElement CreateDomHtmlElementWrapper(/* /* nsIDOMHTMLElement*/nsISupports instance)
        {
#if PORTFF60
            var lowerTagName = nsString.Get(instance.GetTagNameAttribute).ToLowerInvariant();
            GeckoClassDesc desc;

            if (_dictionary.TryGetValue(lowerTagName, out desc))
            {
                object HTMLElement = Xpcom.QueryInterface(instance, desc.InterfaceType.GUID);
                if (HTMLElement != null)
                {
                    GeckoHtmlElement e = desc.CreationMethod(HTMLElement);
                    return e;
                }
            }
            return null;
#endif
            throw new NotImplementedException();
        }
    }
}