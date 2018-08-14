using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    abstract class BaseElementWrapperTests
    {
        protected GeckoWebBrowser _browser;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            _browser = new GeckoWebBrowser();
            var unused = _browser.Handle;
            Assert.IsNotNull(_browser);
        }
    }
}
