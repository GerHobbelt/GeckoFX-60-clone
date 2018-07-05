namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridLine : WebIDLBase
    {
        
        public GridLine(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string[] Names
        {
            get
            {
                return this.GetProperty<string[]>("names");
            }
        }
        
        public double Start
        {
            get
            {
                return this.GetProperty<double>("start");
            }
        }
        
        public double Breadth
        {
            get
            {
                return this.GetProperty<double>("breadth");
            }
        }
        
        public GridDeclaration Type
        {
            get
            {
                return this.GetProperty<GridDeclaration>("type");
            }
        }
        
        public uint Number
        {
            get
            {
                return this.GetProperty<uint>("number");
            }
        }
        
        public int NegativeNumber
        {
            get
            {
                return this.GetProperty<int>("negativeNumber");
            }
        }
    }
}
