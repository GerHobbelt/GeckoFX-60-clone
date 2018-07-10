namespace Gecko.WebIDL
{
    using System;
    
    
    public class VTTCue : WebIDLBase
    {
        
        public VTTCue(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Region
        {
            get
            {
                return this.GetProperty<nsISupports>("region");
            }
            set
            {
                this.SetProperty("region", value);
            }
        }
        
        public DirectionSetting Vertical
        {
            get
            {
                return this.GetProperty<DirectionSetting>("vertical");
            }
            set
            {
                this.SetProperty("vertical", value);
            }
        }
        
        public bool SnapToLines
        {
            get
            {
                return this.GetProperty<bool>("snapToLines");
            }
            set
            {
                this.SetProperty("snapToLines", value);
            }
        }
        
        public WebIDLUnion<System.Double,AutoKeyword> Line
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.Double,AutoKeyword>>("line");
            }
            set
            {
                this.SetProperty("line", value);
            }
        }
        
        public LineAlignSetting LineAlign
        {
            get
            {
                return this.GetProperty<LineAlignSetting>("lineAlign");
            }
            set
            {
                this.SetProperty("lineAlign", value);
            }
        }
        
        public WebIDLUnion<System.Double,AutoKeyword> Position
        {
            get
            {
                return this.GetProperty<WebIDLUnion<System.Double,AutoKeyword>>("position");
            }
            set
            {
                this.SetProperty("position", value);
            }
        }
        
        public PositionAlignSetting PositionAlign
        {
            get
            {
                return this.GetProperty<PositionAlignSetting>("positionAlign");
            }
            set
            {
                this.SetProperty("positionAlign", value);
            }
        }
        
        public double Size
        {
            get
            {
                return this.GetProperty<double>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public AlignSetting Align
        {
            get
            {
                return this.GetProperty<AlignSetting>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Text
        {
            get
            {
                return this.GetProperty<string>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public nsISupports GetCueAsHTML()
        {
            return this.CallMethod<nsISupports>("getCueAsHTML");
        }
        
        public nsISupports DisplayState
        {
            get
            {
                return this.GetProperty<nsISupports>("displayState");
            }
            set
            {
                this.SetProperty("displayState", value);
            }
        }
        
        public bool HasBeenReset
        {
            get
            {
                return this.GetProperty<bool>("hasBeenReset");
            }
        }
        
        public double ComputedLine
        {
            get
            {
                return this.GetProperty<double>("computedLine");
            }
        }
        
        public double ComputedPosition
        {
            get
            {
                return this.GetProperty<double>("computedPosition");
            }
        }
        
        public PositionAlignSetting ComputedPositionAlign
        {
            get
            {
                return this.GetProperty<PositionAlignSetting>("computedPositionAlign");
            }
        }
        
        public bool GetActive
        {
            get
            {
                return this.GetProperty<bool>("getActive");
            }
        }
    }
}
