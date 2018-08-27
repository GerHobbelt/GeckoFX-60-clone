using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.Text;

// functions are declared like
// extern JS_PUBLIC_API(JSContextCallback) JS_SetContextCallback(JSRuntime *rt, JSContextCallback cxCallback);
// C++ default convention is Cdecl

namespace Gecko
{
    public static class SpiderMonkey
    {
        #region compiler independent wrappers

        public static JSType JS_TypeOfValue(IntPtr cx, JsVal jsVal)
        {
            return JS_TypeOfValue(cx, ref jsVal);
        }

        public static bool JS_SetProperty(IntPtr cx, IntPtr jsObject, string name, JsVal value)
        {
            return JS_SetProperty(cx, ref jsObject, name, ref value);
        }

        private static void HandleInvokeFailure(IntPtr cx, IntPtr jsObject, string name)
        {
            var exception = SpiderMonkey.JS_GetPendingException(cx);
            if (exception != IntPtr.Zero)
            {
                var exceptionJsVal = JsVal.FromPtr(exception);
                var st = GetStackTrace(cx, jsObject, exceptionJsVal);
                var msg = exceptionJsVal.ToString();
                msg += st;
                throw new GeckoException($"Calling function '{name}' failed: '{msg}'");
            }

            throw new GeckoException($"Failed to call function '{name}'");
        }

        internal static string GetStackTrace(IntPtr cx, IntPtr globalObject, JsVal exceptionJsVal)
        {
            if (!exceptionJsVal.IsObject)
                return String.Empty;

            if (!SpiderMonkey.JS_SetProperty(cx, ref globalObject, "__RequestedScope", ref exceptionJsVal))
                throw new GeckoException("Failed to set __RequestedScope Property.");

            const string s = "(function() { " + "return this.stack" + " }).call(this.__RequestedScope)";

            var retJsVal = new JsVal();
            var success = SpiderMonkey.JS_EvaluateScript(cx, s, (uint)s.Length, "script", 1, ref retJsVal);
            return !success ? String.Empty : String.Format(" StackTrace: {0}", retJsVal);
        }

        /// <summary>
        /// JS_CallFunctionName without args
        /// </summary>
        /// <param name="cx"></param>
        /// <param name="jsObject"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name)
        {
            bool result;
            JsVal value;
            int parameterCount = 0;
            var mutableHandle = new MutableHandleValue();
            if (!JS_CallFunctionName(cx, ref jsObject, name, ref parameterCount, ref mutableHandle))
                HandleInvokeFailure(cx, jsObject, name);

            value = JsVal.FromPtr(mutableHandle.Handle);            
            
            return value;
        }

        public static JsVal JS_CallFunctionName(IntPtr cx, IntPtr jsObject, string name, JsVal[] args)
        {
            if ((args == null) || (args.Length == 0))
                return JS_CallFunctionName(cx, jsObject, name);

            bool result;
            JsVal value = default(JsVal);
            using (var argsArray = new HandleValueArray(args.Length, args))
            {               
                MutableHandleValue mutableHandle = new MutableHandleValue();
                result = JS_CallFunctionName(cx, ref jsObject, name, argsArray.Ptr, ref mutableHandle);
                if (result)
                    value = JsVal.FromPtr(mutableHandle.Handle);
            }

            if (!result)
                HandleInvokeFailure(cx, jsObject, name);

            return value;
        }

        public static JsVal JS_CallFunctionValue(IntPtr cx, IntPtr jsObject, JsVal func)
        {
            var mutableHandle = new MutableHandleValue();
            bool success;
            using (var args = new HandleValueArray(0, new JsVal[0]))
                success = JS_CallFunctionValue(cx, jsObject, ref func, args.Ptr, ref mutableHandle);
            if (success)
                return JsVal.FromPtr(mutableHandle.Handle);

            HandleInvokeFailure(cx, jsObject, func.ToString());

            throw new Exception("HandleInvokeFailure always throws execption, so this line is never reached.");
        }


        public static IntPtr JS_RequestEnterCompartment(IntPtr cx, IntPtr obj)
        {
            JS_BeginRequest(cx);
            return JS_EnterCompartment(cx, obj);
        }       

        public static bool JS_ExecuteScript(IntPtr cx, string script, out JsVal jsval)
        {
            jsval = default(JsVal);
            var scriptHandle = new MutableHandle();
            if (!JS_CompileUCScript(cx, script, script.Length, GetCompileOptions(cx), ref scriptHandle))
                throw new GeckoException("Failed to compile script.");
            var val = new MutableHandleValue();
            var handle = scriptHandle.Handle;
            if (!JS_ExecuteScript(cx, ref handle, ref val))
                return false;

            jsval = JsVal.FromPtr(val.Handle);
            return true;
        }

