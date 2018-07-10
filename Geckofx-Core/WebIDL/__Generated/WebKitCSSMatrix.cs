namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebKitCSSMatrix : WebIDLBase
    {
        
        public WebKitCSSMatrix(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports SetMatrixValue(string transformList)
        {
            return this.CallMethod<nsISupports>("setMatrixValue", transformList);
        }
        
        public nsISupports Multiply(nsISupports other)
        {
            return this.CallMethod<nsISupports>("multiply", other);
        }
        
        public nsISupports Inverse()
        {
            return this.CallMethod<nsISupports>("inverse");
        }
        
        public nsISupports Translate()
        {
            return this.CallMethod<nsISupports>("translate");
        }
        
        public nsISupports Translate(double tx)
        {
            return this.CallMethod<nsISupports>("translate", tx);
        }
        
        public nsISupports Translate(double tx, double ty)
        {
            return this.CallMethod<nsISupports>("translate", tx, ty);
        }
        
        public nsISupports Translate(double tx, double ty, double tz)
        {
            return this.CallMethod<nsISupports>("translate", tx, ty, tz);
        }
        
        public nsISupports Scale()
        {
            return this.CallMethod<nsISupports>("scale");
        }
        
        public nsISupports Scale(double scaleX)
        {
            return this.CallMethod<nsISupports>("scale", scaleX);
        }
        
        public nsISupports Scale(double scaleX, double scaleY)
        {
            return this.CallMethod<nsISupports>("scale", scaleX, scaleY);
        }
        
        public nsISupports Scale(double scaleX, double scaleY, double scaleZ)
        {
            return this.CallMethod<nsISupports>("scale", scaleX, scaleY, scaleZ);
        }
        
        public nsISupports Rotate()
        {
            return this.CallMethod<nsISupports>("rotate");
        }
        
        public nsISupports Rotate(double rotX)
        {
            return this.CallMethod<nsISupports>("rotate", rotX);
        }
        
        public nsISupports Rotate(double rotX, double rotY)
        {
            return this.CallMethod<nsISupports>("rotate", rotX, rotY);
        }
        
        public nsISupports Rotate(double rotX, double rotY, double rotZ)
        {
            return this.CallMethod<nsISupports>("rotate", rotX, rotY, rotZ);
        }
        
        public nsISupports RotateAxisAngle()
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle");
        }
        
        public nsISupports RotateAxisAngle(double x)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle", x);
        }
        
        public nsISupports RotateAxisAngle(double x, double y)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle", x, y);
        }
        
        public nsISupports RotateAxisAngle(double x, double y, double z)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle", x, y, z);
        }
        
        public nsISupports RotateAxisAngle(double x, double y, double z, double angle)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle", x, y, z, angle);
        }
        
        public nsISupports SkewX()
        {
            return this.CallMethod<nsISupports>("skewX");
        }
        
        public nsISupports SkewX(double sx)
        {
            return this.CallMethod<nsISupports>("skewX", sx);
        }
        
        public nsISupports SkewY()
        {
            return this.CallMethod<nsISupports>("skewY");
        }
        
        public nsISupports SkewY(double sy)
        {
            return this.CallMethod<nsISupports>("skewY", sy);
        }
    }
}
