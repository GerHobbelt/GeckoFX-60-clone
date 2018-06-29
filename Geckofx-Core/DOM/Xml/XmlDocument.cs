using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM.Xml
{
    public sealed class XmlDocument
        : GeckoDomDocument
    {
        private nsIDOMXMLDocument _xmlDocument;

        internal XmlDocument(nsIDOMXMLDocument document)
            : base((nsIDOMDocument)document)
        {
            _xmlDocument = document;
        }

        public bool Async
        {
            get { /*return _xmlDocument.GetAsyncAttribute();*/ throw new NotImplementedException(); }
            set { /*_xmlDocument.SetAsyncAttribute(value);*/ throw new NotImplementedException(); }
        }

        public bool Load(string url)
        {
            //bool ret = nsString.Pass(_xmlDocument.Load, url);
            //return ret;
            throw new NotImplementedException();
        }
    }
}