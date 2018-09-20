using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko;

namespace Gecko.DOM
{
    public static class GeckoElementExtensionMethods
    {
        /// <summary>
        /// UI specific implementation extension method GetBoundingClientRect()
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static System.Drawing.Rectangle GetBoundingClientRect(this GeckoElement element)
        {
            var domElement = new WebIDL.Element(element.Window, (nsISupports)element.DOMElement);
            var br = domElement.GetBoundingClientRect();
            if (br == null)
                return Rectangle.Empty;
            var rect = new WebIDL.DOMRectReadOnly(element.Window, br);
            return new Rectangle((int)rect.Left, (int)rect.Top, (int)rect.Width, (int)rect.Height);
        }
    }
}