namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozObjectLoadingContent : WebIDLBase
    {
        
        public MozObjectLoadingContent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ActualType
        {
            get
            {
                return this.GetProperty<string>("actualType");
            }
        }
        
        public uint DisplayedType
        {
            get
            {
                return this.GetProperty<uint>("displayedType");
            }
        }
        
        public bool Activated
        {
            get
            {
                return this.GetProperty<bool>("activated");
            }
        }
        
        public nsISupports SrcURI
        {
            get
            {
                return this.GetProperty<nsISupports>("srcURI");
            }
        }
        
        public uint DefaultFallbackType
        {
            get
            {
                return this.GetProperty<uint>("defaultFallbackType");
            }
        }
        
        public uint PluginFallbackType
        {
            get
            {
                return this.GetProperty<uint>("pluginFallbackType");
            }
        }
        
        public bool HasRunningPlugin
        {
            get
            {
                return this.GetProperty<bool>("hasRunningPlugin");
            }
        }
        
        public uint RunID
        {
            get
            {
                return this.GetProperty<uint>("runID");
            }
        }
        
        public uint GetContentTypeForMIMEType(string aMimeType)
        {
            return this.CallMethod<uint>("getContentTypeForMIMEType", aMimeType);
        }
        
        public object[] GetPluginAttributes()
        {
            return this.CallMethod<object[]>("getPluginAttributes");
        }
        
        public object[] GetPluginParameters()
        {
            return this.CallMethod<object[]>("getPluginParameters");
        }
        
        public void PlayPlugin()
        {
            this.CallVoidMethod("playPlugin");
        }
        
        public void Reload(bool aClearActivation)
        {
            this.CallVoidMethod("reload", aClearActivation);
        }
        
        public void SkipFakePlugins()
        {
            this.CallVoidMethod("skipFakePlugins");
        }
    }
}
