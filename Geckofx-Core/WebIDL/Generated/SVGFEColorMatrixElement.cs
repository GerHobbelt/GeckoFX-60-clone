namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEColorMatrixElement : WebIDLBase
    {
        
        public SVGFEColorMatrixElement(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports In1
        {
            get
            {
                return this.GetProperty<nsISupports>("in1");
            }
        }
        
        public nsISupports Type
        {
            get
            {
                return this.GetProperty<nsISupports>("type");
            }
        }
        
        public nsISupports Values
        {
            get
            {
                return this.GetProperty<nsISupports>("values");
            }
        }
    }
}
