using System;
using System.Collections.Generic;

namespace Gecko
{
    public class GeckoHtmlElementCollection
        : GeckoElementCollection
    {
        internal GeckoHtmlElementCollection(mozIDOMWindowProxy window, /* nsIDOMHTMLCollection */nsISupports col) : base(window, null)
        {
            this.Collection = col;
        }

        private /* nsIDOMHTMLCollection */nsISupports Collection;

        public override uint Length
        {
            get { /*return (Collection == null) ? 0 : (int) Collection.GetLengthAttribute();*/throw new NotImplementedException(); }
        }

        public override GeckoHtmlElement this[uint index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new ArgumentOutOfRangeException("index");

                //return GeckoHtmlElement.Create((/* nsIDOMHTMLElement */nsISupports) Collection.Item((uint) index));
                throw new NotImplementedException();
            }
        }

        public override IEnumerator<GeckoHtmlElement> GetEnumerator()
        {
            uint length = Length;
            //for (int i = 0; i < length; i++)
            //{
            //    yield return GeckoHtmlElement.Create((/* nsIDOMHTMLElement */nsISupports) Collection.Item((uint) i));
            //}
            throw new NotImplementedException();
        }
    }
}