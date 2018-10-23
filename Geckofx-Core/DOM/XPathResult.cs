using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM
{
    public class XPathResult
    {
        private readonly mozIDOMWindowProxy _proxy;
        private ComPtr<nsIXPathResult> _xpathResult = null;

        internal XPathResult(mozIDOMWindowProxy proxy, nsIXPathResult xpathResult)
        {
            _proxy = proxy;
            _xpathResult = new ComPtr<nsIXPathResult>(xpathResult);
        }

        public XPathResultType GetResultType()
        {
            using (var context = new AutoJSContext(_proxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance))
            {                
                return
                    (XPathResultType)
                        SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject.JSObject, "resultType").ToInteger();
            }
        }

        public double GetNumberValue()
        {
            using (var context = new AutoJSContext(_proxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance))
            {                
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject.JSObject, "numberValue").ToDouble();
            }
        }

        public string GetStringValue()
        {
            using (var context = new AutoJSContext(_proxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance))
            {                
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject.JSObject, "stringValue").ToString();
            }
        }

        public bool GetBooleanValue()
        {
            using (var context = new AutoJSContext(_proxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)_xpathResult.Instance))
            {                
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject.JSObject, "booleanValue").ToBoolean();
            }
        }

        public GeckoNode GetSingleNodeValue()
        {
            return new WebIDL.XPathResult(_proxy, _xpathResult.Instance as nsISupports).IterateNext().Wrap(_proxy, GeckoNode.Create);
        }

        public IEnumerable<GeckoNode> GetNodes()
        {
            // TODO: fixme this should return a new copy of the results.
            return new GeckoNodeEnumerable(_proxy, new WebIDL.XPathResult(_proxy, _xpathResult.Instance as nsISupports));
        }
    }


    /// <summary>
    /// Regrettable, since the upgrade from geckofx45 -> geckofx60, the generated values for this enum are not longer avaliable.
    /// </summary>
    public enum XPathResultType
        : ushort
    {
        Any = 0,
        Number = 1,
        String = 2,
        Boolean = 3,
        UnorderedNodeIterator = 4,
        OrderedNodeIterator = 5,
        UnorderedNodeSnapshot = 6,
        OrderedNodeSnapshot = 7,
        AnyUnorderedNode = 8,
        FirstOrderedNode = 9,
    }
}