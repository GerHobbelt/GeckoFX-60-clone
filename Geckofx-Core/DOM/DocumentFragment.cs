namespace Gecko.DOM
{
    public class DocumentFragment
        : GeckoNode
    {
        private nsIDOMDocumentFragment _documentFragment;

        protected DocumentFragment(mozIDOMWindowProxy window, nsIDOMDocumentFragment documentFragment)
            : base(window, documentFragment)
        {
            _documentFragment = documentFragment;
        }


        public static DocumentFragment CreateDocumentFragmentWrapper(mozIDOMWindowProxy window, nsIDOMDocumentFragment documentFragment)
        {
            return documentFragment == null ? null : new DocumentFragment(window, documentFragment);
        }
    }
}