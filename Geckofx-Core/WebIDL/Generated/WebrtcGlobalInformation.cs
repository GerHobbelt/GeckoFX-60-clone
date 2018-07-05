namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebrtcGlobalInformation : WebIDLBase
    {
        
        public WebrtcGlobalInformation(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int DebugLevel
        {
            get
            {
                return this.GetProperty<int>("debugLevel");
            }
            set
            {
                this.SetProperty("debugLevel", value);
            }
        }
        
        public bool AecDebug
        {
            get
            {
                return this.GetProperty<bool>("aecDebug");
            }
            set
            {
                this.SetProperty("aecDebug", value);
            }
        }
        
        public string AecDebugLogDir
        {
            get
            {
                return this.GetProperty<string>("aecDebugLogDir");
            }
            set
            {
                this.SetProperty("aecDebugLogDir", value);
            }
        }
    }
}
