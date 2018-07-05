namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageBitmap : WebIDLBase
    {
        
        public ImageBitmap(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public ImageBitmapFormat FindOptimalFormat()
        {
            return this.CallMethod<ImageBitmapFormat>("findOptimalFormat");
        }
        
        public ImageBitmapFormat FindOptimalFormat(ImageBitmapFormat[] aPossibleFormats)
        {
            return this.CallMethod<ImageBitmapFormat>("findOptimalFormat", aPossibleFormats);
        }
        
        public int MappedDataLength(ImageBitmapFormat aFormat)
        {
            return this.CallMethod<int>("mappedDataLength", aFormat);
        }
        
        public Promise < System.Object[] > MapDataInto(ImageBitmapFormat aFormat, IntPtr aBuffer, int aOffset)
        {
            return this.CallMethod<Promise < System.Object[] >>("mapDataInto", aFormat, aBuffer, aOffset);
        }
    }
}
