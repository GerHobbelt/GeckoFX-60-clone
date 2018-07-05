namespace Gecko.WebIDL
{
    using System;
    
    
    public class Element : WebIDLBase
    {
        
        public Element(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string NamespaceURI
        {
            get
            {
                return this.GetProperty<string>("namespaceURI");
            }
        }
        
        public string Prefix
        {
            get
            {
                return this.GetProperty<string>("prefix");
            }
        }
        
        public string LocalName
        {
            get
            {
                return this.GetProperty<string>("localName");
            }
        }
        
        public string TagName
        {
            get
            {
                return this.GetProperty<string>("tagName");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public string ClassName
        {
            get
            {
                return this.GetProperty<string>("className");
            }
            set
            {
                this.SetProperty("className", value);
            }
        }
        
        public nsISupports ClassList
        {
            get
            {
                return this.GetProperty<nsISupports>("classList");
            }
        }
        
        public nsISupports Attributes
        {
            get
            {
                return this.GetProperty<nsISupports>("attributes");
            }
        }
        
        public float FontSizeInflation
        {
            get
            {
                return this.GetProperty<float>("fontSizeInflation");
            }
        }
        
        public string[] GetAttributeNames()
        {
            return this.CallMethod<string[]>("getAttributeNames");
        }
        
        public string GetAttribute(string name)
        {
            return this.CallMethod<string>("getAttribute", name);
        }
        
        public string GetAttributeNS(string @namespace, string localName)
        {
            return this.CallMethod<string>("getAttributeNS", @namespace, localName);
        }
        
        public void SetAttribute(string name, string value)
        {
            this.CallVoidMethod("setAttribute", name, value);
        }
        
        public void SetAttributeNS(string @namespace, string name, string value)
        {
            this.CallVoidMethod("setAttributeNS", @namespace, name, value);
        }
        
        public void RemoveAttribute(string name)
        {
            this.CallVoidMethod("removeAttribute", name);
        }
        
        public void RemoveAttributeNS(string @namespace, string localName)
        {
            this.CallVoidMethod("removeAttributeNS", @namespace, localName);
        }
        
        public bool HasAttribute(string name)
        {
            return this.CallMethod<bool>("hasAttribute", name);
        }
        
        public bool HasAttributeNS(string @namespace, string localName)
        {
            return this.CallMethod<bool>("hasAttributeNS", @namespace, localName);
        }
        
        public bool HasAttributes()
        {
            return this.CallMethod<bool>("hasAttributes");
        }
        
        public nsIDOMElement Closest(string selector)
        {
            return this.CallMethod<nsIDOMElement>("closest", selector);
        }
        
        public bool Matches(string selector)
        {
            return this.CallMethod<bool>("matches", selector);
        }
        
        public bool WebkitMatchesSelector(string selector)
        {
            return this.CallMethod<bool>("webkitMatchesSelector", selector);
        }
        
        public nsISupports GetElementsByTagName(string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagName", localName);
        }
        
        public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagNameNS", @namespace, localName);
        }
        
        public nsISupports GetElementsByClassName(string classNames)
        {
            return this.CallMethod<nsISupports>("getElementsByClassName", classNames);
        }
        
        public nsIDOMElement[] GetElementsWithGrid()
        {
            return this.CallMethod<nsIDOMElement[]>("getElementsWithGrid");
        }
        
        public nsIDOMElement InsertAdjacentElement(string where, nsIDOMElement element)
        {
            return this.CallMethod<nsIDOMElement>("insertAdjacentElement", where, element);
        }
        
        public void InsertAdjacentText(string where, string data)
        {
            this.CallVoidMethod("insertAdjacentText", where, data);
        }
        
        public bool MozMatchesSelector(string selector)
        {
            return this.CallMethod<bool>("mozMatchesSelector", selector);
        }
        
        public void SetPointerCapture(int pointerId)
        {
            this.CallVoidMethod("setPointerCapture", pointerId);
        }
        
        public void ReleasePointerCapture(int pointerId)
        {
            this.CallVoidMethod("releasePointerCapture", pointerId);
        }
        
        public bool HasPointerCapture(int pointerId)
        {
            return this.CallMethod<bool>("hasPointerCapture", pointerId);
        }
        
        public void SetCapture()
        {
            this.CallVoidMethod("setCapture");
        }
        
        public void SetCapture(bool retargetToElement)
        {
            this.CallVoidMethod("setCapture", retargetToElement);
        }
        
        public void ReleaseCapture()
        {
            this.CallVoidMethod("releaseCapture");
        }
        
        public void SetCaptureAlways()
        {
            this.CallVoidMethod("setCaptureAlways");
        }
        
        public void SetCaptureAlways(bool retargetToElement)
        {
            this.CallVoidMethod("setCaptureAlways", retargetToElement);
        }
        
        public nsISupports GetAttributeNode(string name)
        {
            return this.CallMethod<nsISupports>("getAttributeNode", name);
        }
        
        public nsISupports SetAttributeNode(nsISupports newAttr)
        {
            return this.CallMethod<nsISupports>("setAttributeNode", newAttr);
        }
        
        public nsISupports RemoveAttributeNode(nsISupports oldAttr)
        {
            return this.CallMethod<nsISupports>("removeAttributeNode", oldAttr);
        }
        
        public nsISupports GetAttributeNodeNS(string namespaceURI, string localName)
        {
            return this.CallMethod<nsISupports>("getAttributeNodeNS", namespaceURI, localName);
        }
        
        public nsISupports SetAttributeNodeNS(nsISupports newAttr)
        {
            return this.CallMethod<nsISupports>("setAttributeNodeNS", newAttr);
        }
        
        public bool ScrollByNoFlush(int dx, int dy)
        {
            return this.CallMethod<bool>("scrollByNoFlush", dx, dy);
        }
        
        public nsISupports GetAsFlexContainer()
        {
            return this.CallMethod<nsISupports>("getAsFlexContainer");
        }
        
        public nsISupports[] GetGridFragments()
        {
            return this.CallMethod<nsISupports[]>("getGridFragments");
        }
        
        public nsISupports GetTransformToAncestor(nsIDOMElement ancestor)
        {
            return this.CallMethod<nsISupports>("getTransformToAncestor", ancestor);
        }
        
        public nsISupports GetTransformToParent()
        {
            return this.CallMethod<nsISupports>("getTransformToParent");
        }
        
        public nsISupports GetTransformToViewport()
        {
            return this.CallMethod<nsISupports>("getTransformToViewport");
        }
        
        public int ScrollTop
        {
            get
            {
                return this.GetProperty<int>("scrollTop");
            }
            set
            {
                this.SetProperty("scrollTop", value);
            }
        }
        
        public int ScrollLeft
        {
            get
            {
                return this.GetProperty<int>("scrollLeft");
            }
            set
            {
                this.SetProperty("scrollLeft", value);
            }
        }
        
        public int ScrollWidth
        {
            get
            {
                return this.GetProperty<int>("scrollWidth");
            }
        }
        
        public int ScrollHeight
        {
            get
            {
                return this.GetProperty<int>("scrollHeight");
            }
        }
        
        public int ClientTop
        {
            get
            {
                return this.GetProperty<int>("clientTop");
            }
        }
        
        public int ClientLeft
        {
            get
            {
                return this.GetProperty<int>("clientLeft");
            }
        }
        
        public int ClientWidth
        {
            get
            {
                return this.GetProperty<int>("clientWidth");
            }
        }
        
        public int ClientHeight
        {
            get
            {
                return this.GetProperty<int>("clientHeight");
            }
        }
        
        public int ScrollTopMin
        {
            get
            {
                return this.GetProperty<int>("scrollTopMin");
            }
        }
        
        public int ScrollTopMax
        {
            get
            {
                return this.GetProperty<int>("scrollTopMax");
            }
        }
        
        public int ScrollLeftMin
        {
            get
            {
                return this.GetProperty<int>("scrollLeftMin");
            }
        }
        
        public int ScrollLeftMax
        {
            get
            {
                return this.GetProperty<int>("scrollLeftMax");
            }
        }
        
        public nsISupports GetClientRects()
        {
            return this.CallMethod<nsISupports>("getClientRects");
        }
        
        public nsISupports GetBoundingClientRect()
        {
            return this.CallMethod<nsISupports>("getBoundingClientRect");
        }
        
        public void ScrollIntoView()
        {
            this.CallVoidMethod("scrollIntoView");
        }
        
        public void ScrollIntoView(WebIDLUnion<System.Boolean,System.Object> arg)
        {
            this.CallVoidMethod("scrollIntoView", arg);
        }
        
        public void Scroll(double x, double y)
        {
            this.CallVoidMethod("scroll", x, y);
        }
        
        public void Scroll()
        {
            this.CallVoidMethod("scroll");
        }
        
        public void Scroll(object options)
        {
            this.CallVoidMethod("scroll", options);
        }
        
        public void ScrollTo(double x, double y)
        {
            this.CallVoidMethod("scrollTo", x, y);
        }
        
        public void ScrollTo()
        {
            this.CallVoidMethod("scrollTo");
        }
        
        public void ScrollTo(object options)
        {
            this.CallVoidMethod("scrollTo", options);
        }
        
        public void ScrollBy(double x, double y)
        {
            this.CallVoidMethod("scrollBy", x, y);
        }
        
        public void ScrollBy()
        {
            this.CallVoidMethod("scrollBy");
        }
        
        public void ScrollBy(object options)
        {
            this.CallVoidMethod("scrollBy", options);
        }
        
        public void MozScrollSnap()
        {
            this.CallVoidMethod("mozScrollSnap");
        }
        
        public string InnerHTML
        {
            get
            {
                return this.GetProperty<string>("innerHTML");
            }
            set
            {
                this.SetProperty("innerHTML", value);
            }
        }
        
        public string OuterHTML
        {
            get
            {
                return this.GetProperty<string>("outerHTML");
            }
            set
            {
                this.SetProperty("outerHTML", value);
            }
        }
        
        public void InsertAdjacentHTML(string position, string text)
        {
            this.CallVoidMethod("insertAdjacentHTML", position, text);
        }
        
        public void UnsafeSetInnerHTML(string html)
        {
            this.CallVoidMethod("unsafeSetInnerHTML", html);
        }
        
        public nsIDOMElement QuerySelector(string selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(string selectors)
        {
            return this.CallMethod<nsISupports>("querySelectorAll", selectors);
        }
        
        public nsISupports ShadowRoot
        {
            get
            {
                return this.GetProperty<nsISupports>("shadowRoot");
            }
        }
        
        public nsISupports OpenOrClosedShadowRoot
        {
            get
            {
                return this.GetProperty<nsISupports>("openOrClosedShadowRoot");
            }
        }
        
        public nsISupports AssignedSlot
        {
            get
            {
                return this.GetProperty<nsISupports>("assignedSlot");
            }
        }
        
        public string Slot
        {
            get
            {
                return this.GetProperty<string>("slot");
            }
            set
            {
                this.SetProperty("slot", value);
            }
        }
        
        public nsISupports AttachShadow(object shadowRootInitDict)
        {
            return this.CallMethod<nsISupports>("attachShadow", shadowRootInitDict);
        }
        
        public nsISupports CreateShadowRoot()
        {
            return this.CallMethod<nsISupports>("createShadowRoot");
        }
        
        public void RequestFullscreen()
        {
            this.CallVoidMethod("requestFullscreen");
        }
        
        public void MozRequestFullScreen()
        {
            this.CallVoidMethod("mozRequestFullScreen");
        }
        
        public void RequestPointerLock()
        {
            this.CallVoidMethod("requestPointerLock");
        }
    }
}
