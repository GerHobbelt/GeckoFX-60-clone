using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
    public sealed class JSAutoCompartment : IDisposable
    {
        private IntPtr _oldCompartment;
        private readonly IntPtr _cx;
        private readonly AutoJSContext.JSObjectWrapper _obj;
        private bool _isDisposed;

        public JSAutoCompartment(AutoJSContext context, nsISupports comObject)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            if (context.ContextPointer == IntPtr.Zero)
                throw new ArgumentException("context has Null ContextPointer");
            if (context == null)
                throw new ArgumentNullException("comObject");

            _obj = context.ConvertCOMObjectToJSObject(comObject, false);
            _cx = context.ContextPointer;

            EnterCompartment();
        }


        public JSAutoCompartment(IntPtr context, IntPtr obj)
        {
            if (context == IntPtr.Zero)
                throw new ArgumentNullException("context");
            if (obj == IntPtr.Zero)
                throw new ArgumentNullException("obj");

            _obj = new AutoJSContext.JSObjectWrapper(IntPtr.Zero) { JSObject = obj};
            _cx = context;

            EnterCompartment();
        }

        private void EnterCompartment()
        {
            _oldCompartment = SpiderMonkey.JS_RequestEnterCompartment(_cx, _obj.JSObject);
        }

        public IntPtr ScopeObject
        {
            get { return _obj.JSObject; }
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }
            _isDisposed = true;
            if (_cx != IntPtr.Zero)
            {
                SpiderMonkey.JS_RequestLeaveCompartment(_cx, _oldCompartment);
            }
            _obj.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}