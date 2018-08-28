using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Gecko.DOM;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM Comment
    /// </summary>
    public class GeckoComment : DOM.DomCharacterData
    {
        private nsIDOMComment DomComment;

        internal GeckoComment(mozIDOMWindowProxy window, nsIDOMComment comment)
            : base(window, comment)
        {
            DomComment = comment;
        }

        internal static GeckoComment CreateCommentWrapper(mozIDOMWindowProxy window, nsIDOMComment comment)
        {
            return (comment == null) ? null : new GeckoComment(window, comment);
        }
    }
}