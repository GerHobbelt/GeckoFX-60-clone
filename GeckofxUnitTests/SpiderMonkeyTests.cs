using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using Gecko;

namespace GeckofxUnitTests
{
	[TestFixture]
	public class SpiderMonkeyTests
	{
	    private GeckoWebBrowser _gwb;

		[SetUp]
		public void BeforeEachTestSetup()
		{
		    _gwb = new GeckoWebBrowser();
		    _gwb.CreateControl();

		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
		}

		/// <summary>
		/// Unittest helper method to create a String JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateStringJsVal(GeckoWindow window, string value)
		{			
			string jscript = String.Format("'{0}';", value);
			return CreateJsVal(window, jscript);	
		}

		internal static JsVal CreateStringJsVal(GeckoWindow window, AutoJSContext context, string value)
		{
			string jscript = String.Format("'{0}';", value);
			return CreateJsVal(window, context, jscript);
		}

		/// <summary>
		/// Unittest helper method to create a Number JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateNumberJsVal(GeckoWindow window, int value)
		{			
			string jscript = String.Format("{0};", value);
			return CreateJsVal(window, jscript);
		}

		/// <summary>
		/// Unittest helper method to create a bool JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static JsVal CreateBoolJsVal(GeckoWindow window, bool value)
		{
			string jscript = String.Format("{0};", value ? "true" : "false");
			return CreateJsVal(window, jscript);
		}

		/// <summary>
		/// Unittest helper method to create a String JsVal
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static JsVal CreateJsVal(GeckoWindow window, string jscript)
		{
			using (AutoJSContext cx = new AutoJSContext(window))
			{				
				return CreateJsVal(window, cx, jscript);
			}
		}

		private static JsVal CreateJsVal(GeckoWindow window, AutoJSContext cx, string jscript)
		{
			if (cx == null)
				return CreateJsVal(window, jscript);

			var ptr = new JsVal();
			bool ret = SpiderMonkey.JS_EvaluateScript(cx.ContextPointer, jscript, (uint)jscript.Length, "script", 1, ref ptr);
			Assert.IsTrue(ret);
			return ptr;
		}

