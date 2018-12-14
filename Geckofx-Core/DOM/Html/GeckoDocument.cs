using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM HTML document.
    /// </summary>
    public class GeckoDocument : GeckoDomDocument
    {
        private /* nsIDOMHTMLDocument */nsIDOMDocument _domHtmlDocument;
        protected Lazy<HTMLDocument> _htmlDocument;

        internal GeckoDocument(mozIDOMWindowProxy window,/* nsIDOMHTMLDocument */nsIDOMDocument document) : base(window, document)
        {
            _domHtmlDocument = document;
            _htmlDocument = new Lazy<HTMLDocument>(() => new HTMLDocument(Window, (nsISupports)_domHtmlDocument));
        }

        internal static GeckoDocument Create(mozIDOMWindowProxy window, /* nsIDOMHTMLDocument */nsIDOMDocument document)
        {
            return document == null ? null : new GeckoDocument(window, document);
        }

        public override GeckoDocument OwnerDocument => this;

        /// <summary>
        /// Gets the HTML head element.
        /// </summary>
        public GeckoHeadElement Head
        {
            get
            {
                return (_domHtmlDocument == null)
                    ? null
                    : GeckoHtmlElement.Create<GeckoHeadElement>(Window, _htmlDocument.Value.Head);
            }
        }

        /// <summary>
        /// Gets the HTML body element.
        /// </summary>
        public GeckoHtmlElement Body
        {
            get
            {
                try
                {
                    return (_domHtmlDocument == null)
                        ? null
                        : GeckoHtmlElement.Create<GeckoHtmlElement>(Window,
                            new Document((mozIDOMWindowProxy)Window, (nsISupports)_domHtmlDocument).Body);
                }
                catch (InvalidComObjectException e)
                {
                    // seen this when Window is casted to nsISupport.
                    // Not sure what causes this.
                    return null;
                }
                
            }
        }

        /// <summary>
        /// Represents a collection of style sheets in a <see cref="GeckoDocument"/>.
        /// </summary>
        public class StyleSheetCollection : IEnumerable<GeckoStyleSheet>
        {
            private readonly mozIDOMWindowProxy _window;
            private Lazy<StyleSheetList> _list;
            
            internal StyleSheetCollection(mozIDOMWindowProxy window, GeckoDocument document)
            {
                _window = window;
                _list = new Lazy<StyleSheetList>(() => new StyleSheetList((mozIDOMWindowProxy)_window, document.DocumentOrShadowRoot.Value.StyleSheets));
            }


            /// <summary>
            /// Gets the number of items in the collection.
            /// </summary>
            public uint Count => _list.Value.Length;

            /// <summary>
            /// Gets the item at the specified index in the collection.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public GeckoStyleSheet this[uint index]
            {
                get
                {
                    if (index >= Count)
                        throw new ArgumentOutOfRangeException(nameof(index));

                    return GeckoStyleSheet.Create(_window, _list.Value.Item(index));                    
                }
            }

#region IEnumerable<GeckoStyleSheet> Members

            /// <summary>
            /// Returns an <see cref="IEnumerator{GeckoStyleSheet}"/> which can enumerate through the collection.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<GeckoStyleSheet> GetEnumerator()
            {
                uint length = Count;
                for (uint i = 0; i < length; i++)
                    yield return GeckoStyleSheet.Create(_window, _list.Value.Item(i));   
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

#endregion
        }

        /// <summary>
        /// Gets the collection of style sheets in the <see cref="GeckoDocument"/>.
        /// </summary>
        public StyleSheetCollection StyleSheets => _styleSheets == null ? (_styleSheets = new StyleSheetCollection(Window, this)) : _styleSheets;

        private StyleSheetCollection _styleSheets;

        /// <summary>
        /// Gets the URL of the document.
        /// </summary>
        public Uri Url => new Uri(Doc.Value.URL);

        public GeckoElementCollection Forms => new GeckoElementCollection(Window, (nsIDOMNodeList)_htmlDocument.Value.Forms);

        public GeckoElementCollection Images => new GeckoHtmlElementCollection(Window, _htmlDocument.Value.Images);

        public GeckoElementCollection Anchors => new GeckoHtmlElementCollection(Window, _htmlDocument.Value.Anchors);

        public GeckoElementCollection Applets => new GeckoHtmlElementCollection(Window, _htmlDocument.Value.Applets);

        public GeckoElementCollection Links => new GeckoHtmlElementCollection(Window, _htmlDocument.Value.Links);

        public string Cookie
        {
            get { return _htmlDocument.Value.Cookie; }
            set { _htmlDocument.Value.Cookie = value; }
        }

        public string Domain => _htmlDocument.Value.Domain;


        /// <summary>
        /// Returns a collection containing all elements in the document with a given name.		
        /// </summary>
        /// <param name="name">This is NOT the tagname but the name attribute.</param>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            return new GeckoElementCollection(Window, (nsIDOMNodeList)Doc.Value.GetElementsByName(name));
        }
    }
}
