namespace Gecko.WebIDL
{
    using System;
    
    
    public class TestInterfaceJS : WebIDLBase
    {
        
        public TestInterfaceJS(mozIDOMWindowProxy globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object AnyArg
        {
            get
            {
                return this.GetProperty<object>("anyArg");
            }
        }
        
        public object ObjectArg
        {
            get
            {
                return this.GetProperty<object>("objectArg");
            }
        }
        
        public object DictionaryArg
        {
            get
            {
                return this.GetProperty<object>("dictionaryArg");
            }
        }
        
        public object AnyAttr
        {
            get
            {
                return this.GetProperty<object>("anyAttr");
            }
            set
            {
                this.SetProperty("anyAttr", value);
            }
        }
        
        public object ObjectAttr
        {
            get
            {
                return this.GetProperty<object>("objectAttr");
            }
            set
            {
                this.SetProperty("objectAttr", value);
            }
        }
        
        public object DictionaryAttr
        {
            get
            {
                return this.GetProperty<object>("dictionaryAttr");
            }
            set
            {
                this.SetProperty("dictionaryAttr", value);
            }
        }
        
        public short CachedAttr
        {
            get
            {
                return this.GetProperty<short>("cachedAttr");
            }
        }
        
        public object PingPongAny(object arg)
        {
            return this.CallMethod<object>("pingPongAny", arg);
        }
        
        public object PingPongObject(object obj)
        {
            return this.CallMethod<object>("pingPongObject", obj);
        }
        
        public object PingPongObjectOrString(WebIDLUnion<System.Object,System.String> objOrString)
        {
            return this.CallMethod<object>("pingPongObjectOrString", objOrString);
        }
        
        public object PingPongDictionary()
        {
            return this.CallMethod<object>("pingPongDictionary");
        }
        
        public object PingPongDictionary(object dict)
        {
            return this.CallMethod<object>("pingPongDictionary", dict);
        }
        
        public int PingPongDictionaryOrLong()
        {
            return this.CallMethod<int>("pingPongDictionaryOrLong");
        }
        
        public int PingPongDictionaryOrLong(WebIDLUnion<System.Object,System.Int32> dictOrLong)
        {
            return this.CallMethod<int>("pingPongDictionaryOrLong", dictOrLong);
        }
        
        public string PingPongMap(Tuple<System.String,System.Object> map)
        {
            return this.CallMethod<string>("pingPongMap", map);
        }
        
        public int ObjectSequenceLength(object[] seq)
        {
            return this.CallMethod<int>("objectSequenceLength", seq);
        }
        
        public int AnySequenceLength(object[] seq)
        {
            return this.CallMethod<int>("anySequenceLength", seq);
        }
        
        public string GetCallerPrincipal()
        {
            return this.CallMethod<string>("getCallerPrincipal");
        }
        
        public string ConvertSVS(USVString svs)
        {
            return this.CallMethod<string>("convertSVS", svs);
        }
        
        public WebIDLUnion<nsISupports,System.Int32> PingPongUnion(WebIDLUnion<nsISupports,System.Int32> something)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,System.Int32>>("pingPongUnion", something);
        }
        
        public WebIDLUnion<System.String,nsISupports> PingPongUnionContainingNull(WebIDLUnion<nsISupports,System.String> something)
        {
            return this.CallMethod<WebIDLUnion<System.String,nsISupports>>("pingPongUnionContainingNull", something);
        }
        
        public WebIDLUnion<nsISupports,System.Int32> PingPongNullableUnion(WebIDLUnion<nsISupports,System.Int32> something)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,System.Int32>>("pingPongNullableUnion", something);
        }
        
        public WebIDLUnion<nsIDOMLocation,nsISupports> ReturnBadUnion()
        {
            return this.CallMethod<WebIDLUnion<nsIDOMLocation,nsISupports>>("returnBadUnion");
        }
        
        public void SetCachedAttr(short n)
        {
            this.CallVoidMethod("setCachedAttr", n);
        }
        
        public void ClearCachedAttrCache()
        {
            this.CallVoidMethod("clearCachedAttrCache");
        }
        
        public void TestSequenceOverload(string[] arg)
        {
            this.CallVoidMethod("testSequenceOverload", arg);
        }
        
        public void TestSequenceOverload(string arg)
        {
            this.CallVoidMethod("testSequenceOverload", arg);
        }
        
        public void TestSequenceUnion(WebIDLUnion<System.String[],System.String> arg)
        {
            this.CallVoidMethod("testSequenceUnion", arg);
        }
        
        public void TestThrowError()
        {
            this.CallVoidMethod("testThrowError");
        }
        
        public void TestThrowDOMException()
        {
            this.CallVoidMethod("testThrowDOMException");
        }
        
        public void TestThrowTypeError()
        {
            this.CallVoidMethod("testThrowTypeError");
        }
        
        public void TestThrowXraySelfHosted()
        {
            this.CallVoidMethod("testThrowXraySelfHosted");
        }
        
        public void TestThrowSelfHosted()
        {
            this.CallVoidMethod("testThrowSelfHosted");
        }
        
        public Promise TestPromiseWithThrowingChromePromiseInit()
        {
            return this.CallMethod<Promise>("testPromiseWithThrowingChromePromiseInit");
        }
        
        public Promise TestPromiseWithDOMExceptionThrowingPromiseInit()
        {
            return this.CallMethod<Promise>("testPromiseWithDOMExceptionThrowingPromiseInit");
        }
        
        public Promise TestPromiseWithThrowingChromeThenFunction()
        {
            return this.CallMethod<Promise>("testPromiseWithThrowingChromeThenFunction");
        }
        
        public Promise TestPromiseWithDOMExceptionThrowingThenFunction()
        {
            return this.CallMethod<Promise>("testPromiseWithDOMExceptionThrowingThenFunction");
        }
        
        public Promise TestPromiseWithThrowingChromeThenable()
        {
            return this.CallMethod<Promise>("testPromiseWithThrowingChromeThenable");
        }
        
        public Promise TestPromiseWithThrowingContentThenable(object thenable)
        {
            return this.CallMethod<Promise>("testPromiseWithThrowingContentThenable", thenable);
        }
        
        public Promise TestPromiseWithDOMExceptionThrowingThenable()
        {
            return this.CallMethod<Promise>("testPromiseWithDOMExceptionThrowingThenable");
        }
    }
}
