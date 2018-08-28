using System;
using System.Collections.Generic;
using Gecko.WebIDL;

namespace Gecko
{
    /// <summary>
    /// Represents a DOM style sheet.
    /// </summary>
    public class GeckoStyleSheet
    {
        private Lazy<WebIDL.StyleSheet> _styleSheet;
        private readonly mozIDOMWindowProxy _window;
        private /* nsIDOMCSSStyleSheet */nsISupports _DomStyleSheet;

        private GeckoStyleSheet(mozIDOMWindowProxy window,/* nsIDOMCSSStyleSheet */nsISupports styleSheet)
        {
            _window = window;
            _DomStyleSheet = styleSheet;
            _styleSheet = new Lazy<WebIDL.StyleSheet>(() => new WebIDL.StyleSheet((mozIDOMWindowProxy)_window, styleSheet));
        }

        internal static GeckoStyleSheet Create(mozIDOMWindowProxy window, /* nsIDOMCSSStyleSheet */nsISupports styleSheet)
        {
            return (styleSheet == null) ? null : new GeckoStyleSheet(window, styleSheet);
        }

        /// <summary>
        /// Gets the underlying XPCOM object.
        /// </summary>
        public nsISupports DomStyleSheet
        {
            get { return _DomStyleSheet; }
        }

        /// <summary>
        /// Gets or sets whether the style sheet is disabled.
        /// </summary>
        public bool Disabled
        {
            get { return _styleSheet.Value.Disabled; }
            set { _styleSheet.Value.Disabled = value; }
        }

        /// <summary>
        /// Gets the HREF of the style sheet.
        /// </summary>
        public string Href => _styleSheet.Value.Href;

        /// <summary>
        /// Gets the parent of this style sheet, if it was imported using an @import rule.
        /// </summary>
        public GeckoStyleSheet ParentStyleSheet => Create(_window, _styleSheet.Value.ParentStyleSheet);

        /// <summary>
        /// Gets the <see cref="GeckoStyleRule"/> which imported this style sheet.
        /// </summary>
        public GeckoStyleRule OwnerRule
        {
            get
            {
                /*return GeckoStyleRule.Create((nsIDOMCSSRule) _DomStyleSheet.GetOwnerRuleAttribute());*/throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the <see cref="GeckoNode"/> of the DOM element which imported this style
        /// sheet.  Typically, this is a LINK tag.
        /// </summary>
        public GeckoNode OwnerNode => GeckoNode.Create(_window, _styleSheet.Value.OwnerNode);

        public override string ToString()
        {
            return "Href=" + this.Href;
        }

        /// <summary>
        /// Gets the collection of rules in the style sheet.
        /// </summary>
        public StyleRuleCollection CssRules => _CssRules ?? (_CssRules = new StyleRuleCollection(_window, this));

        private StyleRuleCollection _CssRules;

        /// <summary>
        /// Represents a collection of rules in a style sheet.
        /// </summary>

        #region public class StyleRuleCollection : IEnumerable<GeckoStyleRule>
        public class StyleRuleCollection : IEnumerable<GeckoStyleRule>
        {
            private Lazy<WebIDL.CSSStyleSheet> _styleSheet;
            private Lazy<CSSRuleList> _ruleList;
            private GeckoStyleSheet StyleSheet;
            private /* nsIDOMCSSRuleList */nsISupports List;
            private mozIDOMWindowProxy _window;

            internal StyleRuleCollection(mozIDOMWindowProxy window, GeckoStyleSheet styleSheet)
            {

                StyleSheet = styleSheet;
                _window = window;
                _styleSheet = new Lazy<WebIDL.CSSStyleSheet>(() => new CSSStyleSheet(window, styleSheet.DomStyleSheet));
                _ruleList = new Lazy<CSSRuleList>(() => new CSSRuleList((mozIDOMWindowProxy)_window, _styleSheet.Value.CssRules));
                this.List = _styleSheet.Value.CssRules;
            }            

            /// <summary>
            /// Attempts to reload the rule list.
            /// </summary>
            public void Reload()
            {
                this.List = _styleSheet.Value.CssRules;
            }

            /// <summary>
            /// Gets whether the collection is read-only.
            /// </summary>
            public bool IsReadOnly
            {
                get { return List == null; }
            }

            /// <summary>
            /// Gets the number of items in the collection.
            /// </summary>
            public uint Count => _ruleList.Value.Length;

            /// <summary>
            /// Returns the <see cref="GeckoStyleRule"/> at a given index in the collection.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public GeckoStyleRule this[int index]
            {
                get
                {
                    if (index < 0 || index >= Count)
                        throw new ArgumentOutOfRangeException("index");

                    //return GeckoStyleRule.Create(List.Item((uint) index));
                    throw new NotImplementedException();
                }
            }

            /// <summary>
            /// Adds a new rule to the end of the collection.
            /// </summary>
            /// <param name="rule"></param>
            public void Add(string rule)
            {
                Insert(Count, rule);
            }

            /// <summary>
            /// Inserts a rule at the specified position in the collection.  The return value is the index in the list where the item was actually inserted,
            /// or -1 if the rule contains syntax errors and could not be added to the collection.
            /// </summary>
            /// <param name="index"></param>
            /// <param name="rule"></param>
            public int Insert(uint index, string rule)
            {
                if (IsReadOnly)
                    throw new InvalidOperationException("This collection is read-only.");
                else if (index < 0 || index > Count)
                    throw new ArgumentOutOfRangeException("index");
                else if (string.IsNullOrEmpty(rule))
                    return -1;

                return (int)_styleSheet.Value.InsertRule(rule, index);
            }

            /// <summary>
            /// Removes a specific rule from the collection.
            /// </summary>
            /// <param name="index"></param>
            public void RemoveAt(uint index)
            {
                if (IsReadOnly)
                    throw new InvalidOperationException("This collection is read-only.");
                else if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                _styleSheet.Value.DeleteRule(index);
            }

            /// <summary>
            /// Removes all rules from the collection.
            /// </summary>
            public void Clear()
            {
                if (IsReadOnly && Count > 0)
                    throw new InvalidOperationException("This collection is read-only.");

                for (uint i = Count; i > 0; i--)
                    _styleSheet.Value.DeleteRule(0);
            }

            #region IEnumerable<GeckoStyleRule> Members

            /// <summary>
            /// Returns an IEnumerator which can enumerate through the rules in the collection.
            /// </summary>
            /// <returns></returns>
            public IEnumerator<GeckoStyleRule> GetEnumerator()
            {           
                uint length = Count;
                for (uint i = 0; i < length; i++)
                    yield return GeckoStyleRule.Create(_window, _ruleList.Value.Item(i));
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                foreach (GeckoStyleRule element in this)
                    yield return element;
            }

            #endregion
        }

        #endregion
    }
}