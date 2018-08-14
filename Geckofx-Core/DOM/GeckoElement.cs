#region ***** BEGIN LICENSE BLOCK *****

/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */

#endregion END LICENSE BLOCK

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Gecko.Collections;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko
{
    public class GeckoElement
        : GeckoNode
    {
        private nsIDOMElement _domElement;

        private string m_cachedTagName;

        protected Lazy<WebIDL.Element> _element;

        internal GeckoElement(nsISupports window, nsIDOMElement domElement)
            : base(window, domElement)
        {
            if (window == null)
                throw new ArgumentNullException(nameof(window));
            _domElement = domElement;
            _element = new Lazy<WebIDL.Element>(() => new WebIDL.Element((mozIDOMWindowProxy)window, (nsISupports)domElement));
        }

        public nsIDOMElement DOMElement => _domElement;

        /// <summary>
        /// Gets the name of the tag.
        /// </summary>
        public string TagName
        {
            get
            {
                if (m_cachedTagName != null)
                    return m_cachedTagName;

                return m_cachedTagName = _element.Value.TagName;
            }
        }

        #region Attribute

        public GeckoNamedNodeMap Attributes => _element.Value.Attributes.Wrap(Window, (window, x) => new GeckoNamedNodeMap(window, x));

        /// <summary>
        /// Gets the value of an attribute on this element with the specified name.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public string GetAttribute(string attributeName)
        {
            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

            return _element.Value.GetAttribute(attributeName);           
        }

        /// <summary>
        /// Check if Element contains specified attribute.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to look for</param>
        /// <returns>true if attribute exists false otherwise</returns>
        public bool HasAttribute(string attributeName)
        {
            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

           return  _element.Value.HasAttribute(attributeName);
        }

        /// <summary>
        /// Sets the value of an attribute on this element with the specified name.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <param name="value"></param>
        public void SetAttribute(string attributeName, string value)
        {
            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

            // This is to preserve geckofx 45 and before behavior in geckofx 60
            // The normal behavior now is to write null.toString() to the attribute value when passed null.
            if (value == null)
                value = String.Empty;

            _element.Value.SetAttribute(attributeName, value);
        }

        /// <summary>
        /// Removes an attribute from this element.
        /// </summary>
        /// <param name="attributeName"></param>
        public void RemoveAttribute(string attributeName)
        {
            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

            _element.Value.RemoveAttribute(attributeName);
        }

        #endregion

        #region Attribute Nodes

        public GeckoAttribute GetAttributeNode(string name)
        {
            var ret = (nsIDOMElement)_element.Value.GetAttributeNode(name);            
            return (ret == null) ? null : new GeckoAttribute(this.Window,  ret);
        }

        public GeckoAttribute SetAttributeNode(GeckoAttribute newAttr)
        {
            //var ret = _domElement.SetAttributeNode(newAttr.DomAttr);
            //return ret == null ? null : new GeckoAttribute(ret);
            throw new NotImplementedException();
        }

        public GeckoAttribute RemoveAttributeNode(GeckoAttribute newAttr)
        {
            //var ret = _domElement.RemoveAttributeNode(newAttr.DomAttr);
            //return ret == null ? null : new GeckoAttribute(ret);
            throw new NotImplementedException();
        }

        public bool HasAttributes => _element.Value.HasAttributes();

        #endregion

        #region Attribute NS

        public bool HasAttributeNS(string namespaceUri, string attributeName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                return HasAttribute(attributeName);

            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

            //return nsString.Pass<bool>(_domElement.HasAttributeNS, namespaceUri, attributeName);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value of an attribute on this element with the specified name and namespace.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public string GetAttributeNS(string namespaceUri, string attributeName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                return GetAttribute(attributeName);

            if (string.IsNullOrEmpty(attributeName))
                throw new ArgumentException("attributeName");

            return _element.Value.GetAttributeNS(namespaceUri, attributeName);
        }

        /// <summary>
        /// Sets the value of an attribute on this element with the specified name and namespace.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <param name="value"></param>
        public void SetAttributeNS(string namespaceUri, string attributeName, string value)
        {
            if (string.IsNullOrEmpty(namespaceUri))
            {
                SetAttribute(attributeName, value);
            }
            else
            {
                if (string.IsNullOrEmpty(attributeName))
                    throw new ArgumentException("attributeName");

                //_domElement.SetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName),
                //    new nsAString(value));
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Attribute Node NS

        public GeckoAttribute GetAttributeNodeNS(string namespaceUri, string localName)
        {
            if (string.IsNullOrEmpty(namespaceUri))
                return GetAttributeNode(localName);

            return GeckoAttribute.CreateAttributeWrapper(Window, (nsIDOMElement) _element.Value.GetAttributeNodeNS(namespaceUri, localName));
        }

        public GeckoAttribute SetAttributeNodeNS(GeckoAttribute attribute)
        {
            return GeckoAttribute.CreateAttributeWrapper(Window, (nsIDOMElement)_element.Value.SetAttributeNodeNS((nsISupports) attribute.DomAttr));            
        }

        #endregion

        public int ScrollLeft
        {
            get { return _element.Value.ScrollLeft; }
            set { _element.Value.ScrollLeft = value; }
        }

        public int ScrollTop
        {
            get { return _element.Value.ScrollTop; }
            set { _element.Value.ScrollTop = value; }
        }

        public int ScrollWidth => _element.Value.ScrollWidth;

        public int ScrollHeight => _element.Value.ScrollHeight;

        public int ClientWidth => _element.Value.ClientWidth;

        public int ClientHeight => _element.Value.ClientHeight;

        /// <summary>
        /// Returns a collection containing the child elements of this element with a given tag name.
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public IDomHtmlCollection<GeckoElement> GetElementsByTagName(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
                return null;

            return _element.Value.GetElementsByTagName(tagName)
                .Wrap(Window,
                    (window, x) =>
                        new DomHtmlCollection<GeckoElement, /* nsIDOMHTMLElement */ nsIDOMElement>(window, (nsIDOMNodeList)x,
                            CreateDomElementWrapper));
        }

        public IDomHtmlCollection<GeckoElement> GetElementsByTagNameNS(string namespaceURI, string localName)
        {
            if (string.IsNullOrEmpty(namespaceURI))
                return GetElementsByTagName(localName);

            if (string.IsNullOrEmpty(localName))
                return null;
            throw new NotImplementedException();
#if PORTFF60
            //var ret = nsString.Pass<nsIDOMHTMLCollection>(_domElement.GetElementsByTagNameNS, namespaceURI, localName);
            //return ret == null ? null : new GeckoHtmlElementCollection(ret);
            return nsString.Pass<nsIDOMHTMLCollection>(_domElement.GetElementsByTagNameNS, namespaceURI, localName)
                .Wrap(x => new DomHtmlCollection<GeckoElement, /* nsIDOMHTMLElement */nsISupports>(x, CreateDomElementWrapper));
#endif
        }


        public static GeckoElement CreateDomElementWrapper(nsISupports window, nsIDOMElement element)
        {
            if (element == null)
                return null;

            var htmlElement = Xpcom.QueryInterface</* nsIDOMHTMLElement */nsISupports>(element);
            if (htmlElement != null)
            {
                Marshal.ReleaseComObject(htmlElement);
                return GeckoHtmlElement.Create(window, /* (nsIDOMHTMLElement) */ element);
            }
            var svgElement = Xpcom.QueryInterface</* nsIDOMSVGElement */ nsISupports>(element);
            if (svgElement != null)
            {
                Marshal.ReleaseComObject(svgElement);
                return DOM.Svg.SvgElement.CreateSvgElementWrapper(window, /* nsIDOMSVGElement */ element);
            }
            var xulElement = Xpcom.QueryInterface<nsIDOMXULElement>(element);
            if (xulElement != null)
            {
                Marshal.ReleaseComObject(xulElement);
                return DOM.Xul.XulElement.CreateXulElementWrapper(window, (nsIDOMXULElement) element);
            }
            return new GeckoElement(window, element);
        }

        public GeckoElement QuerySelector(string selectors)
        {
            return _element.Value.QuerySelector(selectors).Wrap(Window, CreateDomElementWrapper);
        }
    }
}