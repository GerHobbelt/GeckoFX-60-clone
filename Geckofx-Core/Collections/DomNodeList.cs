using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.Collections
{
    /// <summary>
    /// Generic wrapper for nsIDOMNodeList
    /// </summary>
    /// <typeparam name="TWrapper"></typeparam>
    /// <typeparam name="TGeckoNode"></typeparam>
    internal sealed class DomNodeList<TWrapper, TGeckoNode>
        : IGeckoArray<TWrapper>
        where TWrapper : GeckoNode
        where TGeckoNode : class, nsIDOMNode
    {
        private readonly nsISupports _window;
        private nsIDOMNodeList _list;
        private Func<nsISupports, TGeckoNode, TWrapper> _translator;

        internal DomNodeList(nsISupports window, nsIDOMNodeList list, Func<nsISupports, TGeckoNode, TWrapper> translator)
        {
            _window = window;
            _list = list;
            _translator = translator;
        }

        public uint Length => _list.GetLengthAttribute();

        public TWrapper this[uint index]
        {
            get
            {
                var item = _list.Item((uint) index);
                if (item is TGeckoNode)
                {
                    return ((TGeckoNode) item).Wrap(_window, _translator);
                }
                return null;
            }
        }


        public IEnumerator<TWrapper> GetEnumerator()
        {
            return new GeckoNodeEnumerator<TWrapper, TGeckoNode>(_window, _list, _translator);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    internal sealed class DomHtmlCollection<TWrapper, TGeckoNode>
        : IDomHtmlCollection<TWrapper>
        where TWrapper : GeckoNode
        where TGeckoNode : class, nsIDOMNode
    {
        private readonly nsISupports _window;
        private /*nsIDOMHTMLCollection*/nsIDOMNodeList _collection;
        private Func<nsISupports, TGeckoNode, TWrapper> _translator;

        public DomHtmlCollection(nsISupports window, /*nsIDOMHTMLCollection*/nsIDOMNodeList collection, Func<nsISupports, TGeckoNode, TWrapper> translator)
        {
            _window = window;
            _collection = collection;
            _translator = translator;
        }

        public uint Length
        {
            get {/* return (int) _collection.GetLengthAttribute();*/ throw new NotImplementedException(); }
        }

        public TWrapper this[uint index]
        {
            get
            {
                //var item = _collection.Item((uint) index);
                //if (item is TGeckoNode)
                //{
                //    return ((TGeckoNode) item).Wrap(_translator);
                //}
                //return null;
                throw new NotImplementedException();
            }
        }

        public TWrapper this[string name]
        {
            get
            {
                //var item = nsString.Pass(_collection.NamedItem, name);
                //if (item is TGeckoNode)
                //{
                //    return ((TGeckoNode) item).Wrap(_translator);
                //}
                //return null;
                throw new NotImplementedException();
            }
        }


        public IEnumerator<TWrapper> GetEnumerator()
        {
            return new GeckoNodeEnumerator<TWrapper, TGeckoNode>(_window, _collection, _translator);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public interface IDomHtmlCollection<TGeckoNode>
        : IGeckoArray<TGeckoNode>
    {
        TGeckoNode this[string name] { get; }
    }
}