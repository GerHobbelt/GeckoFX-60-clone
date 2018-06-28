using System;
using System.Collections.Generic;

namespace Gecko
{
    public class GeckoHtmlElementCollection
        : GeckoElementCollection
    {
        internal GeckoHtmlElementCollection(/* nsIDOMHTMLCollection */nsISupports col) : base(null)
        {
            this.Collection = col;
        }

        private /* nsIDOMHTMLCollection */nsISupports Collection;

        public override int Length
        {
            get { return (Collection == null) ? 0 : (int) Collection.GetLengthAttribute(); }
        }

        public override GeckoHtmlElement this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new ArgumentOutOfRangeException("index");

                return GeckoHtmlElement.Create((/* nsIDOMHTMLElement */nsISupports) Collection.Item((uint) index));
            }
        }

        public override IEnumerator<GeckoHtmlElement> GetEnumerator()
        {
            int length = Length;
            for (int i = 0; i < length; i++)
            {
                yield return GeckoHtmlElement.Create((/* nsIDOMHTMLElement */nsISupports) Collection.Item((uint) i));
            }
        }
    }
}