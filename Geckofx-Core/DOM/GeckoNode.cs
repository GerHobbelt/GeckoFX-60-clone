using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Gecko.DOM;
using Gecko.Interop;
using Gecko.WebIDL;
using XPathResult = Gecko.DOM.XPathResult;

namespace Gecko
{
    /// <summary>
    /// Provides a base class for DOM nodes.
    /// </summary>
    public class GeckoNode
        : IDisposable
    {
        private static GeckoWrapperCache<nsIDOMNode, GeckoNode> m_nodeCache =
            new GeckoWrapperCache<nsIDOMNode, GeckoNode>(DOMSelector.CreateDomNodeWrapper);

        #region fields

        private ComPtr<nsIDOMNode> _domNode;
        private readonly nsISupports _window;
        protected Lazy<WebIDL.Node> _node;

        public nsISupports Window => _window;

        #endregion

        #region ctor & creation methods

        internal GeckoNode(nsISupports window, nsIDOMNode domObject)
        {
            //ComDebug.WriteDebugInfo( domObject );
            _domNode = new ComPtr<nsIDOMNode>(domObject);
            _window = window;
            _node = new Lazy<Node>(() => new Node((mozIDOMWindowProxy)_window, (nsISupports) _domNode.Instance));
        }

        ~GeckoNode()
        {
            Xpcom.DisposeObject(ref _domNode);
        }

        public void Dispose()
        {
            Xpcom.DisposeObject(ref _domNode);
            GC.SuppressFinalize(this);
        }

        internal static GeckoNode Create(nsISupports window, nsIDOMNode domObject)
        {
            return m_nodeCache.Get(window, domObject);
        }

        internal static GeckoNode Create(nsISupports window, nsIDOMElement domObject)
        {
            return m_nodeCache.Get(window, domObject);
        }

        #endregion

        #region Properties for Native XPCOM objects access

        /// <summary>
        /// Gets the underlying XPCOM object.
        /// </summary>
        public nsIDOMNode DomObject
        {
            get { return _domNode.Instance; }
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is GeckoNode)
            {
                // compare native objects, NOT wrappers
                return this._domNode.GetHashCode() == ((GeckoNode) obj)._domNode.GetHashCode();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _domNode.GetHashCode();
        }

        /// <summary>
        /// Gets the text contents of the node.
        /// </summary>
        public string TextContent
        {
            get{ return _node.Value.TextContent; }
            set { _node.Value.TextContent = value; }
        }

        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public string NodeValue
        {
            get{ return _node.Value.NodeValue; }
            set { _node.Value.NodeValue = value; }
        }

        public string NodeName => _node.Value.NodeName;

        /// <summary>
        /// Gets a collection containing all child nodes of this node.
        /// </summary>
        public GeckoNodeCollection ChildNodes => _node.Value.ChildNodes.Wrap(_window, GeckoNodeCollection.Create);

        public GeckoNode FirstChild => _node.Value.FirstChild.Wrap(_window, Create);

        public GeckoNode LastChild => _node.Value.LastChild.Wrap(_window, Create);

        public GeckoNode NextSibling => _node.Value.NextSibling.Wrap(_window, Create);

        public GeckoNode PreviousSibling => _node.Value.PreviousSibling.Wrap(_window, Create);

        public bool HasChildNodes => _node.Value.HasChildNodes();

        public virtual GeckoDocument OwnerDocument => GeckoDocument.Create(_window, _node.Value.OwnerDocument);

        public GeckoNode AppendChild(GeckoNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            _node.Value.AppendChild(node._domNode.Instance);

            return node;
        }

        public GeckoNode CloneNode(bool deep)
        {
            return Create(_window, _node.Value.CloneNode(deep));
        }

        public GeckoNode InsertBefore(GeckoNode newChild, GeckoNode before)
        {
            if (newChild == null)
                throw new ArgumentNullException(nameof(newChild));
            if (before == null)
                throw new ArgumentNullException(nameof(before));

            _node.Value.InsertBefore(newChild._domNode.Instance, before._domNode.Instance);
            return newChild;
        }

        public GeckoNode RemoveChild(GeckoNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            _node.Value.RemoveChild(node._domNode.Instance);
            return node;
        }

        public GeckoNode ReplaceChild(GeckoNode newChild, GeckoNode oldChild)
        {
            if (newChild == null)
                throw new ArgumentNullException(nameof(newChild));
            if (oldChild == null)
                throw new ArgumentNullException(nameof(oldChild));

            _node.Value.ReplaceChild(newChild._domNode.Instance, oldChild._domNode.Instance);
            return newChild;
        }

        // TODO: FFPORT60 move NamespaceURI to GeckoElement
        public string NamespaceURI
        {
            get { /*return nsString.Get(_domNode.Instance.GetNamespaceURIAttribute);*/ throw new NotImplementedException(); }
        }

        // TODO: FFPORT60 move Prefix to GeckoElement
        public string Prefix
        {
            get { /*return nsString.Get(_domNode.Instance.GetPrefixAttribute);*/ throw new NotImplementedException(); }
        }

        // TODO: FFPORT60 move LocalName to GeckoElement
        public string LocalName
        {
            get { /*return nsString.Get(_domNode.Instance.GetLocalNameAttribute);*/ throw new NotImplementedException(); }
        }

        private NodeType m_cachedType;

        public NodeType NodeType
        {
            get
            {
                if (m_cachedType != 0)
                    return m_cachedType;

                return m_cachedType = (NodeType)_node.Value.NodeType;
            }
        }

        public GeckoNode ParentNode => _node.Value.ParentNode.Wrap(_window, Create);

        public GeckoElement ParentElement => _node.Value.ParentElement.Wrap(_window, GeckoElement.CreateDomElementWrapper);

        public int CompareDocumentPosition(GeckoNode other)
        {
            return _node.Value.CompareDocumentPosition(other.DomObject);
        }

        private nsIXPathResult EvaluateXPathInternal(string xpath)
        {
            var evaluator = new XPathEvaluator((mozIDOMWindowProxy)_window, (nsISupports)this.OwnerDocument.DomObject);
            return (nsIXPathResult)evaluator.Evaluate(xpath, DomObject, (nsISupports)evaluator.CreateNSResolver(DomObject), 0, null);
        }

        /// <summary>
        /// Evaluate xpath on this node.
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public XPathResult EvaluateXPath(string xpath)
        {
            var r = EvaluateXPathInternal(xpath);
            return new XPathResult((mozIDOMWindowProxy)_window, r);
        }


        /// <summary>
        /// Working similar to SelectSingle but not throwing exceptions on error (simply return first result)
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public GeckoNode SelectFirst(string xpath)
        {
            var r = EvaluateXPathInternal(xpath);

            nsIDOMNode singleNode = null;
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) r);

