using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Collections;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko.DOM
{
    public class GeckoNamedNodeMap
        : IGeckoArray<GeckoNode>, IEnumerable<GeckoNode>
    {
        private readonly mozIDOMWindowProxy _window;
        private readonly Lazy<WebIDL.NamedNodeMap> _namedNodeMap;

        public GeckoNamedNodeMap(mozIDOMWindowProxy window, /* nsIDOMMozNamedAttrMap */nsISupports map)
        {
            _window = window;
            _namedNodeMap = new Lazy<NamedNodeMap>(() => new WebIDL.NamedNodeMap(_window, map));
        }


        /// <summary>
        /// Gets the number of items in the map.
        /// </summary>
        public uint Length => _namedNodeMap.Value.Length;

        public GeckoNode this[uint index]
        {
            get
            {
                if (index >= Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                //return _map.Instance.Item((uint) index).Wrap(GeckoNode.Create);
                throw new NotImplementedException();
            }
        }

        public GeckoNode this[string name] => ((nsIDOMNode)_namedNodeMap.Value.GetNamedItem(name)).Wrap(_window, GeckoNode.Create);

        public GeckoNode this[string namespaceUri, string localName]
        {
            get { /*return nsString.Pass(_map.Instance.GetNamedItemNS, namespaceUri, localName).Wrap(GeckoNode.Create);*/  throw new NotImplementedException(); }
        }

        public GeckoNode RemoveNamedItem(string name)
        {
            //return nsString.Pass(_map.Instance.RemoveNamedItem, name)
            //    .Wrap(GeckoNode.Create);
            throw new NotImplementedException();
        }

        #region IEnumerable<GeckoNode> Members

        public IEnumerator<GeckoNode> GetEnumerator()
        {
            uint length = Length;
            for (uint i = 0; i < length; i++)
            {
                yield return GeckoNode.Create(_window, (nsIDOMNode)_namedNodeMap.Value.Item(i));
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
