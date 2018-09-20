using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using NUnit.Framework;

namespace GeckofxUnitTests.dom
{
    abstract class BaseElementWrapperTests
    {
        protected GeckoWebBrowser _browser;
        protected Form _form;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            _form = new Form();
            _browser = new GeckoWebBrowser();
            _browser.Dock = DockStyle.Fill;
            _form.Controls.Add(_browser);
            _form.Show();
            var unused = _browser.Handle;
            Assert.IsNotNull(_browser);
        }

        [TearDown]
        public void AfterEachTest()
        {
            _browser.Dispose();
            _form.Dispose();
        }
    }
}
