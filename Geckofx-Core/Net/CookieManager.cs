using System;
using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko
{
    public static class CookieManager
    {
        private static ComPtr<nsICookieManager> _cookieManager;

        static CookieManager()
        {
            _cookieManager = Xpcom.GetService2<nsICookieManager>(Contracts.CookieManager);
        }

        public static void Add(string host, string path, string name, string value, bool isSecure, bool isHttpOnly,
            bool isSession, long expiry)
        {
            var unused = JsVal.FromDouble(0);
            _cookieManager.Instance.Add(
                new nsAUTF8String(host),
                new nsAUTF8String(path),
                new nsACString(name),
                new nsACString(value),
                isSecure,
                isHttpOnly,
                isSession,
                expiry, ref unused, 0, IntPtr.Zero, 0);
        }

        public static bool CookieExists(Cookie cookie)
        {
            throw new NotImplementedException("CookieExists requires specifying origin");
            var unused = JsVal.FromDouble(0);
            return _cookieManager.Instance.CookieExists(cookie._cookie, unused, IntPtr.Zero, 0);
        }

        public static int CountCookiesFromHost(string host)
        {
            // int is big for cookie count :)
            return (int)_cookieManager.Instance.CountCookiesFromHost(new nsAUTF8String(host));            
        }

        public static IEnumerator<Cookie> GetCookiesFromHost(string host)
        {
            var unused = JsVal.FromDouble(0);
            return
                new Collections.GeckoEnumerator<Cookie, nsICookie2>(
                    _cookieManager.Instance.GetCookiesFromHost(new nsAUTF8String(host), unused, IntPtr.Zero, 0),
                    x => x != null ? new Cookie(x) : null);
        }

        public static IEnumerator<Cookie> GetEnumerator()
        {
            return new Collections.GeckoEnumerator<Cookie, nsICookie2>(_cookieManager.Instance.GetEnumeratorAttribute(),
                x => new Cookie(x));            
        }

        public static void ImportCookies(string filename)
        {
            _cookieManager.Instance.ImportCookies((nsIFile)Xpcom.NewNativeLocalFile(filename));            
        }

        public static void Remove(string host, string name, string path, bool blocked)
        {
            var unused = JsVal.FromDouble(0);
            _cookieManager.Instance.Remove(new nsAUTF8String(host),
                new nsACString(name),
                new nsAUTF8String(path),
                blocked, ref unused, IntPtr.Zero, 4);
        }

        public static void RemoveAll()
        {
            _cookieManager.Instance.RemoveAll();            
        }
    }


    public sealed class Cookie
    {
        internal nsICookie2 _cookie;

        internal Cookie(nsICookie2 cookie)
        {
            _cookie = cookie;
        }

        public long CreationTime => _cookie.GetCreationTimeAttribute();

        public long Expiry => _cookie.GetExpiryAttribute();

        public string Host => nsString.Get(_cookie.GetHostAttribute);

        public bool IsDomain => _cookie.GetIsDomainAttribute();

        public bool IsHttpOnly => _cookie.GetIsHttpOnlyAttribute();

        public bool IsSecure => _cookie.GetIsSecureAttribute();

        public bool IsSession => _cookie.GetIsSessionAttribute();

        public long LastAccessed => _cookie.GetLastAccessedAttribute();

        public string Name => nsString.Get(_cookie.GetNameAttribute);

        public string Path => nsString.Get(_cookie.GetPathAttribute);

        public string RawHost => nsString.Get(_cookie.GetRawHostAttribute);

        public string Value => nsString.Get(_cookie.GetValueAttribute);
    }
}