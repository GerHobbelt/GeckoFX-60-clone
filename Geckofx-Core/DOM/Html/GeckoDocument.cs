using System;
using System.Collections.Generic;
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
        protected Lazy<WebIDL.HTMLDocument> _htmlDocument;

        internal GeckoDocument(nsISupports window,/* nsIDOMHTMLDocument */nsIDOMDocument document) : base(window, document)
        {
            this._domHtmlDocument = document;
            _htmlDocument = new Lazy<HTMLDocument>(() => new WebIDL.HTMLDocument((mozIDOMWindowProxy)Window, (nsISupports)_domHtmlDocument));
        }

        internal static GeckoDocument Create(nsISupports window, /* nsIDOMHTMLDocument */nsIDOMDocument document)
        {
            return (document == null) ? null : new GeckoDocument(window, document);
        }

        public override GeckoDocument OwnerDocument
        {
            get { return this; }
        }

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

                return (_domHtmlDocument == null)
                    ? null
                    : GeckoHtmlElement.Create<GeckoHtmlElement>(Window, new WebIDL.Document((mozIDOMWindowProxy)Window, (nsISupports)_domHtmlDocument).Body);
            }
        }

        /// <summary>
        /// Represents a collection of style sheets in a <see cref="GeckoDocument"/>.
        /// </summary>
        public class StyleSheetCollection : IEnumerable<GeckoStyleSheet>
        {
            private readonly nsISupports _window;
            private Lazy<StyleSheetList> _list;
            
            internal StyleSheetCollection(nsISupports window, GeckoDocument document)
            {
                _window = window;
                _list = new Lazy<StyleSheetList>(() => new StyleSheetList((mozIDOMWindowProxy)_window, document._documentOrShadowRoot.Value.StyleSheets));
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
                {
                    yield return GeckoStyleSheet.Create(_window, _list.Value.Item(i));
                }
                
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                foreach (GeckoStyleSheet element in this)
                    yield return element;
            }

#endregion
        }

        /// <summary>
        /// Gets the collection of style sheets in the <see cref="GeckoDocument"/>.
        /// </summary>
        public StyleSheetCollection StyleSheets
        {
            get { return (_StyleSheets == null) ? (_StyleSheets = new StyleSheetCollection(Window, this)) : _StyleSheets; }
        }

        private StyleSheetCollection _StyleSheets;

        /// <summary>
        /// Gets the URL of the document.
        /// </summary>
        public Uri Url
        {
            get { /*return (_domHtmlDocument == null) ? null : new Uri(nsString.Get(_domHtmlDocument.GetURLAttribute));*/throw new NotImplementedException(); }
        }

        public GeckoElementCollection Forms => new GeckoElementCollection(Window, (nsIDOMNodeList)_htmlDocument.Value.Forms);

        public GeckoElementCollection Images
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetImagesAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Anchors
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetAnchorsAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Applets
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetAppletsAttribute());
                throw new NotImplementedException();
            }
        }

        public GeckoElementCollection Links
        {
            get
            {
                //return (_domHtmlDocument == null)
                //    ? null
                //    : new GeckoHtmlElementCollection(_domHtmlDocument.GetLinksAttribute());
                throw new NotImplementedException();
            }
        }

        public string Cookie
        {
            get {/* return (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetCookieAttribute);*/throw new NotImplementedException(); }
            set { /*nsString.Set(_domHtmlDocument.SetCookieAttribute, value);*/throw new NotImplementedException(); }
        }

        public string Domain
        {
            get { /*return (_domHtmlDocument == null) ? null : nsString.Get(_domHtmlDocument.GetDomainAttribute);*/throw new NotImplementedException(); }
        }


        /// <summary>
        /// Returns a collection containing all elements in the document with a given name.		
        /// </summary>
        /// <param name="name">This is NOT the tagname but the name attribute.</param>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            return new GeckoElementCollection(Window, (nsIDOMNodeList)_document.Value.GetElementsByName(name));
        }
    }
}
