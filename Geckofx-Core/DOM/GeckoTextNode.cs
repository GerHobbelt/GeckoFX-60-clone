using Gecko.Interop;

namespace Gecko.DOM
{
    public class GeckoTextNode
        : DomCharacterData
    {
        private nsIDOMText _domText;

        private GeckoTextNode(mozIDOMWindowProxy window, nsIDOMText domText)
            : base(window, domText)
        {
            _domText = domText;
        }

        public static GeckoTextNode CreateTextNodeWrapper(mozIDOMWindowProxy window, nsIDOMText domText)
        {
            return new GeckoTextNode(window, domText);
        }


        public GeckoTextNode SplitText(uint offset)
        {
            return _domText.SplitText(offset).Wrap(Window, CreateTextNodeWrapper);
        }


        public string WholeText
        {
            get { return nsString.Get(_domText.GetWholeTextAttribute); }
        }
    }
}