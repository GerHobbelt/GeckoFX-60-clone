using System;
using System.Collections.Generic;
using Gecko.Collections;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a collection of <see cref="GeckoHtmlElement"/> objects.
    /// </summary>
    public class GeckoNodeCollection
        : IGeckoArray<GeckoNode>, IEnumerable<GeckoNode>
    {
        private Lazy<NodeList> _nodeList;

        protected GeckoNodeCollection(nsISupports window, nsIDOMNodeList list)
        {
            _window = window;
            _nodeList = new Lazy<NodeList>(() => new NodeList((mozIDOMWindowProxy) window, (nsISupports) list));
            this.List = list;
        }

        private readonly nsISupports _window;
        private nsIDOMNodeList List;

        public virtual uint Length => List.GetLengthAttribute();

        public virtual GeckoNode this[uint index]
        {
            get
            {
                if (index >= Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return GeckoNode.Create(_window, (nsIDOMNode)_nodeList.Value.Item(index));
            }
        }

#region IEnumerable<GeckoNode> Members

        public virtual IEnumerator<GeckoNode> GetEnumerator()
        {
            uint length = Length;
            for (uint i = 0; i < length; i++)
            {
                yield return GeckoNode.Create(_window, (nsIDOMNode)_nodeList.Value.Item(i));
            }
        }

#endregion

#region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (GeckoNode element in this)
                yield return element;
        }

#endregion

        internal static GeckoNodeCollection Create(nsISupports window, nsISupports list)
        {
            return list == null ? null : new GeckoNodeCollection(window, (nsIDOMNodeList)list);
        }
    }
}