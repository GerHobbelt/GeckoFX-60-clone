using System;
using System.Runtime.InteropServices;
using Gecko.DOM;
using Gecko.DOM.Svg;
using Gecko.Interop;
using Gecko.WebIDL;
using DocumentFragment = Gecko.DOM.DocumentFragment;
using Location = Gecko.DOM.Location;

namespace Gecko
{
    /// <summary>
    /// Base document class (documents can be HTML,SVG,XUL)
    /// </summary>
    public class GeckoDomDocument
        : GeckoNode
    {
        internal nsIDOMDocument _domDocument;
        private Lazy<Document> _document;
        private Lazy<DocumentOrShadowRoot> _documentOrShadowRoot;

        internal GeckoDomDocument(mozIDOMWindowProxy window, nsIDOMDocument document)
            : base(window, document)
        {
            _domDocument = document;
            _document = new Lazy<Document>(() => new WebIDL.Document((mozIDOMWindowProxy)window, (nsISupports)document));
            _documentOrShadowRoot = new Lazy<DocumentOrShadowRoot>(() => new WebIDL.DocumentOrShadowRoot((mozIDOMWindowProxy)window, (nsISupports)document));
        }

        /// <summary>
        /// for tests
        /// </summary>
        public nsIDOMDocument NativeDomDocument => _domDocument;

        public DOM.DomDocumentType Doctype
        {
            get
            {
                return ((nsIDOMDocumentType) Doc.Value.Doctype).Wrap(Window, DomDocumentType.Create);                
            }
        }

        /// <summary>
        /// Gets the top-level document element (for HTML documents, this is the html tag).
        /// </summary>
        public GeckoElement DocumentElement => Doc.Value.DocumentElement.Wrap(Window, GeckoElement.CreateDomElementWrapper);

        public GeckoHtmlElement CreateHtmlElement(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                throw new ArgumentException("tagName");

            return GeckoHtmlElement.Create(Window, Doc.Value.CreateElement(tagName));
        }

        public GeckoElement CreateElement(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                throw new ArgumentException("tagName");

            return GeckoElement.CreateDomElementWrapper(Window, Doc.Value.CreateElement(tagName));
        }

        public DocumentFragment CreateDocumentFragment()
        {
            return ((nsIDOMDocumentFragment)Doc.Value.CreateDocumentFragment()).Wrap(Window, DocumentFragment.CreateDocumentFragmentWrapper);
        }

        public GeckoTextNode CreateTextNode(string data)
        {
            return Doc.Value.CreateTextNode(data).Wrap(Window, GeckoTextNode.CreateTextNodeWrapper);           
        }

        public GeckoComment CreateComment(string data)
        {
            return ((nsIDOMComment)Doc.Value.CreateComment(data)).Wrap(Window, GeckoComment.CreateCommentWrapper);
        }

        public GeckoAttribute CreateAttribute(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));

