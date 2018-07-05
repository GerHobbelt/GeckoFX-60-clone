namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridTrack : WebIDLBase
    {
        
        public GridTrack(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public GridTrackState State
        {
            get
            {
                return this.GetProperty<GridTrackState>("state");
            }
        }
    }
}
