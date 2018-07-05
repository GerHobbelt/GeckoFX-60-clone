namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileReader : WebIDLBase
    {
        
        public FileReader(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public object Result
        {
            get
            {
                return this.GetProperty<object>("result");
            }
        }
        
        public nsIDOMDOMException Error
        {
            get
            {
                return this.GetProperty<nsIDOMDOMException>("error");
            }
        }
        
        public void ReadAsArrayBuffer(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsArrayBuffer", blob);
        }
        
        public void ReadAsBinaryString(nsIDOMBlob filedata)
        {
            this.CallVoidMethod("readAsBinaryString", filedata);
        }
        
        public void ReadAsText(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsText", blob);
        }
        
        public void ReadAsText(nsIDOMBlob blob, string label)
        {
            this.CallVoidMethod("readAsText", blob, label);
        }
        
        public void ReadAsDataURL(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsDataURL", blob);
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
