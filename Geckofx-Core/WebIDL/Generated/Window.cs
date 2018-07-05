namespace Gecko.WebIDL
{
    using System;
    
    
    public class Window : WebIDLBase
    {
        
        public Window(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMWindow WindowAttribute
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("window");
            }
        }
        
        public nsIDOMWindow Self
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("self");
            }
        }
        
        public nsIDOMDocument Document
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("document");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsISupports Location
        {
            get
            {
                return this.GetProperty<nsISupports>("location");
            }
        }
        
        public nsISupports History
        {
            get
            {
                return this.GetProperty<nsISupports>("history");
            }
        }
        
        public nsISupports CustomElements
        {
            get
            {
                return this.GetProperty<nsISupports>("customElements");
            }
        }
        
        public nsISupports Locationbar
        {
            get
            {
                return this.GetProperty<nsISupports>("locationbar");
            }
        }
        
        public nsISupports Menubar
        {
            get
            {
                return this.GetProperty<nsISupports>("menubar");
            }
        }
        
        public nsISupports Personalbar
        {
            get
            {
                return this.GetProperty<nsISupports>("personalbar");
            }
        }
        
        public nsISupports Scrollbars
        {
            get
            {
                return this.GetProperty<nsISupports>("scrollbars");
            }
        }
        
        public nsISupports Statusbar
        {
            get
            {
                return this.GetProperty<nsISupports>("statusbar");
            }
        }
        
        public nsISupports Toolbar
        {
            get
            {
                return this.GetProperty<nsISupports>("toolbar");
            }
        }
        
        public string Status
        {
            get
            {
                return this.GetProperty<string>("status");
            }
            set
            {
                this.SetProperty("status", value);
            }
        }
        
        public bool Closed
        {
            get
            {
                return this.GetProperty<bool>("closed");
            }
        }
        
        public mozIDOMWindowProxy Frames
        {
            get
            {
                return this.GetProperty<mozIDOMWindowProxy>("frames");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public mozIDOMWindowProxy Top
        {
            get
            {
                return this.GetProperty<mozIDOMWindowProxy>("top");
            }
        }
        
        public object Opener
        {
            get
            {
                return this.GetProperty<object>("opener");
            }
            set
            {
                this.SetProperty("opener", value);
            }
        }
        
        public mozIDOMWindowProxy Parent
        {
            get
            {
                return this.GetProperty<mozIDOMWindowProxy>("parent");
            }
        }
        
        public nsIDOMElement FrameElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("frameElement");
            }
        }
        
        public nsISupports Navigator
        {
            get
            {
                return this.GetProperty<nsISupports>("navigator");
            }
        }
        
        public nsISupports ApplicationCache
        {
            get
            {
                return this.GetProperty<nsISupports>("applicationCache");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Focus()
        {
            this.CallVoidMethod("focus");
        }
        
        public void Blur()
        {
            this.CallVoidMethod("blur");
        }
        
        public mozIDOMWindowProxy Open()
        {
            return this.CallMethod<mozIDOMWindowProxy>("open");
        }
        
        public mozIDOMWindowProxy Open(string url)
        {
            return this.CallMethod<mozIDOMWindowProxy>("open", url);
        }
        
        public mozIDOMWindowProxy Open(string url, string target)
        {
            return this.CallMethod<mozIDOMWindowProxy>("open", url, target);
        }
        
        public mozIDOMWindowProxy Open(string url, string target, string features)
        {
            return this.CallMethod<mozIDOMWindowProxy>("open", url, target, features);
        }
        
        public void Alert()
        {
            this.CallVoidMethod("alert");
        }
        
        public void Alert(string message)
        {
            this.CallVoidMethod("alert", message);
        }
        
        public bool Confirm()
        {
            return this.CallMethod<bool>("confirm");
        }
        
        public bool Confirm(string message)
        {
            return this.CallMethod<bool>("confirm", message);
        }
        
        public string Prompt()
        {
            return this.CallMethod<string>("prompt");
        }
        
        public string Prompt(string message)
        {
            return this.CallMethod<string>("prompt", message);
        }
        
        public string Prompt(string message, string @default)
        {
            return this.CallMethod<string>("prompt", message, @default);
        }
        
        public void Print()
        {
            this.CallVoidMethod("print");
        }
        
        public void PostMessage(object message, string targetOrigin)
        {
            this.CallVoidMethod("postMessage", message, targetOrigin);
        }
        
        public void PostMessage(object message, string targetOrigin, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, targetOrigin, transfer);
        }
        
        public void CaptureEvents()
        {
            this.CallVoidMethod("captureEvents");
        }
        
        public void ReleaseEvents()
        {
            this.CallVoidMethod("releaseEvents");
        }
        
        public nsISelection GetSelection()
        {
            return this.CallMethod<nsISelection>("getSelection");
        }
        
        public nsISupports GetComputedStyle(nsIDOMElement elt)
        {
            return this.CallMethod<nsISupports>("getComputedStyle", elt);
        }
        
        public nsISupports GetComputedStyle(nsIDOMElement elt, string pseudoElt)
        {
            return this.CallMethod<nsISupports>("getComputedStyle", elt, pseudoElt);
        }
        
        public nsISupports Screen
        {
            get
            {
                return this.GetProperty<nsISupports>("screen");
            }
        }
        
        public object InnerWidth
        {
            get
            {
                return this.GetProperty<object>("innerWidth");
            }
            set
            {
                this.SetProperty("innerWidth", value);
            }
        }
        
        public object InnerHeight
        {
            get
            {
                return this.GetProperty<object>("innerHeight");
            }
            set
            {
                this.SetProperty("innerHeight", value);
            }
        }
        
        public double ScrollX
        {
            get
            {
                return this.GetProperty<double>("scrollX");
            }
        }
        
        public double PageXOffset
        {
            get
            {
                return this.GetProperty<double>("pageXOffset");
            }
        }
        
        public double ScrollY
        {
            get
            {
                return this.GetProperty<double>("scrollY");
            }
        }
        
        public double PageYOffset
        {
            get
            {
                return this.GetProperty<double>("pageYOffset");
            }
        }
        
        public object ScreenX
        {
            get
            {
                return this.GetProperty<object>("screenX");
            }
            set
            {
                this.SetProperty("screenX", value);
            }
        }
        
        public object ScreenY
        {
            get
            {
                return this.GetProperty<object>("screenY");
            }
            set
            {
                this.SetProperty("screenY", value);
            }
        }
        
        public object OuterWidth
        {
            get
            {
                return this.GetProperty<object>("outerWidth");
            }
            set
            {
                this.SetProperty("outerWidth", value);
            }
        }
        
        public object OuterHeight
        {
            get
            {
                return this.GetProperty<object>("outerHeight");
            }
            set
            {
                this.SetProperty("outerHeight", value);
            }
        }
        
        public nsISupports MatchMedia(string query)
        {
            return this.CallMethod<nsISupports>("matchMedia", query);
        }
        
        public void MoveTo(int x, int y)
        {
            this.CallVoidMethod("moveTo", x, y);
        }
        
        public void MoveBy(int x, int y)
        {
            this.CallVoidMethod("moveBy", x, y);
        }
        
        public void ResizeTo(int x, int y)
        {
            this.CallVoidMethod("resizeTo", x, y);
        }
        
        public void ResizeBy(int x, int y)
        {
            this.CallVoidMethod("resizeBy", x, y);
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
        
        public void CancelAnimationFrame(int handle)
        {
            this.CallVoidMethod("cancelAnimationFrame", handle);
        }
        
        public nsISupports Performance
        {
            get
            {
                return this.GetProperty<nsISupports>("performance");
            }
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public nsIDOMElement RealFrameElement
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("realFrameElement");
            }
        }
        
        public float MozInnerScreenX
        {
            get
            {
                return this.GetProperty<float>("mozInnerScreenX");
            }
        }
        
        public float MozInnerScreenY
        {
            get
            {
                return this.GetProperty<float>("mozInnerScreenY");
            }
        }
        
        public double DevicePixelRatio
        {
            get
            {
                return this.GetProperty<double>("devicePixelRatio");
            }
        }
        
        public int ScrollMinX
        {
            get
            {
                return this.GetProperty<int>("scrollMinX");
            }
        }
        
        public int ScrollMinY
        {
            get
            {
                return this.GetProperty<int>("scrollMinY");
            }
        }
        
        public int ScrollMaxX
        {
            get
            {
                return this.GetProperty<int>("scrollMaxX");
            }
        }
        
        public int ScrollMaxY
        {
            get
            {
                return this.GetProperty<int>("scrollMaxY");
            }
        }
        
        public bool FullScreen
        {
            get
            {
                return this.GetProperty<bool>("fullScreen");
            }
            set
            {
                this.SetProperty("fullScreen", value);
            }
        }
        
        public ulong MozPaintCount
        {
            get
            {
                return this.GetProperty<ulong>("mozPaintCount");
            }
        }
        
        public object Content
        {
            get
            {
                return this.GetProperty<object>("content");
            }
        }
        
        public nsIDOMEventTarget WindowRoot
        {
            get
            {
                return this.GetProperty<nsIDOMEventTarget>("windowRoot");
            }
        }
        
        public nsISupports GetDefaultComputedStyle(nsIDOMElement elt)
        {
            return this.CallMethod<nsISupports>("getDefaultComputedStyle", elt);
        }
        
        public nsISupports GetDefaultComputedStyle(nsIDOMElement elt, string pseudoElt)
        {
            return this.CallMethod<nsISupports>("getDefaultComputedStyle", elt, pseudoElt);
        }
        
        public void ScrollByLines(int numLines)
        {
            this.CallVoidMethod("scrollByLines", numLines);
        }
        
        public void ScrollByLines(int numLines, object options)
        {
            this.CallVoidMethod("scrollByLines", numLines, options);
        }
        
        public void ScrollByPages(int numPages)
        {
            this.CallVoidMethod("scrollByPages", numPages);
        }
        
        public void ScrollByPages(int numPages, object options)
        {
            this.CallVoidMethod("scrollByPages", numPages, options);
        }
        
        public void SizeToContent()
        {
            this.CallVoidMethod("sizeToContent");
        }
        
        public void Back()
        {
            this.CallVoidMethod("back");
        }
        
        public void Forward()
        {
            this.CallVoidMethod("forward");
        }
        
        public void Home()
        {
            this.CallVoidMethod("home");
        }
        
        public void UpdateCommands(string action)
        {
            this.CallVoidMethod("updateCommands", action);
        }
        
        public void UpdateCommands(string action, nsISelection sel)
        {
            this.CallVoidMethod("updateCommands", action, sel);
        }
        
        public void UpdateCommands(string action, nsISelection sel, short reason)
        {
            this.CallVoidMethod("updateCommands", action, sel, reason);
        }
        
        public bool Find()
        {
            return this.CallMethod<bool>("find");
        }
        
        public bool Find(string str)
        {
            return this.CallMethod<bool>("find", str);
        }
        
        public bool Find(string str, bool caseSensitive)
        {
            return this.CallMethod<bool>("find", str, caseSensitive);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames);
        }
        
        public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
        {
            return this.CallMethod<bool>("find", str, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames, showDialog);
        }
        
        public void Dump(string str)
        {
            this.CallVoidMethod("dump", str);
        }
        
        public void SetResizable(bool resizable)
        {
            this.CallVoidMethod("setResizable", resizable);
        }
        
        public mozIDOMWindowProxy OpenDialog()
        {
            return this.CallMethod<mozIDOMWindowProxy>("openDialog");
        }
        
        public mozIDOMWindowProxy OpenDialog(string url)
        {
            return this.CallMethod<mozIDOMWindowProxy>("openDialog", url);
        }
        
        public mozIDOMWindowProxy OpenDialog(string url, string name)
        {
            return this.CallMethod<mozIDOMWindowProxy>("openDialog", url, name);
        }
        
        public mozIDOMWindowProxy OpenDialog(string url, string name, string options)
        {
            return this.CallMethod<mozIDOMWindowProxy>("openDialog", url, name, options);
        }
        
        public mozIDOMWindowProxy OpenDialog(string url, string name, string options, object extraArguments)
        {
            return this.CallMethod<mozIDOMWindowProxy>("openDialog", url, name, options, extraArguments);
        }
        
        public object GetInterface(nsISupports iid)
        {
            return this.CallMethod<object>("getInterface", iid);
        }
        
        public bool ShouldReportForServiceWorkerScope(USVString aScope)
        {
            return this.CallMethod<bool>("shouldReportForServiceWorkerScope", aScope);
        }
        
        public ushort WindowState
        {
            get
            {
                return this.GetProperty<ushort>("windowState");
            }
        }
        
        public bool IsFullyOccluded
        {
            get
            {
                return this.GetProperty<bool>("isFullyOccluded");
            }
        }
        
        public nsIBrowserDOMWindow BrowserDOMWindow
        {
            get
            {
                return this.GetProperty<nsIBrowserDOMWindow>("browserDOMWindow");
            }
            set
            {
                this.SetProperty("browserDOMWindow", value);
            }
        }
        
        public nsISupports MessageManager
        {
            get
            {
                return this.GetProperty<nsISupports>("messageManager");
            }
        }
        
        public bool IsChromeWindow
        {
            get
            {
                return this.GetProperty<bool>("isChromeWindow");
            }
        }
        
        public void GetAttention()
        {
            this.CallVoidMethod("getAttention");
        }
        
        public void GetAttentionWithCycleCount(int aCycleCount)
        {
            this.CallVoidMethod("getAttentionWithCycleCount", aCycleCount);
        }
        
        public void SetCursor(string cursor)
        {
            this.CallVoidMethod("setCursor", cursor);
        }
        
        public void Maximize()
        {
            this.CallVoidMethod("maximize");
        }
        
        public void Minimize()
        {
            this.CallVoidMethod("minimize");
        }
        
        public void Restore()
        {
            this.CallVoidMethod("restore");
        }
        
        public void NotifyDefaultButtonLoaded(nsIDOMElement defaultButton)
        {
            this.CallVoidMethod("notifyDefaultButtonLoaded", defaultButton);
        }
        
        public nsISupports GetGroupMessageManager(string aGroup)
        {
            return this.CallMethod<nsISupports>("getGroupMessageManager", aGroup);
        }
        
        public void BeginWindowMove(nsIDOMEvent mouseDownEvent)
        {
            this.CallVoidMethod("beginWindowMove", mouseDownEvent);
        }
        
        public void BeginWindowMove(nsIDOMEvent mouseDownEvent, nsIDOMElement panel)
        {
            this.CallVoidMethod("beginWindowMove", mouseDownEvent, panel);
        }
        
        public nsISupports AudioWorklet
        {
            get
            {
                return this.GetProperty<nsISupports>("audioWorklet");
            }
        }
        
        public nsISupports PaintWorklet
        {
            get
            {
                return this.GetProperty<nsISupports>("paintWorklet");
            }
        }
        
        public void CancelIdleCallback(uint handle)
        {
            this.CallVoidMethod("cancelIdleCallback", handle);
        }
        
        public nsISupports IntlUtils
        {
            get
            {
                return this.GetProperty<nsISupports>("intlUtils");
            }
        }
        
        public string[] GetRegionalPrefsLocales()
        {
            return this.CallMethod<string[]>("getRegionalPrefsLocales");
        }
    }
}
