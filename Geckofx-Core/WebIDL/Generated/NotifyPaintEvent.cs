namespace Gecko.WebIDL
{
    using System;
    
    
    public class NotifyPaintEvent : WebIDLBase
    {
        
        public NotifyPaintEvent(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ClientRects
        {
            get
            {
                return this.GetProperty<nsISupports>("clientRects");
            }
        }
        
        public nsISupports BoundingClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("boundingClientRect");
            }
        }
        
        public nsISupports PaintRequests
        {
            get
            {
                return this.GetProperty<nsISupports>("paintRequests");
            }
        }
        
        public ulong TransactionId
        {
            get
            {
                return this.GetProperty<ulong>("transactionId");
            }
        }
        
        public double PaintTimeStamp
        {
            get
            {
                return this.GetProperty<double>("paintTimeStamp");
            }
        }
    }
}
