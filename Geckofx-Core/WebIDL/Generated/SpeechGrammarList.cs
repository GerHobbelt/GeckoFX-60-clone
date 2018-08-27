namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechGrammarList : WebIDLBase
    {
        
        public SpeechGrammarList(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports Item(uint index)
        {
            return this.CallMethod<nsISupports>("item", index);
        }
        
        public void AddFromURI(string src)
        {
            this.CallVoidMethod("addFromURI", src);
        }
        
        public void AddFromURI(string src, float weight)
        {
            this.CallVoidMethod("addFromURI", src, weight);
        }
        
        public void AddFromString(string @string)
        {
            this.CallVoidMethod("addFromString", @string);
        }
        
        public void AddFromString(string @string, float weight)
        {
            this.CallVoidMethod("addFromString", @string, weight);
        }
    }
}
