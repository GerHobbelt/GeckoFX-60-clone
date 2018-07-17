using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM HTML element.
    /// </summary>
    public class GeckoHtmlElement
        : GeckoElement
    {
        private /* nsIDOMHTMLElement */nsIDOMElement _domHtmlElement;

        //nsIDOMElement DomNSElement;

        #region ctor

        internal GeckoHtmlElement(nsISupports window, /* nsIDOMHTMLElement */nsIDOMElement element)
            : base(window, element)
        {
            _domHtmlElement = element;
            //this.DomNSElement = (nsIDOMElement)element;
        }

        internal GeckoHtmlElement(object element)
            : base(element)
        {
            throw new NotImplementedException("use other constructor");
            if (element is /* nsIDOMHTMLElement */nsIDOMElement)
                _domHtmlElement = (/* nsIDOMHTMLElement */nsIDOMElement) element;
            else
                throw new ArgumentException("element is not a nsIDOMElement ");
        }

        internal static GeckoHtmlElement Create(nsISupports window, /* nsIDOMHTMLElement */nsIDOMElement element)
        {
            return (element == null) ? null : DOM.DOMSelector.GetClassFor(window, element);
        }

        internal static T Create<T>(nsISupports window,/* nsIDOMHTMLElement */nsISupports element) where T : GeckoHtmlElement
        {
            return (element == null) ? null : DOM.DOMSelector.GetClassFor<T>(window, element);
        }

#endregion

        public /* nsIDOMHTMLElement */nsIDOMElement DOMHtmlElement
        {
            get { return _domHtmlElement; }
        }


        /// <summary>
        /// Gets the inline style of the GeckoElement. 
        /// </summary>
        public GeckoStyle Style
        {
            get
            {
                //var cssInlineStyle = Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject);
                //if (cssInlineStyle == null) return null;
                //var ret = cssInlineStyle.GetStyleAttribute().Wrap(GeckoStyle.Create);
                //Marshal.ReleaseComObject(cssInlineStyle);
                //return ret;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets style of the GeckoElement. 
        /// </summary>
        public GeckoStyle ComputedStyle
        {
            get
            {
                /* nsIDOMCSSStyleDeclaration */ nsISupports style;
                using (var element = new ComPtr<nsIDOMElement>(Xpcom.QueryInterface<nsIDOMElement>(this.DomObject)))
                {
                    var window = new WebIDL.Window(OwnerDocument.DefaultView.DomWindow,
                        (nsISupports) OwnerDocument.DefaultView.DomWindow);
                    style = window.GetComputedStyle(element.Instance);
                }
                return GeckoStyle.Create(style);
            }
        }

        /// <summary>
        /// Gets the parent element of this one.
        /// </summary>
        public GeckoHtmlElement Parent
        {
            get
            {
                // note: the parent node could also be the document
                //return
                //    GeckoHtmlElement.Create(
                //        Xpcom.QueryInterface</* nsIDOMHTMLElement */nsISupports>(_domHtmlElement.GetParentNodeAttribute()));
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Gets the value of the id attribute.
        /// </summary>
        public string Id
        {
            get {/* return nsString.Get(_domHtmlElement.GetIdAttribute);*/throw new NotImplementedException(); }
            set
            {
                //if (string.IsNullOrEmpty(value))
                //    this.RemoveAttribute("id");
                //else
                //    nsString.Set(_domHtmlElement.SetIdAttribute, value);
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the value of the class attribute.
        /// </summary>
        public string ClassName
        {
            get {/* return nsString.Get(_domHtmlElement.GetClassNameAttribute);*/throw new NotImplementedException(); }
            set
            {
                //if (string.IsNullOrEmpty(value))
                //    this.RemoveAttribute("class");
                //else
                //    nsString.Set(_domHtmlElement.SetClassNameAttribute, value);
                throw new NotImplementedException();
            }
        }

        public void Blur()
        {
            //_domHtmlElement.Blur();
            throw new NotImplementedException();
        }

        public string AccessKey
        {
            get { /*return nsString.Get(_domHtmlElement.GetAccessKeyAttribute);*/throw new NotImplementedException(); }
            set {/* _domHtmlElement.SetAccessKeyAttribute(new nsAString(value));*/throw new NotImplementedException(); }
        }

        public void Focus()
        {
            //_domHtmlElement.Focus();
            throw new NotImplementedException();
        }

        public void Click()
        {
            //_domHtmlElement.Click();
            throw new NotImplementedException();
        }

        public bool Draggable
        {
            get { /*return _domHtmlElement.GetDraggableAttribute();*/throw new NotImplementedException(); }
            set {/* _domHtmlElement.SetDraggableAttribute(value);*/throw new NotImplementedException(); }
        }

        /// <summary>
        /// Get the value of the ContentEditable Attribute
        /// </summary>
        public string ContentEditable
        {
            get { /*return nsString.Get(_domHtmlElement.GetContentEditableAttribute);*/throw new NotImplementedException(); }
            set {/* nsString.Set(_domHtmlElement.GetContentEditableAttribute, value);*/throw new NotImplementedException(); }
        }

        public System.Drawing.Rectangle[] ClientRects
        {
            get
            {
                //nsIDOMClientRectList domRects = DOMHtmlElement.GetClientRects();
                //uint count = domRects.GetLengthAttribute();
                //Rectangle[] rects = new Rectangle[count];
                //for (uint i = 0; i < count; i++)
                //{
                //    nsIDOMClientRect domRect = domRects.Item(i);
                //    rects[i] = new Rectangle(
                //        (int) Math.Round(domRect.GetLeftAttribute()),
                //        (int) Math.Round(domRect.GetTopAttribute()),
                //        (int) Math.Round(domRect.GetWidthAttribute()),
                //        (int) Math.Round(domRect.GetHeightAttribute()));
                //}
                //return rects;
                throw new NotImplementedException();
            }
        }

        public int OffsetLeft
        {
            get {/* return _domHtmlElement.GetOffsetLeftAttribute();*/throw new NotImplementedException(); }
        }

        public int OffsetTop
        {
            get { /*return _domHtmlElement.GetOffsetTopAttribute();*/throw new NotImplementedException(); }
        }

        public int OffsetWidth
        {
            get { /*return _domHtmlElement.GetOffsetWidthAttribute();*/throw new NotImplementedException(); }
        }

        public int OffsetHeight
        {
            get {/* return _domHtmlElement.GetOffsetHeightAttribute();*/throw new NotImplementedException(); }
        }


        public GeckoHtmlElement OffsetParent
        {
            get
            {
                //return GeckoHtmlElement.Create((/* nsIDOMHTMLElement */nsISupports) _domHtmlElement.GetOffsetParentAttribute());
                throw new NotImplementedException();
            }
        }

        public void ScrollIntoView(bool top)
        {
            //_domHtmlElement.ScrollIntoView(top, 1);
            throw new NotImplementedException();
        }


        public bool Spellcheck
        {
            get { /*return _domHtmlElement.GetSpellcheckAttribute();*/throw new NotImplementedException(); }
            set { /*_domHtmlElement.SetSpellcheckAttribute(value);*/throw new NotImplementedException(); }
        }

        public string InnerHtml
        {
            get { /*return nsString.Get(_domHtmlElement.GetInnerHTMLAttribute);*/throw new NotImplementedException(); }
            set {/* nsString.Set(_domHtmlElement.SetInnerHTMLAttribute, value);*/throw new NotImplementedException(); }
        }

        public virtual string OuterHtml
        {
            get { /*return nsString.Get(_domHtmlElement.GetOuterHTMLAttribute); */throw new NotImplementedException(); }
        }

        public int TabIndex
        {
            get { /*return _domHtmlElement.GetTabIndexAttribute();*/throw new NotImplementedException(); }
            set { /*_domHtmlElement.SetTabIndexAttribute(value);*/throw new NotImplementedException(); }
        }

        public void InsertAdjacentHTML(string position, string text)
        {
            using (nsAString tempPos = new nsAString(position), tempText = new nsAString(text))
            {
                //_domHtmlElement.InsertAdjacentHTML(tempPos, tempText);
                throw new NotImplementedException();
            }
        }

        public void MozRequestFullScreen()
        {
            //_domHtmlElement.MozRequestFullScreen();
            throw new NotImplementedException();
        }
    }
}