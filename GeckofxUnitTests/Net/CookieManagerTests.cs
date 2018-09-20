using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GeckofxUnitTests.Net
{
    [TestFixture]
    class CookieManagerTests
    {
        [Test]
        public void Add_DoesNotCrash()
        {
            CookieManager.Add("a", "b", "c", "d", true, true, true, long.MaxValue);
        }

        [Test]
        public void Remove_DoesNotCrash()
        {
            CookieManager.Remove("a", "b", "c", false);
        }

        [Test]
        public void RemoveAll_DoesNotCrash()
        {
            CookieManager.RemoveAll();
        }

        [Test]
        public void GetCookiesFromHost_NoCookiesOnHost_ReturnsEmptyCollection()
        {
            var results = CookieManager.GetCookiesFromHost("somehostwithnocookies");
            Assert.IsFalse(results.MoveNext());
            Assert.IsNull(results.Current);
        }

        [Test]
        public void GetCookiesFromHost_HostWithSingleCookie_ReturnsSingleCookie()
        {
            CookieManager.Add("somehost", "b", "c", "d", true, true, true, long.MaxValue);
            var results = CookieManager.GetCookiesFromHost("somehost");
            Assert.IsTrue(results.MoveNext());
            Assert.AreEqual("d", results.Current.Value);
            Assert.IsFalse(results.MoveNext());
        }

        [Test]
        public void CountCookiesFromHost_ReutnrsNumberOfCookiesOnHost()
        {
            CookieManager.Add("myhost", "b", "c", "d", true, true, true, long.MaxValue);
            Assert.AreEqual(1, CookieManager.CountCookiesFromHost("myhost"));
        }

        [Test]
        public void CookieExists_Exists_ThrowsNotImplementedException()
        {
            CookieManager.Add("myhost2", "b", "c", "d", true, true, true, long.MaxValue);
            var results = CookieManager.GetCookiesFromHost("myhost2");
            Assert.IsTrue(results.MoveNext());
            var cookie = results.Current;
            Assert.Throws<NotImplementedException>(() => CookieManager.CookieExists(cookie));
        }
    }
}