            return ((nsIDOMElement)Doc.Value.CreateAttribute(name)).Wrap(Window, GeckoAttribute.CreateAttributeWrapper);
        }

        /// <summary>
        /// Returns a collection containing all elements in the document with a given tag name.
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByTagName(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                return null;

            return Doc.Value.GetElementsByTagName(tagName).Wrap(Window, (window, x) => new GeckoElementCollection(Window, (nsIDOMNodeList)x));
        }

        public GeckoNode ImportNode(GeckoNode node, bool deep)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            return Doc.Value.ImportNode(node.DomObject, deep).Wrap(Window, Create);           
        }

        public GeckoHtmlElement CreateElement(string namespaceUri, string qualifiedName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException(nameof(namespaceUri));
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentException(nameof(qualifiedName));

            return GeckoHtmlElement.Create(Window, Doc.Value.CreateElementNS(namespaceUri, qualifiedName));
        }

        public GeckoAttribute CreateAttribute(string namespaceUri, string qualifiedName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException(nameof(namespaceUri));
            if (string.IsNullOrEmpty(qualifiedName))
                throw new ArgumentException(nameof(qualifiedName));

            return ((nsIDOMElement) Doc.Value.CreateAttributeNS(namespaceUri, qualifiedName)).Wrap(Window,
                GeckoAttribute.CreateAttributeWrapper);
        }

        public DomEventArgs CreateEvent(string name)
        {
            var e = Doc.Value.CreateEvent(name);

            return e.Wrap(Window, (x,y) => DomEventArgs.Create(y));
        }

        /// <summary>
        /// Returns a collection containing all elements in the document with a given namespaceUri & localName.
        /// </summary>
        /// <returns></returns>
        public GeckoElementCollection GetElementsByTagNameNS(string namespaceUri, string localName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                throw new ArgumentException(nameof(namespaceUri));
            if (string.IsNullOrEmpty(localName))
                throw new ArgumentException(nameof(localName));

            return new GeckoElementCollection(Window,
                (nsIDOMNodeList) Doc.Value.GetElementsByTagNameNS(namespaceUri, localName));
        }


        /// <summary>
        /// Searches for and returns the element in the document with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Found element or null if element does not exist</returns>
        public GeckoElement GetElementById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            return (GeckoElement)new WebIDL.Document((mozIDOMWindowProxy)Window, (nsISupports)_domDocument).GetElementById(id).Wrap(Window, Create);
        }

        /// <summary>
        /// Searches for and returns the Html element in the document with the given id.
        /// Will throw an invalid cast exception is element is not a HtmlElement.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeckoHtmlElement GetHtmlElementById(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            return (GeckoHtmlElement)new WebIDL.Document((mozIDOMWindowProxy)Window, (nsISupports)_domDocument).GetElementById(id).Wrap(Window, Create);
        }

        public string InputEncoding => Doc.Value.InputEncoding;

        public string Uri => Doc.Value.URL;

        /// <summary>
        /// <see cref="http://html5.org/specs/dom-range.html#dom-document-createrange"/>
        /// </summary>
        /// <returns></returns>
        public GeckoRange CreateRange()
        {
            return new GeckoRange(Window, (nsIDOMRange)Doc.Value.CreateRange()); 
        }

        /// <summary>
        /// The window associated with this document.
        /// <see cref="http://www.whatwg.org/html/#dom-document-defaultview"/>
        /// </summary>
        public GeckoWindow DefaultView => Doc.Value.DefaultView.Wrap(Window, (window, x) => new GeckoWindow(window, x));

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-characterset"/>
        /// </summary>
        public string CharacterSet => Doc.Value.CharacterSet;

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-dir"/>
        /// </summary>
        public string Dir
        {
            get { return Doc.Value.Dir; }
            set { Doc.Value.Dir = value; }
        }


        /// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-location>
        /// </summary>
        public Location Location => Doc.Value.Location.Wrap(Window, Location.Create);

        /// <summary>
        /// Gets the document title.
        /// </summary>
        public string Title
        {
            get { return Doc.Value.Title; }
            set { Doc.Value.Title = value; }
        }

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-readystate"/>
        /// </summary>
        public string ReadyState => Doc.Value.ReadyState;

        public string Referrer => Doc.Value.Referrer;

        /// <summary>
        /// <see cref="http://www.whatwg.org/html/#dom-document-hasfocus"/>
        /// </summary>
        public bool HasFocus()
        {
            return Doc.Value.HasFocus();            
        }

        /// <summary>
        /// Gets the currently focused element.
        /// </summary>
        public GeckoHtmlElement ActiveElement => (GeckoHtmlElement) DocumentOrShadowRoot.Value.ActiveElement.Wrap(Window, Create);

        /// <summary>
        /// Returns a set of elements with the given class name. When called on the document object, the complete document is searched, including the root node.
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public GeckoNodeCollection GetElementsByClassName(string classes)
        {
            var list = (nsIDOMNodeList)Doc.Value.GetElementsByClassName(classes);
            return GeckoNodeCollection.Create(Window, (nsISupports)list);
        }

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-preferredStyleSheetSet"/>
        /// </summary>
        public string PreferredStyleSheetSet => Doc.Value.PreferredStyleSheetSet;

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet"/>
        /// </summary>
        public string SelectedStyleSheetSet
        {
            get { return Doc.Value.SelectedStyleSheetSet; }
            set { Doc.Value.SelectedStyleSheetSet = value; }
        }

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-lastStyleSheetSet"/>
        /// </summary>
        public string LastStyleSheetSet => Doc.Value.LastStyleSheetSet;

        /// <summary>
        /// <see cref="http://dev.w3.org/csswg/cssom/#dom-document-enableStyleSheetsForSet"/>
        /// </summary>
        /// <param name="name"></param>
        public void EnableStyleSheetsForSet(string name)
        {
            Doc.Value.EnableStyleSheetsForSet(name);            
        }

        /// <summary>
        /// Returns the element visible at the given point, relative to the upper-left-most visible point in the document.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public GeckoElement ElementFromPoint(int x, int y)
        {
            return DocumentOrShadowRoot.Value.ElementFromPoint(x, y).Wrap(Window, GeckoElement.CreateDomElementWrapper);            
        }

        public string ContentType => Doc.Value.ContentType;

        /// <summary>
        /// True if this document is synthetic : stand alone image, video, audio file,
        /// etc.
        /// </summary>
        public bool MozSyntheticDocument => Doc.Value.MozSyntheticDocument;

        ///// <summary>
        ///// Returns the script element whose script is currently being processed.
        /////
        ///// @see <https://developer.mozilla.org/en/DOM/document.currentScript>
        ///// </summary>
        public GeckoNode CurrentScript => Doc.Value.CurrentScript.Wrap(Window, Create);
        
        /// <summary>
        /// <see cref="https://developer.mozilla.org/en/DOM/document.releaseCapture"/>
        /// </summary>
        public void ReleaseCapture()
        {
            Doc.Value.ReleaseCapture();            
        }

        /// <summary>
        /// Causes the document to leave DOM full-screen mode, if it's in
        /// full-screen mode, as per the DOM full-screen api.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public void MozCancelFullScreen()
        {
            Doc.Value.MozCancelFullScreen();            
        }

        /// <summary>
        /// Denotes whether this document is in DOM full-screen mode, as per the DOM
        /// full-screen api.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public bool MozFullScreen => Doc.Value.MozFullScreen;

        /// <summary>
        /// Denotes whether the full-screen-api.enabled is true, no windowed
        /// plugins are present, and all ancestor documents have the
        /// mozallowfullscreen attribute set.
        /// <see cref="https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI"/>
        /// </summary>
        public bool MozFullScreenEnabled => Doc.Value.MozFullScreenEnabled;

        protected internal Lazy<Document> Doc => _document;

        protected internal Lazy<DocumentOrShadowRoot> DocumentOrShadowRoot => _documentOrShadowRoot;

        public static GeckoDomDocument CreateDomDocumentWraper(mozIDOMWindowProxy window, nsIDOMDocument domDocument)
        {
            // REVIEW: PORTFF60 - should we cache this?
            return new GeckoDocument(window, domDocument);
        }
    }
}
