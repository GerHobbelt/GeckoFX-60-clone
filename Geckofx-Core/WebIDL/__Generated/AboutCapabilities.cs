namespace Gecko.WebIDL
{
    using System;
    
    
    public class AboutCapabilities : WebIDLBase
    {
        
        public AboutCapabilities(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise SetBoolPref(string aPref, bool aValue)
        {
            return this.CallMethod<Promise>("setBoolPref", aPref, aValue);
        }
        
        public bool GetBoolPref(string aPref, System.Nullable<bool> aDefaultValue)
        {
            return this.CallMethod<bool>("getBoolPref", aPref, aDefaultValue);
        }
        
        public Promise SetCharPref(string aPref, string aValue)
        {
            return this.CallMethod<Promise>("setCharPref", aPref, aValue);
        }
        
        public string GetCharPref(string aPref, string aDefaultValue)
        {
            return this.CallMethod<string>("getCharPref", aPref, aDefaultValue);
        }
        
        public string GetStringFromBundle(string aStrBundle, string aStr)
        {
            return this.CallMethod<string>("getStringFromBundle", aStrBundle, aStr);
        }
        
        public string FormatURLPref(string aFormatURL)
        {
            return this.CallMethod<string>("formatURLPref", aFormatURL);
        }
        
        public void SendAsyncMessage(string aMessage, object aParams)
        {
            this.CallVoidMethod("sendAsyncMessage", aMessage, aParams);
        }
        
        public bool IsWindowPrivate()
        {
            return this.CallMethod<bool>("isWindowPrivate");
        }
    }
}
