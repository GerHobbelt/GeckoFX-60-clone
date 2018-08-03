namespace Gecko.DOM
{
    public class DocumentFragment
        : GeckoNode
    {
        private nsIDOMDocumentFragment _documentFragment;

        protected DocumentFragment(nsISupports window, nsIDOMDocumentFragment documentFragment)
            : base(window, documentFragment)
        {
            _documentFragment = documentFragment;
        }


        public static DocumentFragment CreateDocumentFragmentWrapper(nsISupports window, nsIDOMDocumentFragment documentFragment)
        {
            return documentFragment == null ? null : new DocumentFragment(window, documentFragment);
        }
    }
}