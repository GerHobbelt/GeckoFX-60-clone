using System;
using System.Collections.Generic;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a collection of GeckoNode's
    /// </summary>
    internal class GeckoNodeEnumerable : IEnumerable<GeckoNode>
    {
        private readonly nsISupports _window;
        private readonly WebIDL.XPathResult _xpathResult;

        internal GeckoNodeEnumerable(nsISupports window, WebIDL.XPathResult xpathResult)
        {
            _window = window;
            _xpathResult = xpathResult;
        }

        #region IEnumerable<GeckoNode> Members

        public IEnumerator<GeckoNode> GetEnumerator()
        {
            var xpathResult = new XPathResult((mozIDOMWindowProxy) _window, (nsISupports)_xpathResult.Object);
            while (!xpathResult.InvalidIteratorState)
            {
                var result = xpathResult.IterateNext().Wrap(_window, GeckoNode.Create);
                if (result == null)
                    yield break;
                yield return result;
            }
        }

#endregion

#region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var i = GetEnumerator();
            while (i.MoveNext())
            {
                yield return i.Current;
            }
        }

#endregion
    }
}