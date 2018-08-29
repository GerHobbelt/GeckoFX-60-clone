using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.WebIDL
{
    public class WebIDLBase
    {
        private readonly nsISupports _thisObject;
        private readonly nsISupports _globalWindowProxy;

        public WebIDLBase(nsIDOMWindow globalWindow, nsISupports thisObject)
        {
            throw new NotImplementedException();
        }

        internal nsISupports Object => _thisObject;

        public WebIDLBase(nsISupports globalWindow, nsISupports thisObject)
        {
            if (globalWindow == null)
                throw new ArgumentNullException(nameof(globalWindow));
            _globalWindowProxy = globalWindow;
            _thisObject = thisObject;
        }

        public WebIDLBase(mozIDOMWindowProxy globalWindow, nsISupports thisObject)
        {
            if (globalWindow == null)
                throw new ArgumentNullException(nameof(globalWindow));
            _globalWindowProxy = (nsISupports)globalWindow;
            _thisObject = thisObject;
        }

        public WebIDLBase(mozIDOMWindow globalWindow, nsISupports thisObject)
        {
            _globalWindowProxy = (nsISupports)globalWindow;
            _thisObject = thisObject;
        }

        public T GetProperty<T>(string propertyName)
        {
            using (var context = new AutoJSContext(_globalWindowProxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject(_thisObject, true))
            {
                var result = SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject.JSObject, propertyName);
                if (result.IsUndefined)
                    throw new GeckoException(String.Format("Property '{0}' of type '{1}' does not exist on object",
                        propertyName, typeof(T).Name));
                var retObject = result.ToObject<T>();
                return ConvertObject<T>(retObject);
            }
        }

        public void SetProperty(string propertyName, object value)
        {
            using (var context = new AutoJSContext(_globalWindowProxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject(_thisObject, true))
            {
                DisposablCollection disposablCollection;
                var types = ConvertTypes(new[] { value }, context, out disposablCollection).First();
                var jso = jsObject.JSObject;
                try
                {
                    if (!SpiderMonkey.JS_SetProperty(context.ContextPointer, ref jso, propertyName,
                        ref types))
                        throw new GeckoException(
                            String.Format("Property '{0}' of value '{1}' could not be set on object",
                                propertyName, value));
                }
                finally
                {
                    disposablCollection.Dispose();
                }
            }
        }

        public void CallVoidMethod(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext(_globalWindowProxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject(_thisObject, true))
            {
                DisposablCollection disposablCollection;
                var collection = ConvertTypes(paramObjects, context, out disposablCollection);
                SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject.JSObject, methodName, collection.ToArray());             
                disposablCollection.Dispose();
            }
        }

        public T CallMethod<T>(string methodName, params object[] paramObjects)
        {
            using (var context = new AutoJSContext(_globalWindowProxy))
            using (var jsObject = context.ConvertCOMObjectToJSObject(_thisObject, true))
            {
                DisposablCollection disposablCollection;
                var collection = ConvertTypes(paramObjects, context, out disposablCollection);
                var retObject =
                    SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject.JSObject, methodName, collection.ToArray())
                        .ToObject();
                disposablCollection.Dispose();                
                return ConvertObject<T>(retObject);
            }
        }

        private static string EscapeStringForJS(string str)
        {
            return str.Replace(@"\", @"\\").Replace(@"""", @"\""").Replace("\n", "\\n").Replace("\r", "\\r");
        }

        // TODO: move to own class and file
        public class DisposablCollection : IDisposable
        {
            private readonly IEnumerable<IDisposable> _disposables;

            public DisposablCollection(IEnumerable<IDisposable> disposables)
            {
                _disposables = disposables;
            }
                 
            public void Dispose()
            {
                foreach (var toDispose in _disposables)
                {
                    toDispose.Dispose();
                }
            }
        }

        private static JsVal CreateBoolJsVal(AutoJSContext context, bool b)
        {
            JsVal val;
            SpiderMonkey.JS_ExecuteScript(context.ContextPointer, ((bool)b) ? "true;" : "false;", out val);
            return val;
        }

        private static List<JsVal> ConvertTypes(object[] paramObjects, AutoJSContext context, out DisposablCollection toDispose)
        {
            List<IDisposable> list = new List<IDisposable>();
            toDispose = new DisposablCollection(list);
            var collection = new List<JsVal>();
            if (paramObjects == null)
                return collection;

            foreach (var p in paramObjects)
            {
                JsVal val;
                if (p is nsAString || p is nsACString || p is nsAUTF8String || p is String)
                {
                    val = SpiderMonkey.StringToJsVal(context.ContextPointer, p.ToString());
                }
                else if (p is nsISupports)
                {
                    // This returns a  [xpconnect wrapped nsISupports] - why may or may not be good enought - if not could try and access the objects wrappedJSObject property?
                    // val = SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "valueOf");
                    // Replaced CallFunctionName 'valueOf' method with 'managed convert' (for speed reasons)
                    var jso = context.ConvertCOMObjectToJSObject((nsISupports) p, false);
                    list.Add(jso);
                    val = JsVal.FromPtr(jso.JSObject);
                }
                else if (p is bool)
                {
                    val = CreateBoolJsVal(context, (bool) p);
                }
                else if (p is double)
                {
                    val = JsVal.FromDouble((double) p);
                }

                else if (p is int)
                {
                    val = JsVal.FromDouble(Convert.ToDouble(p));
                }
                else if (p is WebIDLUnionBase)
                {
                    WebIDLUnionBase b = (WebIDLUnionBase) p;
                    if (b.IsNull())
                    {
                        SpiderMonkey.JS_ExecuteScript(context.ContextPointer, "null", out val);
                    }
                    else if (b.IsComObject())
                    {
                        var item = ((WebIDLUnionBase)p).ToComObject();
                        var jso = context.ConvertCOMObjectToJSObject(item, false);
                        list.Add(jso);
                        val = JsVal.FromPtr(jso.JSObject);
                    }
                    else if (b.IsBool())
                    {
                        val = CreateBoolJsVal(context, b.ToBool());
                    }
                    else
                    {
                       throw new NotImplementedException("WebIDLUnion are currently only supported for nsISupport and bool types and null's.");
                    }                    
                }
                else
                    SpiderMonkey.JS_ExecuteScript(context.ContextPointer, (p ?? "null").ToString(), out val);
                collection.Add(val);
            }
            return collection;
        }

        private T ConvertObject<T>(object o)
        {
            var t = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            if (t.IsValueType)
                return (T) Convert.ChangeType(o, t);
            else
                return (T) o;
        }
    }
}
