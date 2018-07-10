namespace Gecko.WebIDL
{
    using System;
    
    
    public class GridArea : WebIDLBase
    {
        
        public GridArea(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public GridDeclaration Type
        {
            get
            {
                return this.GetProperty<GridDeclaration>("type");
            }
        }
        
        public uint RowStart
        {
            get
            {
                return this.GetProperty<uint>("rowStart");
            }
        }
        
        public uint RowEnd
        {
            get
            {
                return this.GetProperty<uint>("rowEnd");
            }
        }
        
        public uint ColumnStart
        {
            get
            {
                return this.GetProperty<uint>("columnStart");
            }
        }
        
        public uint ColumnEnd
        {
            get
            {
                return this.GetProperty<uint>("columnEnd");
            }
        }
    }
}
