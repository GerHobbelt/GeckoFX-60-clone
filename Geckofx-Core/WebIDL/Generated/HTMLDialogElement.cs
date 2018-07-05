namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLDialogElement : WebIDLBase
    {
        
        public HTMLDialogElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Open
        {
            get
            {
                return this.GetProperty<bool>("open");
            }
            set
            {
                this.SetProperty("open", value);
            }
        }
        
        public string ReturnValue
        {
            get
            {
                return this.GetProperty<string>("returnValue");
            }
            set
            {
                this.SetProperty("returnValue", value);
            }
        }
        
        public void Show()
        {
            this.CallVoidMethod("show");
        }
        
        public void ShowModal()
        {
            this.CallVoidMethod("showModal");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public void Close(string returnValue)
        {
            this.CallVoidMethod("close", returnValue);
        }
    }
}
