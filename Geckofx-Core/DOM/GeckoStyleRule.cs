using System;

namespace Gecko
{
    /// <summary>
    /// Represents a CSS rule in a <see cref="GeckoStyleSheet"/>.
    /// </summary>
    public class GeckoStyleRule
    {
        private GeckoStyleRule(/* nsIDOMCSSRule */nsISupports rule)
        {
            _DomStyleRule = rule;
        }

        internal static GeckoStyleRule Create(/* nsIDOMCSSRule */nsISupports rule)
        {
            return (rule == null) ? null : new GeckoStyleRule(rule);
        }

        /// <summary>
        /// Gets the underlying XPCOM object.
        /// </summary>
        public object DomStyleRule
        {
            get { return _DomStyleRule; }
        }

        private /* nsIDOMCSSRule */nsISupports _DomStyleRule;

        /// <summary>
        /// Gets the selector text for this rule, or null if it is not a style rule; otherwise, null.
        /// </summary>
        public string SelectorText
        {
            get
            {
#if PORTFF60
                nsIDOMCSSStyleRule rule = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
                if (rule != null)
                {
                    return nsString.Get(rule.GetSelectorTextAttribute);
                }
                return null;
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets this rule formatted as CSS text.
        /// </summary>
        public string CssText
        {
            get { /*return nsString.Get(_DomStyleRule.GetCssTextAttribute);*/throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the style properties of this rule, if it is a style rule; otherwise, null.
        /// </summary>
        public string StyleCssText
        {
            get
            {
#if PORTFF60
                nsIDOMCSSStyleRule rule = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
                if (rule != null)
                {
                    return nsString.Get(rule.GetStyleAttribute().GetCssTextAttribute);
                }
                return null;
#endif
                throw new NotImplementedException();
            }
            set
            {
#if PORTFF60
                nsIDOMCSSStyleRule rule = Xpcom.QueryInterface<nsIDOMCSSStyleRule>(DomStyleRule);
                if (rule != null)
                {
                    nsString.Set(rule.GetStyleAttribute().SetCssTextAttribute, value);
                }
                else
                {
                    throw new InvalidOperationException("This rule does not support StyleCssText.");
                }
#endif
            }
        }

        /// <summary>
        /// Gets the <see cref="GeckoStyleSheet"/> which contains this rule.
        /// </summary>
        public GeckoStyleSheet ParentStyleSheet
        {
            get
            {
#if PORTFF60
                return GeckoStyleSheet.Create((/* nsIDOMCSSStyleSheet */nsISupports) _DomStyleRule.GetParentStyleSheetAttribute());
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the <see cref="GeckoStyleSheet"/> which this rule imports, if it is an @import rule; otherwise, null.
        /// </summary>
        public GeckoStyleSheet ImportedStyleSheet
        {
            get
            {
#if PORTFF60
                nsIDOMCSSImportRule rule = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
                if (rule != null)
                {
                    return GeckoStyleSheet.Create((/* nsIDOMCSSStyleSheet */nsISupports) rule.GetStyleSheetAttribute());
                }
                return null;
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the HREF of the style sheet imported by this rule, if it is an @import rule; otherwise, null.
        /// </summary>
        public string ImportedHref
        {
            get
            {
#if PORTFF60
                nsIDOMCSSImportRule rule = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
                if (rule != null)
                {
                    return nsString.Get(rule.GetHrefAttribute);
                }
                return null;
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the media type of the style sheet imported by this rule, if it is an @import rule; otherwise, null.
        /// </summary>
        public GeckoMediaList ImportedMedia
        {
            get
            {
#if PORTFF60
                nsIDOMCSSImportRule rule = Xpcom.QueryInterface<nsIDOMCSSImportRule>(DomStyleRule);
                if (rule != null)
                {
                    return new GeckoMediaList(rule.GetMediaAttribute());
                }
                return null;
#endif
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the <see cref="GeckoRuleType"/> of this rule.
        /// </summary>
        public GeckoRuleType RuleType
        {
            get { /*return (GeckoRuleType) _DomStyleRule.GetTypeAttribute();*/throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return this.CssText;
        }
    }
}