        public static bool JS_EvaluateScript(IntPtr cx, string src, UInt32 length, string filename, UInt32 lineno,
            ref JsVal jsval)
        {
            src = EncodeUnicodeScript(src);
            if (cx == IntPtr.Zero)
                throw new ArgumentNullException("cx");

            return JS_ExecuteScript(cx, src, out jsval);
        }

        public static JsVal StringToJsVal(IntPtr cx, string str)
        {
            var val = new MutableJSVal();
            if (!ToJSValue(cx, str, ref val))
               return default(JsVal);
            return val.Val;
        }

        // https://stackoverflow.com/a/10773988/361714
        private static string StringFromNativeUtf8(IntPtr nativeUtf8)
        {
            int len = 0;
            while (Marshal.ReadByte(nativeUtf8, len) != 0) ++len;
            byte[] buffer = new byte[len];
            Marshal.Copy(nativeUtf8, buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }

        public static string JsValToString(IntPtr cx, JsVal jsVal)
        {
            IntPtr ptr = SpiderMonkey.ToString(cx, ref jsVal);
            return StringFromNativeUtf8(ptr);            
        }

        public static IntPtr JS_GetClassObject(IntPtr context, IntPtr proto)
        {
            var m = new MutableHandle();
            JS_GetClassObject(context, proto, ref m);
            return m.Handle;
        }

        public static JsVal JS_GetProperty(IntPtr cx, IntPtr jsObject, string name)
        {
            bool success;
            var value = new JsVal();
            success = JS_GetProperty(cx, ref jsObject, name, ref value);
            if (!success)
                throw new GeckoException(String.Format("Could not get property. {0}", name));

            return value;
        }

        public static bool JS_HasProperty(IntPtr cx, IntPtr jsObject, string name)
        {
            bool hasProperty;
            JS_HasProperty(cx, ref jsObject, name, out hasProperty);
            return hasProperty;
        }

      

        public static IntPtr JS_GetPendingException(IntPtr cx)
        {
            var mutableHandle = new MutableHandle();
            return JS_GetPendingException(cx, ref mutableHandle) ? mutableHandle.Handle : IntPtr.Zero;
        }

        public static void JS_RequestLeaveCompartment(IntPtr cx, IntPtr oldCompartment)
        {
            JS_LeaveCompartment(cx, oldCompartment);
            JS_EndRequest(cx);
        }

        public static IntPtr JS_ValueToObject(IntPtr cx, JsVal v)
        {
            var mutableHandle = new MutableHandle();
            JS_ValueToObject(cx, ref v, ref mutableHandle);
            return mutableHandle.Handle;
        }

        public static IntPtr JS_WrapObject(IntPtr cx, IntPtr jsObject)
        {
            var mh = new MutableHandle(jsObject);
            return JS_WrapObject(cx, ref mh) ? mh.Handle : IntPtr.Zero;
        }

        public static IntPtr ToStringSlow(IntPtr cx, JsVal v)
        {
            return ToStringSlow(cx, ref v);
        }

        #endregion

        #region delegates

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate JSBool JSContextCallback(IntPtr cx, UInt32 contextOp);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate void JSErrorReportCallback(IntPtr cx, string message, IntPtr report);

        #endregion

        #region Helper Classes

        /// <summary>
        /// Converts a array of JsVal into Handle (Ptr) to ValueArray.
        /// </summary>
        private class HandleValueArray : IDisposable
        {
            public HandleValueArray(int length, JsVal[] args)
            {
                _length = length;
                _args = args;
            }

            private int _length;
            private JsVal[] _args;
            private IntPtr _ptr;

            public IntPtr Ptr
            {
                get
                {
                    if (_ptr == IntPtr.Zero)
                        _ptr = CopyToNativeMemory();

                    return _ptr;
                }
            }

            /// <summary>
            /// Allocates enough memory for contents of HandleValueArray.
            /// and copies content across.
            /// Must call FreeNativeMemory on the returned pointer.
            /// </summary>
            /// <returns></returns>
            private IntPtr CopyToNativeMemory()
            {
                // Length is 4 bytes on 32bit systems and 8 bytes on 64bit systems.
                IntPtr ptr = Marshal.AllocCoTaskMem(IntPtr.Size + IntPtr.Size);
                Marshal.WriteIntPtr(ptr, 0, new IntPtr(_length));
                IntPtr arrayPtr = Marshal.AllocCoTaskMem(8 * _length);
                Marshal.WriteIntPtr(ptr, IntPtr.Size, arrayPtr);
                for (int i = 0; i < _length; i++)
                    Marshal.StructureToPtr(_args[i], new IntPtr(arrayPtr.ToInt64() + (i * 8)), true);

                return ptr;
            }

            private void FreeNativeMemory(IntPtr ptr)
            {
                var p = Marshal.ReadIntPtr(ptr, IntPtr.Size);
                Marshal.FreeCoTaskMem(p);
                Marshal.FreeCoTaskMem(ptr);
            }

            public void Dispose()
            {
                if (_ptr != IntPtr.Zero)
                    FreeNativeMemory(_ptr);
                _length = -1;
            }
        }

        #endregion

        #region helper methods

        private static string EncodeUnicodeScript(string script)
        {
            int i;
            for (i = 0; i < script.Length && script[i] < 128; i++) ;
            if (i == script.Length)
                return script;
            var sb = new System.Text.StringBuilder();
            if (i > 0)
                sb.Append(script.Substring(0, i));
            for (; i < script.Length; i++)
            {
                char c = script[i];
                if (c < 128)
                    sb.Append(c);
                else
                {
                    sb.Append("\\u");
                    sb.Append(((int) c).ToString("X4"));
                }
            }
            return sb.ToString();
        }

        private static Dictionary<IntPtr, IntPtr> ContextToCompileOptionsMap = new Dictionary<IntPtr, IntPtr>();

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        private static extern IntPtr NewCompileOptions(IntPtr context);

        private static IntPtr GetCompileOptions(IntPtr context)
        {

            IntPtr compileOptions;
            if (!ContextToCompileOptionsMap.TryGetValue(context, out compileOptions))
            {

                compileOptions = NewCompileOptions(context);
                ContextToCompileOptionsMap[context] = compileOptions;
            }

            return compileOptions;        
        }

#endregion

#region Windows x86

        // These should be in Alphabetical order.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CurrentGlobalOrNull(IntPtr aJSContext);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetGlobalForObjectCrossCompartment(IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsObjectInContextCompartment(IntPtr jsObject, IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_BeginRequest(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_CompileUCScript(IntPtr cx, [MarshalAs(UnmanagedType.LPWStr)] string str, int strlen, IntPtr compileOptions,
            ref MutableHandle jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_CallFunctionName(IntPtr cx, ref IntPtr jsObject, string name, IntPtr data,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_CallFunctionName(IntPtr cx, ref IntPtr jsObject, string name, ref int args,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_CallFunctionValue(IntPtr cx, IntPtr jsObject, ref JsVal fval,
            IntPtr passZero, ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_EncodeStringToUTF8(IntPtr cx, ref IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_EndRequest(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_EnterCompartment(IntPtr cx, IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_ExecuteScript(IntPtr cx, ref IntPtr handleScript,
            ref MutableHandleValue jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool ToJSValue(IntPtr cx, [MarshalAs(UnmanagedType.LPWStr)] string str,
            ref MutableJSVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]        
        internal static extern IntPtr ToString(IntPtr cx, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JS_Free(IntPtr cx, IntPtr p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_GetClass(IntPtr obj);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr JS_GetClassObject(IntPtr context, IntPtr proto, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_GetCompartmentPrincipals(IntPtr jsCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_ContextIterator(IntPtr rt, ref IntPtr iterp);

        // if JSOPTION_public_IS_NSISUPPORTS is set on the runtime then Contextpublic should contain the nsISupports object.
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_GetContextpublic(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern JsVal JS_GetEmptyStringValue(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_GetGlobalForObject(IntPtr aJSContext, IntPtr jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JS_LeaveCompartment(IntPtr cx, IntPtr oldCompartment);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool JS_GetProperty(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern int JS_GetStringLength(IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern int JS_GetStringEncodingLength(IntPtr cx, IntPtr jsString);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool JS_HasProperty(IntPtr cx, ref IntPtr jsObject, string name,
            [MarshalAs(UnmanagedType.U1)] out bool found);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern JsVal JS_GetNegativeInfinityValue(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_GetPendingException(IntPtr cx, ref MutableHandle handle);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_NewPlainObject(IntPtr cx);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_NewStringCopyN(IntPtr cx, string str, int length);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JS_SetCompartmentPrincipals(IntPtr jsCompartment, IntPtr principals);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JS_SetContextpublic(IntPtr context, IntPtr data);

#if PORTFF60
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern JSErrorReportCallback JS_SetErrorReporter(IntPtr runtime,
            JSErrorReportCallback callback);
#endif

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool JS_SetProperty(IntPtr cx, ref IntPtr jsObject, string name, ref JsVal jsValue);

#if PORTFF60
        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern void JS_SetTrustedPrincipals(IntPtr runtime, IntPtr principals);
#endif

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern JSType JS_TypeOfValue(IntPtr cx, ref JsVal jsVal);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_ValueToObject(IntPtr cx, ref JsVal jsValue, ref MutableHandle jsObject);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr JS_GetRuntime(IntPtr context);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool JS_WrapObject(IntPtr cx, ref MutableHandle p);

        [DllImport("xul", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ToStringSlow(IntPtr cx, ref JsVal v);

#endregion
    }
}