                // TODO: (Idenally I would generate these calls via a webidl-> C# compiler but for now just do it via manually written spidermonkey calls..)
                var resultType = SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "resultType").ToInteger();

#if PORTFF60
                switch (resultType)
                {
                    case nsIDOMXPathResultConsts.UNORDERED_NODE_ITERATOR_TYPE:
                        singleNode =
                            (nsIDOMNode)
                                SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "iterateNext",
                                    new JsVal[0]).ToComObject(context.ContextPointer);
                        break;
                    case nsIDOMXPathResultConsts.FIRST_ORDERED_NODE_TYPE:
                    case nsIDOMXPathResultConsts.ANY_UNORDERED_NODE_TYPE:
                        singleNode =
                            (nsIDOMNode)
                                SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "singleNodeValue")
                                    .ToComObject(context.ContextPointer);
                        break;
                }
#endif
                throw new NotImplementedException();
#if PORTFF60
                var ret = singleNode.Wrap(GeckoNode.Create);
                Xpcom.FreeComObject(ref r);
                return ret;
#endif
            }
        }

        public GeckoNode SelectSingle(string xpath)
        {
            var r = EvaluateXPathInternal(xpath);

            nsIDOMNode singleNode = null;
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) r);

                // TODO: (Idenally I would generate these calls via a webidl-> C# compiler but for now just do it via manually written spidermonkey calls..)
                var resultType = SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "resultType").ToInteger();

#if PORTFF60
                switch (resultType)
                {
                    case nsIDOMXPathResultConsts.UNORDERED_NODE_ITERATOR_TYPE:
                        singleNode =
                            (nsIDOMNode)
                                SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "iterateNext",
                                    new JsVal[0]).ToComObject(context.ContextPointer);
                        var test =
                            (SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "iterateNext",
                                new JsVal[0]));
                        if (!test.IsNull)
                        {
                            Xpcom.FreeComObject(ref singleNode);
                            Xpcom.FreeComObject(ref r);
                            throw new GeckoDomException("There are more than 1 nodes in Single selection");
                        }
                        break;
                    case nsIDOMXPathResultConsts.FIRST_ORDERED_NODE_TYPE:
                    case nsIDOMXPathResultConsts.ANY_UNORDERED_NODE_TYPE:
                        singleNode =
                            (nsIDOMNode)
                                SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "singleNodeValue")
                                    .ToComObject(context.ContextPointer);
                        break;
                }
#endif
                throw new NotImplementedException();
            }

            #if PORTFF60
            var ret = singleNode.Wrap(GeckoNode.Create);
            Xpcom.FreeComObject(ref r);
            return ret;
#endif
        }

        public DomEventTarget GetEventTarget()
        {
            var eventTarget = Xpcom.QueryInterface<nsIDOMEventTarget>(_domNode.Instance);

            return eventTarget.Wrap(_window, DomEventTarget.Create);
        }
    }
}
