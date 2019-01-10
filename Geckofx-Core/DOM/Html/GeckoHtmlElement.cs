using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM HTML element.
    /// </summary>
    public class GeckoHtmlElement
        : GeckoElement
    {
        private /* nsIDOMHTMLElement */nsIDOMElement _domHtmlElement;

        protected Lazy<WebIDL.HTMLElement> _htmlElement;

        #region ctor

        internal GeckoHtmlElement(mozIDOMWindowProxy window, /* nsIDOMHTMLElement */nsIDOMElement element)
            : base(window, element)
        {
            _domHtmlElement = element;
            _htmlElement = new Lazy<HTMLElement>(() => new WebIDL.HTMLElement((mozIDOMWindowProxy)window, (nsISupports)element));
        }

        internal static GeckoHtmlElement Create(mozIDOMWindowProxy window, /* nsIDOMHTMLElement */nsIDOMElement element)
        {
            return (element == null) ? null : DOM.DOMSelector.GetClassFor(window, element);
        }

        internal static T Create<T>(mozIDOMWindowProxy window,/* nsIDOMHTMLElement */nsISupports element) where T : GeckoHtmlElement
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
        public GeckoStyle Style => _htmlElement.Value.Style.Wrap(Window, GeckoStyle.Create);

        /// <summary>
        /// Gets style of the GeckoElement. 
        /// </summary>
        public GeckoStyle ComputedStyle
        {
            get
            {
                /* nsIDOMCSSStyleDeclaration */ nsISupports style;
                using (var element = new ComPtr<nsIDOMElement>(Xpcom.QueryInterface<nsIDOMElement>(this.DomObject)))
                using (var defaultView = OwnerDocument.DefaultView)
                {
                    var window = new WebIDL.Window(defaultView.DomWindow,
                        defaultView.DomWindow);
                    style = window.GetComputedStyle(element.Instance);
                }
                return GeckoStyle.Create(Window, style);
            }
        }

        public string Dir
        {
            get { return _htmlElement.Value.Dir; }
            set { _htmlElement.Value.Dir = value; }
        }

        /// <summary>
        /// Gets the parent element of this one.
        /// </summary>
        public GeckoHtmlElement Parent => GeckoHtmlElement.Create(Window, _node.Value.ParentElement);


        /// <summary>
        /// Gets the value of the id attribute.
        /// </summary>
        public string Id
        {
            get { return _element.Value.Id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    this.RemoveAttribute("id");
                else
                    _element.Value.Id = value;
            }
        }

        /// <summary>
        /// Gets the value of the class attribute.
        /// </summary>
        public string ClassName
        {
            get { return _element.Value.ClassName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    this.RemoveAttribute("class");
                else
                    _element.Value.ClassName = value;
            }
        }

        public void Blur()
        {
            _htmlElement.Value.Blur();
        }

        public string AccessKey
        {
            get { return _htmlElement.Value.AccessKey; }
            set { _htmlElement.Value.AccessKey = value; }
        }

        public void Focus()
        {
            _htmlElement.Value.Focus();
        }

        public void Click()
        {
            _htmlElement.Value.Click();
        }

        public bool Draggable
        {
            get { return _htmlElement.Value.Draggable; }
            set { _htmlElement.Value.Draggable = value; }
        }

        /// <summary>
        /// Get the value of the ContentEditable Attribute
        /// </summary>
        public string ContentEditable
        {
            get { return _htmlElement.Value.ContentEditable;  }
            set { _htmlElement.Value.ContentEditable = value; }
        }

        public System.Drawing.Rectangle[] ClientRects
        {
            get
            {
                nsIDOMClientRectList domRects = (nsIDOMClientRectList)_element.Value.GetClientRects();
                uint count = domRects.GetLengthAttribute();
                Rectangle[] rects = new Rectangle[count];
                for (uint i = 0; i < count; i++)
                {
                    nsIDOMClientRect domRect = domRects.Item(i);
                    rects[i] = new Rectangle(
                        (int)Math.Round(domRect.GetLeftAttribute()),
                        (int)Math.Round(domRect.GetTopAttribute()),
                        (int)Math.Round(domRect.GetWidthAttribute()),
                        (int)Math.Round(domRect.GetHeightAttribute()));
                }
                return rects;
            }
        }

        public int OffsetLeft => _htmlElement.Value.OffsetLeft;

        public int OffsetTop => _htmlElement.Value.OffsetTop;

        public int OffsetWidth => _htmlElement.Value.OffsetWidth;

        public int OffsetHeight => _htmlElement.Value.OffsetHeight;


        public GeckoHtmlElement OffsetParent => GeckoHtmlElement.Create(Window, _htmlElement.Value.OffsetParent);

        public void ScrollIntoView(bool top)
        {            
            _element.Value.ScrollIntoView(new WebIDLUnion<bool, object>(top, null));
        }


        public bool Spellcheck
        {
            get { return _htmlElement.Value.Spellcheck; }
            set { _htmlElement.Value.Spellcheck = value; }
        }

        public string InnerHtml
        {
            get { return _element.Value.InnerHTML; }
            set { _element.Value.InnerHTML = value; }
        }

        public virtual string OuterHtml => _element.Value.OuterHTML;

        public int TabIndex
        {
            get { return _htmlElement.Value.TabIndex; }
            set { _htmlElement.Value.TabIndex = value; }
        }

        public void InsertAdjacentHTML(string position, string text)
        {
            _element.Value.InsertAdjacentHTML(position, text);
        }

        public void MozRequestFullScreen()
        {
            _element.Value.RequestFullscreen();
        }
    }
}