namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScriptProcessorNode : WebIDLBase
    {
        
        public ScriptProcessorNode(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int BufferSize
        {
            get
            {
                return this.GetProperty<int>("bufferSize");
            }
        }
    }
}
