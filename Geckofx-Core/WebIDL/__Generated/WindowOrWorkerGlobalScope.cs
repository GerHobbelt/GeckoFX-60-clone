namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowOrWorkerGlobalScope : WebIDLBase
    {
        
        public WindowOrWorkerGlobalScope(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Origin
        {
            get
            {
                return this.GetProperty<USVString>("origin");
            }
        }
        
        public string Btoa(string btoa)
        {
            return this.CallMethod<string>("btoa", btoa);
        }
        
        public string Atob(string atob)
        {
            return this.CallMethod<string>("atob", atob);
        }
        
        public int SetTimeout(string handler)
        {
            return this.CallMethod<int>("setTimeout", handler);
        }
        
        public int SetTimeout(string handler, int timeout)
        {
            return this.CallMethod<int>("setTimeout", handler, timeout);
        }
        
        public int SetTimeout(string handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setTimeout", handler, timeout, unused);
        }
        
        public void ClearTimeout()
        {
            this.CallVoidMethod("clearTimeout");
        }
        
        public void ClearTimeout(int handle)
        {
            this.CallVoidMethod("clearTimeout", handle);
        }
        
        public int SetInterval(string handler)
        {
            return this.CallMethod<int>("setInterval", handler);
        }
        
        public int SetInterval(string handler, int timeout)
        {
            return this.CallMethod<int>("setInterval", handler, timeout);
        }
        
        public int SetInterval(string handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setInterval", handler, timeout, unused);
        }
        
        public void ClearInterval()
        {
            this.CallVoidMethod("clearInterval");
        }
        
        public void ClearInterval(int handle)
        {
            this.CallVoidMethod("clearInterval", handle);
        }
        
        public Promise < nsISupports > CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement,nsISupports,nsIDOMHTMLCanvasElement,nsIDOMBlob> aImage)
        {
            return this.CallMethod<Promise < nsISupports >>("createImageBitmap", aImage);
        }
        
        public Promise < nsISupports > CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement,nsISupports,nsIDOMHTMLCanvasElement,nsIDOMBlob> aImage, int aSx, int aSy, int aSw, int aSh)
        {
            return this.CallMethod<Promise < nsISupports >>("createImageBitmap", aImage, aSx, aSy, aSw, aSh);
        }
        
        public Promise < nsISupports > Fetch(WebIDLUnion<nsISupports,USVString> input)
        {
            return this.CallMethod<Promise < nsISupports >>("fetch", input);
        }
        
        public Promise < nsISupports > Fetch(WebIDLUnion<nsISupports,USVString> input, object init)
        {
            return this.CallMethod<Promise < nsISupports >>("fetch", input, init);
        }
        
        public bool IsSecureContext
        {
            get
            {
                return this.GetProperty<bool>("isSecureContext");
            }
        }
        
        public nsISupports IndexedDB
        {
            get
            {
                return this.GetProperty<nsISupports>("indexedDB");
            }
        }
        
        public nsISupports Caches
        {
            get
            {
                return this.GetProperty<nsISupports>("caches");
            }
        }
        
        public Promise < nsISupports > CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement,nsISupports,nsIDOMHTMLCanvasElement,nsIDOMBlob> aImage, int aOffset, int aLength, ImageBitmapFormat aFormat, Object[] aLayout)
        {
            return this.CallMethod<Promise < nsISupports >>("createImageBitmap", aImage, aOffset, aLength, aFormat, aLayout);
        }
    }
}
