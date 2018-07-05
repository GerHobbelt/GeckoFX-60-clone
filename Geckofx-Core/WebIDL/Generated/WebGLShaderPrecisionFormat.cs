namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLShaderPrecisionFormat : WebIDLBase
    {
        
        public WebGLShaderPrecisionFormat(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int RangeMin
        {
            get
            {
                return this.GetProperty<int>("rangeMin");
            }
        }
        
        public int RangeMax
        {
            get
            {
                return this.GetProperty<int>("rangeMax");
            }
        }
        
        public int Precision
        {
            get
            {
                return this.GetProperty<int>("precision");
            }
        }
    }
}