		[Test]
		public void JS_TypeOfValue()
		{
			if (Xpcom.IsLinux && IntPtr.Size == 8)
				Assert.Ignore("unsafe test:seg faults on 64bit Linux");

            using (AutoJSContext cx = new AutoJSContext(_gwb.Window))
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0)));
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0xffff0000ffffffff)));
				Assert.AreEqual(JSType.JSTYPE_XML, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, JsVal.FromPtr(0xffffffffffffffff)));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnStringJsValCreatedBySpiderMonkey_ReturnsTypeString()
		{

			var jsVal = CreateStringJsVal(_gwb.Window, "hello world");
            using (AutoJSContext cx = new AutoJSContext(_gwb.Window))
			{
				Assert.AreEqual(JSType.JSTYPE_STRING, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnNumberJsValCreatedBySpiderMonkey_ReturnsTypeNumber()
		{

			var jsVal = CreateNumberJsVal(_gwb.Window, 100);
            using (AutoJSContext cx = new AutoJSContext(_gwb.Window))
			{
				Assert.AreEqual(JSType.JSTYPE_NUMBER, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_TypeOfValue_OnBoolJsValCreatedBySpiderMonkey_ReturnsTypeBool()
		{
			var jsVal = CreateBoolJsVal(_gwb.Window, true);
            using (AutoJSContext cx = new AutoJSContext(_gwb.Window))
			{
				Assert.AreEqual(JSType.JSTYPE_BOOLEAN, SpiderMonkey.JS_TypeOfValue(cx.ContextPointer, jsVal));
			}
		}

		[Test]
		public void JS_NewStringCopyN()
		{
            using (AutoJSContext cx = new AutoJSContext(_gwb.Window))
			{
				IntPtr jsString = SpiderMonkey.JS_NewStringCopyN(cx.ContextPointer, "hello world", 11);
				Assert.NotNull(jsString);

				IntPtr str = SpiderMonkey.JS_EncodeString(cx.ContextPointer, jsString);
				string result = Marshal.PtrToStringAnsi(str);
				Assert.AreEqual("hello world", result);
			}
		}

	    private static IntPtr TestString(IntPtr c)
	    {
            return SpiderMonkey.JS_NewStringCopyN(c, "", 0);
        }

        /// <summary>
        /// Please keep these in alphabetical order.
        /// </summary>
        /// <returns></returns>
		public IEnumerable<KeyValuePair<string, Action<IntPtr, IntPtr>>> EntryPoints()
		{
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("CurrentGlobalOrNull", (c, j) => SpiderMonkey.CurrentGlobalOrNull(c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("GetGlobalForObjectCrossCompartment", (c, j) => SpiderMonkey.GetGlobalForObjectCrossCompartment(j));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("IsObjectInContextCompartment", (c, j) => SpiderMonkey.IsObjectInContextCompartment(j, c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_BeginRequest", (c, j) => SpiderMonkey.JS_BeginRequest(c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_CallFunctionName", (c, j) => SpiderMonkey.JS_CallFunctionName(c, j, "", new JsVal[0]));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_CallFunctionValue", (c, j) => SpiderMonkey.JS_CallFunctionValue(c, j, new JsVal()));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_EncodeString", (c, j) => SpiderMonkey.JS_EncodeString(c, TestString(c)));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_EndRequest", (c, j) => SpiderMonkey.JS_EndRequest(c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_EnterCompartment", (c, j) => SpiderMonkey.JS_EnterCompartment(c, j));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_ExecuteScript", (c, j) => { JsVal val; SpiderMonkey.JS_ExecuteScript(c, "", out val); });
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_Free", (c, j) => SpiderMonkey.JS_Free(c, IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetClass", (c, j) => SpiderMonkey.JS_GetClass(j));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetClassObject", (c, j) => SpiderMonkey.JS_GetClassObject(c, IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetCompartmentPrincipals", (c, j) => SpiderMonkey.JS_GetCompartmentPrincipals(c));
#if PORTFF60
            // unstable
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetEmptyStringValue", (c,j) => SpiderMonkey.JS_GetEmptyStringValue(c));
#endif
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetGlobalForObject", (c, j) => SpiderMonkey.JS_GetGlobalForObject(c, j));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetProperty", (c, j) => SpiderMonkey.JS_GetProperty(c, j, ""));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetStringLength", (c, j) => SpiderMonkey.JS_GetStringLength(TestString(c)));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetStringEncodingLength", (c, j) => SpiderMonkey.JS_GetStringEncodingLength(c, TestString(c)));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_HasProperty", (c, j) => SpiderMonkey.JS_HasProperty(c, j, ""));
#if PORTFF60
            // unstable
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetNegativeInfinityValue", (c, j) => SpiderMonkey.JS_GetNegativeInfinityValue(c));
#endif
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetPendingException", (c, j) => SpiderMonkey.JS_GetPendingException(c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_LeaveCompartment", (c, j) => SpiderMonkey.JS_LeaveCompartment(c, IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_NewPlainObject", (c, j) => SpiderMonkey.JS_NewPlainObject(c));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_NewStringCopyN", (c, j) => SpiderMonkey.JS_NewStringCopyN(c, "", 0));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_SetCompartmentPrincipals", (c, j) => SpiderMonkey.JS_SetCompartmentPrincipals(c, IntPtr.Zero));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_SetProperty", (c, j) => SpiderMonkey.JS_SetProperty(c, j, "", new JsVal()));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_TypeOfValue", (c, j) => SpiderMonkey.JS_TypeOfValue(c, default(JsVal)));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_ValueToObject", (c, j) => SpiderMonkey.JS_ValueToObject(c, default(JsVal)));
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_WrapObject", (c, j) => SpiderMonkey.JS_WrapObject(c, j));
#if PORTFF60
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("ToStringSlow", (c,j) => SpiderMonkey.ToStringSlow(IntPtr.Zero, default(JsVal)));
#endif
            yield return new KeyValuePair<string, Action<IntPtr, IntPtr>>("JS_GetRuntime", (c,j) => SpiderMonkey.JS_GetRuntime(c));
		}

		[Test]
        [Platform(Exclude="Linux", Reason = "Crashes on Linux")]
		public void SpiderMonkeyEntryPointTests()
		{
		    foreach (var entryPoint in EntryPoints())
		    {
		        using (var dummy = new GeckoWebBrowser())
                {
		            dummy.CreateControl();
		            var dummyHandle = dummy.Handle;

		            // Try us around the using because, AutoJSContext can throw exception caused by the junk arguments we pass to EntryPoints.
		            try
		            {
                        using (var cx = new AutoJSContext(dummy.Window))
		                {
		                    entryPoint.Value(cx.ContextPointer, SpiderMonkey.CurrentGlobalOrNull(cx.ContextPointer));
		                }
		            }
		            catch (Exception e)
		            {
		                if (e is EntryPointNotFoundException)
		                    Assert.Fail(String.Format("{0}:{1} EntryPoint is wrong: {2}", entryPoint.Value, entryPoint.Key,
		                        e.Message));
		            }
		        }
		    }
		}

	}
}
