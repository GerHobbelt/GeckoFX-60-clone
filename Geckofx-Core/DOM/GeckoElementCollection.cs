using System;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko
{
    /// <summary>
    /// Represents a collection of <see cref="GeckoHtmlElement"/> objects.
    /// </summary>
    public class GeckoElementCollection
        : IGeckoArray<GeckoHtmlElement>, IEnumerable<GeckoHtmlElement>
    {
        private readonly nsISupports _window;
        private nsIDOMNodeList List;

        internal GeckoElementCollection(nsISupports window, nsIDOMNodeList list)
        {
            _window = window;
            this.List = list;
        }

        public virtual uint Length => List?.GetLengthAttribute() ?? 0;

        public virtual GeckoHtmlElement this[uint index]
        {
            get
            {
                if (index >= Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                return (GeckoHtmlElement)GeckoNode.Create(_window, List.Item(index));
            }
        }

#region IEnumerable<GeckoElement> Members

        public virtual IEnumerator<GeckoHtmlElement> GetEnumerator()
        {
#if PORTFF60
            int length = Length;
            for (int i = 0; i < length; i++)
            {
                yield return GeckoHtmlElement.Create((/*  nsIDOMHTMLElement */nsISupports) List.Item((uint) i));
            }
#endif
            throw new NotImplementedException();
        }

#endregion

#region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (GeckoHtmlElement element in this)
                yield return element;
        }

#endregion
    }
}