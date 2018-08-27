using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using Gecko.WebIDL;
using NUnit.Framework;

namespace GeckofxUnitTests.webidl
{
    [TestFixture]
    class WebIDLBaseTests
    {
        private GeckoWebBrowser _browser;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            var f = new Form();

            _browser = new GeckoWebBrowser {Dock = DockStyle.Fill};
            f.Controls.Add(_browser);
            f.Show();
        }

        [TearDown]
        public void AfterEachTest()
        {
            _browser.Dispose();
        }

        [TestCase("hello", "hello")]
        [TestCase("h'ell'o", "h'ell'o")]
        [TestCase("h\"ell'o", "h\"ell'o")]
        [TestCase(@"he
llo", @"he
llo")]
        [TestCase("hello \ud81b\udf7e", "hello \ud81b\udf7e")]
        [TestCase(@"hello \x hi", @"hello \x hi")]
        public void SetProperty_VariousValues(string val, string expectedResult)
        {
            _browser.TestLoadHtml("hello world.");
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy) _browser.Window.DomWindow, _browser.Window.DomWindow);

            objectUnderTest.SetProperty("somethingRandom", val);

            Assert.AreEqual(expectedResult, objectUnderTest.GetProperty<string>("somethingRandom"));       
        }

        [Test]
        public void SetProperty_RegresstionTest_DoesNotThrowException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)_browser.Window.DomWindow, _browser.Window.DomWindow);

            objectUnderTest.SetProperty("somethingRandom", _testData);

            Assert.AreEqual(_testData, objectUnderTest.GetProperty<string>("somethingRandom"));
        }

        [Test]
        public void SetProperty_RegresstionTest2_DoesNotThrowException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)_browser.Window.DomWindow, _browser.Window.DomWindow);

            objectUnderTest.SetProperty("somethingRandom", _testData2);

            Assert.AreEqual(_testData2, objectUnderTest.GetProperty<string>("somethingRandom"));
        }

        [Test]
        public void GetProperty_ThatDoesntExist_GetsGeckoException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)_browser.Window.DomWindow, _browser.Window.DomWindow);

            var ex = Assert.Throws<GeckoException>(() => objectUnderTest.GetProperty<string>("propertyDoesNotExists"));
            Assert.AreEqual("Property 'propertyDoesNotExists' of type 'String' does not exist on object", ex.Message);
        }

        [Test]
        public void CallVoidMethod_ThatDoesntExists_GetsGeckoException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)_browser.Window.DomWindow, _browser.Window.DomWindow);

            var ex = Assert.Throws<GeckoException>(() => objectUnderTest.CallVoidMethod("functionDoesNotExist", null));
            Assert.AreEqual("Calling function 'functionDoesNotExist' failed: 'TypeError: undefined is not a function StackTrace: '", ex.Message);
        }

        [Test]
        public void CallVoidMethod_ThatThrowsAnException_GetsGeckoException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)_browser.Window.DomWindow, _browser.Window.DomWindow);
            using (var context = new AutoJSContext(_browser.Window))
            {
                context.EvaluateScript("this.functionThatThrows = function myfunc() { 2+3; someerror(); };");
            }
                var ex = Assert.Throws<GeckoException>(() => objectUnderTest.CallVoidMethod("functionThatThrows", null));
            Assert.AreEqual("Calling function 'functionThatThrows' failed: 'ReferenceError: someerror is not defined StackTrace: myfunc@script:1:52\n'", ex.Message);
        }

        #region TestData

        private readonly string _testData3 =
            @"<div class=""exclude usfm"" xmlns:extensions=""urn:extensions""><span style=""font-size:4pt; line-height:0pt"">﻿</span><span id=""cv1_0"" xmlns:usfmextensions=""urn:usfmextensions"" /><!--usfm:%000A%005Cid%0020MAT%0020%000A%005Crem%0020Converted%0020by%0020KFdB%0020on%0020%0030%0038%200F%002D%0030%0039%200F%002D%0030%0038%000A%005Ch%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Ctoc%0033%0020%0645%062A%000A%005Ctoc%0032%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Ctoc%0031%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Cmt%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Cc%0020%0031%0020%000A%005Cs%0020%0646%0633%0628%0020%064A%0633%0648%0639%0020%0627%0644%0645%0633%064A%062D%000A%005Cr%0020%0028%0644%0648%0033%200F%003A%0032%0033%200F%002D%0033%0038%0029%000A%005Cp%0020--><span id=""cv1_1"" xmlns:usfmextensions=""urn:usfmextensions"">";

        private readonly string _testData2 =
            @"<div class=""exclude usfm"" xmlns:extensions=""urn:extensions""><span style=""font-size:4pt; line-height:0pt"">﻿</span><span id=""cv1_0"" xmlns:usfmextensions=""urn:usfmextensions"" /><!--usfm:%000A%005Cid%0020MAT%0020%000A%005Crem%0020Converted%0020by%0020KFdB%0020on%0020%0030%0038%200F%002D%0030%0039%200F%002D%0030%0038%000A%005Ch%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Ctoc%0033%0020%0645%062A%000A%005Ctoc%0032%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Ctoc%0031%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Cmt%0020%0625%0650%0646%0652%062C%0650%064A%0644%064F%0020%0645%064E%062A%064E%0651%0649%000A%005Cc%0020%0031%0020%000A%005Cs%0020%0646%0633%0628%0020%064A%0633%0648%0639%0020%0627%0644%0645%0633%064A%062D%000A%005Cr%0020%0028%0644%0648%0033%200F%003A%0032%0033%200F%002D%0033%0038%0029%000A%005Cp%0020--><span id=""cv1_1"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0020--></span><!--usfm:%0643%0650%062A%064E%0627%0628%064F%0020%0645%0650%064A%0644%064E%0627%062F%0650--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EAB"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو3‏:23 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A--><div class=""clearFloat note usfm_f usfmModify_"" id=""callee_ID0EGB"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\f </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cf%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_fr"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\fr</span> 1‏.1 </span><span class=""usfm_ft"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\ft</span> سجل نسب</span></span><span class=""exclude marker"" contentEditable=""false"">\f*</span></div></div><!--usfm:%005Cf%002A%00A0%064A%064E%0633%064F%0648%0639%064E%0020%0671%0644%0652%0645%064E%0633%0650%064A%062D%0650%0020%0671%0628%0652%0646%0650%0020%062F%064E%0627%0648%064F%062F%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EQB"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> ص22‏:42؛ مز132‏:11؛ إش11‏:1؛ إر23‏:5؛ يو7‏:42؛ أع2‏:30؛ 13‏:23؛ رو1‏:3</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00A0%0671%0628%0652%0646%0650%0020%0625%0650%0628%0652%0631%0627%0647%0650%064A%0645%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EXB"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تك12‏:3؛ 22‏:18؛ غل3‏:16 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%003A%0020--><span id=""cv1_2"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0020--></span><!--usfm:%0625%0650%0628%0652%0631%0627%0647%0650%064A%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0625%0650%0633%0652%062D%0627%0642%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0ECC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تك21‏:2، 3 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%0625%0650%0633%0652%062D%0627%0642%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0639%0652%0642%064F%0648%0628%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EJC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تك25‏:26 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%064A%064E%0639%0652%0642%064F%0648%0628%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0647%064F%0648%0630%064E%0627--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EQC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تك29‏:35 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00A0%0648%064E%0625%0650%062E%0652%0648%064E%062A%064E%0647%064F%002E%0020--><span id=""cv1_3"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0033%0020--></span><!--usfm:%0648%064E%064A%064E%0647%064F%0648%0630%064E%0627%0020%0648%064E%0644%064E%062F%064E%0020%0641%064E%0627%0631%0650%0635%064E%0020%0648%064E%0632%064E%0627%0631%064E%062D%064E%0020%0645%0650%0646%0652%0020%062B%064E%0627%0645%064E%0627%0631%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0E2C"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تك38‏:27‏-30</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%0641%064E%0627%0631%0650%0635%064F%0020%0648%064E%0644%064E%062F%064E%0020%062D%064E%0635%0652%0631%064F%0648%0646%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0ECD"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> را 4‏:18‏-22؛ 1أخ2‏:5، 9‏-17</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%062D%064E%0635%0652%0631%064F%0648%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0631%064E%0627%0645%064E%002E%0020--><span id=""cv1_4"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0034%0020--></span><!--usfm:%0648%064E%0623%064E%0631%064E%0627%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0639%064E%0645%0650%0651%064A%0646%064E%0627%062F%064E%0627%0628%064E%002E%0020%0648%064E%0639%064E%0645%0650%0651%064A%0646%064E%0627%062F%064E%0627%0628%064F%0020%0648%064E%0644%064E%062F%064E%0020%0646%064E%062D%0652%0634%064F%0648%0646%064E%002E%0020%0648%064E%0646%064E%062D%0652%0634%064F%0648%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%0633%064E%0644%0652%0645%064F%0648%0646%064E%002E%0020--><span id=""cv1_5"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0035%0020--></span><!--usfm:%0648%064E%0633%064E%0644%0652%0645%064F%0648%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%0628%064F%0648%0639%064E%0632%064E%0020%0645%0650%0646%0652%0020%0631%064E%0627%062D%064E%0627%0628%064E%002E%0020%0648%064E%0628%064F%0648%0639%064E%0632%064F%0020%0648%064E%0644%064E%062F%064E%0020%0639%064F%0648%0628%0650%064A%062F%064E%0020%0645%0650%0646%0652%0020%0631%064E%0627%0639%064F%0648%062B%064E--><div class=""clearFloat note usfm_f usfmModify_"" id=""callee_ID0ERD"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\f </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cf%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_fr"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\fr</span> 1‏.5 </span><span class=""usfm_ft"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\ft</span> ع، ي رُوث</span></span><span class=""exclude marker"" contentEditable=""false"">\f*</span></div></div><!--usfm:%005Cf%002A%002E%0020%0648%064E%0639%064F%0648%0628%0650%064A%062F%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0633%064E%0651%0649%002E%0020--><span id=""cv1_6"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0036%0020--></span><!--usfm:%0648%064E%064A%064E%0633%064E%0651%0649%0020%0648%064E%0644%064E%062F%064E%0020%062F%064E%0627%0648%064F%062F%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0E6D"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 1صم16‏:1؛ 17‏:12 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00A0%0671%0644%0652%0645%064E%0644%0650%0643%064E%002E%0020%0648%064E%062F%064E%0627%0648%064F%062F%064F%0020%0671%0644%0652%0645%064E%0644%0650%0643%064F%0020%0648%064E%0644%064E%062F%064E%0020%0633%064F%0644%064E%064A%0652%0645%064E%0627%0646%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EGE"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 2صم12‏:24 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00A0%0645%0650%0646%064E%0020%0671%0644%064E%0651%062A%0650%064A%0020%0644%0650%0623%064F%0648%0631%0650%064A%064E%0651%0627%002E%0020--><span id=""cv1_7"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0037%0020--></span><!--usfm:%0648%064E%0633%064F%0644%064E%064A%0652%0645%064E%0627%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%0631%064E%062D%064E%0628%0652%0639%064E%0627%0645%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0ERE"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 1أخ3‏:10</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%0631%064E%062D%064E%0628%0652%0639%064E%0627%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0628%0650%064A%064E%0651%0627%002E%0020%0648%064E%0623%064E%0628%0650%064A%064E%0651%0627%0020%0648%064E%0644%064E%062F%064E%0020%0622%0633%064E%0627%002E%0020--><span id=""cv1_8"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0038%0020--></span><!--usfm:%0648%064E%0622%0633%064E%0627%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0647%064F%0648%0634%064E%0627%0641%064E%0627%0637%064E%002E%0020%0648%064E%064A%064E%0647%064F%0648%0634%064E%0627%0641%064E%0627%0637%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064F%0648%0631%064E%0627%0645%064E%002E%0020%0648%064E%064A%064F%0648%0631%064E%0627%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0639%064F%0632%0650%0651%064A%064E%0651%0627%002E%0020--><span id=""cv1_9"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0039%0020--></span><!--usfm:%0648%064E%0639%064F%0632%0650%0651%064A%064E%0651%0627%0020%0648%064E%0644%064E%062F%064E%0020%064A%064F%0648%062B%064E%0627%0645%064E%002E%0020%0648%064E%064A%064F%0648%062B%064E%0627%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%062D%064E%0627%0632%064E%002E%0020%0648%064E%0623%064E%062D%064E%0627%0632%064F%0020%0648%064E%0644%064E%062F%064E%0020%062D%0650%0632%0652%0642%0650%064A%064E%0651%0627%002E%0020--><span id=""cv1_10"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0030%0020--></span><!--usfm:%0648%064E%062D%0650%0632%0652%0642%0650%064A%064E%0651%0627%0020%0648%064E%0644%064E%062F%064E%0020%0645%064E%0646%064E%0633%064E%0651%0649--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EEF"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 2مل20‏:21؛ 1أخ3‏:13 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%0645%064E%0646%064E%0633%064E%0651%0649%0020%0648%064E%0644%064E%062F%064E%0020%0622%0645%064F%0648%0646%064E%002E%0020%0648%064E%0622%0645%064F%0648%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064F%0648%0634%0650%064A%064E%0651%0627%002E%0020--><span id=""cv1_11"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0031%0020--></span><!--usfm:%0648%064E%064A%064F%0648%0634%0650%064A%064E%0651%0627%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0643%064F%0646%0652%064A%064E%0627--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EPF"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 1أخ3‏:15، 16 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00A0%0648%064E%0625%0650%062E%0652%0648%064E%062A%064E%0647%064F%0020%0639%0650%0646%0652%062F%064E%0020%0633%064E%0628%0652%064A%0650%0020%0628%064E%0627%0628%0650%0644%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EWF"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 2مل24‏:14‏-16؛ 25‏:11؛ 2أخ36‏:10، 20؛ إر27‏:20؛ 39‏:9؛ 52‏:11، 15، 28‏-30؛ دا 1‏:2</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020--><span id=""cv1_12"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0032%0020--></span><!--usfm:%0648%064E%0628%064E%0639%0652%062F%064E%0020%0633%064E%0628%0652%064A%0650%0020%0628%064E%0627%0628%0650%0644%064E%0020%064A%064E%0643%064F%0646%0652%064A%064E%0627%0020%0648%064E%0644%064E%062F%064E%0020%0634%064E%0623%064E%0644%0652%062A%0650%0626%0650%064A%0644%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EBG"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> 1أخ3‏:17، 19</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%0634%064E%0623%064E%0644%0652%062A%0650%0626%0650%064A%0644%064F%0020%0648%064E%0644%064E%062F%064E%0020%0632%064E%0631%064F%0628%064E%0651%0627%0628%0650%0644%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EIG"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> عز3‏:2؛ 5‏:2؛ نح12‏:1؛ حج1‏:1 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020--><span id=""cv1_13"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0033%0020--></span><!--usfm:%0648%064E%0632%064E%0631%064F%0628%064E%0651%0627%0628%0650%0644%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0628%0650%064A%0647%064F%0648%062F%064E%002E%0020%0648%064E%0623%064E%0628%0650%064A%0647%064F%0648%062F%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0644%0650%064A%064E%0627%0642%0650%064A%0645%064E%002E%0020%0648%064E%0623%064E%0644%0650%064A%064E%0627%0642%0650%064A%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0639%064E%0627%0632%064F%0648%0631%064E%002E%0020--><span id=""cv1_14"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0034%0020--></span><!--usfm:%0648%064E%0639%064E%0627%0632%064F%0648%0631%064F%0020%0648%064E%0644%064E%062F%064E%0020%0635%064E%0627%062F%064F%0648%0642%064E%002E%0020%0648%064E%0635%064E%0627%062F%064F%0648%0642%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%062E%0650%064A%0645%064E%002E%0020%0648%064E%0623%064E%062E%0650%064A%0645%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0644%0650%064A%064F%0648%062F%064E%002E%0020--><span id=""cv1_15"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0035%0020--></span><!--usfm:%0648%064E%0623%064E%0644%0650%064A%064F%0648%062F%064F%0020%0648%064E%0644%064E%062F%064E%0020%0623%064E%0644%0650%064A%0639%064E%0627%0632%064E%0631%064E%002E%0020%0648%064E%0623%064E%0644%0650%064A%0639%064E%0627%0632%064E%0631%064F%0020%0648%064E%0644%064E%062F%064E%0020%0645%064E%062A%064E%0651%0627%0646%064E%002E%0020%0648%064E%0645%064E%062A%064E%0651%0627%0646%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064E%0639%0652%0642%064F%0648%0628%064E%002E%0020--><span id=""cv1_16"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0036%0020--></span><!--usfm:%0648%064E%064A%064E%0639%0652%0642%064F%0648%0628%064F%0020%0648%064E%0644%064E%062F%064E%0020%064A%064F%0648%0633%064F%0641%064E%0020%0631%064E%062C%064F%0644%064E%0020%0645%064E%0631%0652%064A%064E%0645%064E%0020%0671%0644%064E%0651%062A%0650%064A%0020%0648%064F%0644%0650%062F%064E%0020%0645%0650%0646%0652%0647%064E%0627%0020%064A%064E%0633%064F%0648%0639%064F%0020%0671%0644%064E%0651%0630%0650%064A%0020%064A%064F%062F%0652%0639%064E%0649%0020%0671%0644%0652%0645%064E%0633%0650%064A%062D%064E%002E%0020--><span id=""cv1_17"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0037%0020--></span><!--usfm:%0641%064E%062C%064E%0645%0650%064A%0639%064F%0020%0671%0644%0652%0623%064E%062C%0652%064A%064E%0627%0644%0650%0020%0645%0650%0646%0652%0020%0625%0650%0628%0652%0631%0627%0647%0650%064A%0645%064E%0020%0625%0650%0644%064E%0649%0020%062F%064E%0627%0648%064F%062F%064E%0020%0623%064E%0631%0652%0628%064E%0639%064E%0629%064E%0020%0639%064E%0634%064E%0631%064E%0020%062C%0650%064A%0644%064B%0627%060C%0020%0648%064E%0645%0650%0646%0652%0020%062F%064E%0627%0648%064F%062F%064E%0020%0625%0650%0644%064E%0649%0020%0633%064E%0628%0652%064A%0650%0020%0628%064E%0627%0628%0650%0644%064E%0020%0623%064E%0631%0652%0628%064E%0639%064E%0629%064E%0020%0639%064E%0634%064E%0631%064E%0020%062C%0650%064A%0644%064B%0627%060C%0020%0648%064E%0645%0650%0646%0652%0020%0633%064E%0628%0652%064A%0650%0020%0628%064E%0627%0628%0650%0644%064E%0020%0625%0650%0644%064E%0649%0020%0671%0644%0652%0645%064E%0633%0650%064A%062D%0650%0020%0623%064E%0631%0652%0628%064E%0639%064E%0629%064E%0020%0639%064E%0634%064E%0631%064E%0020%062C%0650%064A%0644%064B%0627%002E%000A%005Cs%0020%0645%064A%0644%0627%062F%0020%064A%0633%0648%0639%0020%0627%0644%0645%0633%064A%062D%000A%005Cr%0020%0028%0644%0648%0032%200F%003A%0031%200F%002D%0037%0029%000A%005Cp%0020--><span id=""cv1_18"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0038%0020--></span><!--usfm:%0623%064E%0645%064E%0651%0627%0020%0648%0650%0644%064E%0627%062F%064E%0629%064F%0020%064A%064E%0633%064F%0648%0639%064E%0020%0671%0644%0652%0645%064E%0633%0650%064A%062D%0650%0020%0641%064E%0643%064E%0627%0646%064E%062A%0652%0020%0647%064E%0643%064E%0630%064E%0627--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0ENH"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو1‏:27</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%003A%0020%0644%064E%0645%064E%0651%0627%0020%0643%064E%0627%0646%064E%062A%0652%0020%0645%064E%0631%0652%064A%064E%0645%064F%0020%0623%064F%0645%064F%0651%0647%064F%0020%0645%064E%062E%0652%0637%064F%0648%0628%064E%0629%064B%0020%0644%0650%064A%064F%0648%0633%064F%0641%064E%060C%0020%0642%064E%0628%0652%0644%064E%0020%0623%064E%0646%0652%0020%064A%064E%062C%0652%062A%064E%0645%0650%0639%064E%0627%060C%0020%0648%064F%062C%0650%062F%064E%062A%0652%0020%062D%064F%0628%0652%0644%064E%0649%0020%0645%0650%0646%064E%0020%0671%0644%0631%064F%0651%0648%062D%0650%0020%0671%0644%0652%0642%064F%062F%064F%0633%0650--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EUH"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو1‏:35 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020--><span id=""cv1_19"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0031%0039%0020--></span><!--usfm:%0641%064E%064A%064F%0648%0633%064F%0641%064F%0020%0631%064E%062C%064F%0644%064F%0647%064E%0627%0020%0625%0650%0630%0652%0020%0643%064E%0627%0646%064E%0020%0628%064E%0627%0631%064B%0651%0627%060C%0020%0648%064E%0644%064E%0645%0652%0020%064A%064E%0634%064E%0623%0652%0020%0623%064E%0646%0652%0020%064A%064F%0634%0652%0647%0650%0631%064E%0647%064E%0627%060C%0020%0623%064E%0631%064E%0627%062F%064E%0020%062A%064E%062E%0652%0644%0650%064A%064E%062A%064E%0647%064E%0627%0020%0633%0650%0631%064B%0651%0627--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EAAAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> تث24‏:1 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020--><span id=""cv1_20"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0030%0020--></span><!--usfm:%0648%064E%0644%064E%0643%0650%0646%0652%0020%0641%0650%064A%0645%064E%0627%0020%0647%064F%0648%064E%0020%0645%064F%062A%064E%0641%064E%0643%0650%0651%0631%064C%0020%0641%0650%064A%0020%0647%064E%0630%0650%0647%0650%0020%0671%0644%0652%0623%064F%0645%064F%0648%0631%0650%060C%0020%0625%0650%0630%064E%0627%0020%0645%064E%0644%064E%0627%0643%064F%0020%0671%0644%0631%064E%0651%0628%0650%0651%0020%0642%064E%062F%0652%0020%0638%064E%0647%064E%0631%064E%0020%0644%064E%0647%064F%0020%0641%0650%064A%0020%062D%064F%0644%0652%0645%064D%0020%0642%064E%0627%0626%0650%0644%064B%0627%003A%0020%00AB%064A%064E%0627%0020%064A%064F%0648%0633%064F%0641%064F%0020%0671%0628%0652%0646%064E%0020%062F%064E%0627%0648%064F%062F%064E%060C%0020%0644%064E%0627%0020%062A%064E%062E%064E%0641%0652%0020%0623%064E%0646%0652%0020%062A%064E%0623%0652%062E%064F%0630%064E%0020%0645%064E%0631%0652%064A%064E%0645%064E%0020%0671%0645%0652%0631%064E%0623%064E%062A%064E%0643%064E%002E%0020%0644%0650%0623%064E%0646%064E%0651%0020%0671%0644%064E%0651%0630%0650%064A%0020%062D%064F%0628%0650%0644%064E%0020%0628%0650%0647%0650%0020%0641%0650%064A%0647%064E%0627--><div class=""clearFloat note usfm_f usfmModify_"" id=""callee_ID0ELAAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\f </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cf%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_fr"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\fr</span> 1‏.20 </span><span class=""usfm_ft"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\ft</span> ي المولود فيها</span></span><span class=""exclude marker"" contentEditable=""false"">\f*</span></div></div><!--usfm:%005Cf%002A%00A0%0647%064F%0648%064E%0020%0645%0650%0646%064E%0020%0671%0644%0631%064F%0651%0648%062D%0650%0020%0671%0644%0652%0642%064F%062F%064F%0633%0650--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EVAAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو1‏:35 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020--><span id=""cv1_21"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0031%0020--></span><!--usfm:%0641%064E%0633%064E%062A%064E%0644%0650%062F%064F%0020%0671%0628%0652%0646%064B%0627%0020%0648%064E%062A%064E%062F%0652%0639%064F%0648%0020%0671%0633%0652%0645%064E%0647%064F%0020%064A%064E%0633%064F%0648%0639%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EABAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو1‏:31 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A--><div class=""clearFloat note usfm_f usfmModify_"" id=""callee_ID0EGBAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\f </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cf%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_fr"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\fr</span> 1‏.21 </span><span class=""usfm_ft"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\ft</span> أي مخلِّصًا</span></span><span class=""exclude marker"" contentEditable=""false"">\f*</span></div></div><!--usfm:%005Cf%002A%002E%0020%0644%0650%0623%064E%0646%064E%0651%0647%064F%0020%064A%064F%062E%064E%0644%0650%0651%0635%064F%0020%0634%064E%0639%0652%0628%064E%0647%064F%0020%0645%0650%0646%0652%0020%062E%064E%0637%064E%0627%064A%064E%0627%0647%064F%0645%0652--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EQBAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> أع4‏:12؛ 5‏:31؛ 13‏:23، 38</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%00BB%002E%0020--><span id=""cv1_22"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0032%0020--></span><!--usfm:%0648%064E%0647%064E%0630%064E%0627%0020%0643%064F%0644%064F%0651%0647%064F%0020%0643%064E%0627%0646%064E%0020%0644%0650%0643%064E%064A%0652%0020%064A%064E%062A%0650%0645%064E%0651%0020%0645%064E%0627%0020%0642%0650%064A%0644%064E%0020%0645%0650%0646%064E%0020%0671%0644%0631%064E%0651%0628%0650%0651%0020%0628%0650%0671%0644%0646%064E%0651%0628%0650%064A%0650%0651%0020%0671%0644%0652%0642%064E%0627%0626%0650%0644%0650--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0E2BAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> إش7‏:14 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%003A%0020--><span id=""cv1_23"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0033%0020--></span><!--usfm:%00AB%0647%064F%0648%064E%0630%064E%0627%0020%0671%0644%0652%0639%064E%0630%0652%0631%064E%0627%0621%064F%0020%062A%064E%062D%0652%0628%064E%0644%064F%0020%0648%064E%062A%064E%0644%0650%062F%064F%0020%0671%0628%0652%0646%064B%0627%060C%0020%0648%064E%064A%064E%062F%0652%0639%064F%0648%0646%064E%0020%0671%0633%0652%0645%064E%0647%064F%0020%0639%0650%0645%064E%0651%0627%0646%064F%0648%0626%0650%064A%0644%064E%00BB%0020%0671%0644%064E%0651%0630%0650%064A%0020%062A%064E%0641%0652%0633%0650%064A%0631%064F%0647%064F%003A%0020%0671%0644%0644%0647%064F%0020%0645%064E%0639%064E%0646%064E%0627%002E%000A%005Cp%0020--><span id=""cv1_24"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0034%0020--></span><!--usfm:%0641%064E%0644%064E%0645%064E%0651%0627%0020%0671%0633%0652%062A%064E%064A%0652%0642%064E%0638%064E%0020%064A%064F%0648%0633%064F%0641%064F%0020%0645%0650%0646%064E%0020%0671%0644%0646%064E%0651%0648%0652%0645%0650%0020%0641%064E%0639%064E%0644%064E%0020%0643%064E%0645%064E%0627%0020%0623%064E%0645%064E%0631%064E%0647%064F%0020%0645%064E%0644%064E%0627%0643%064F%0020%0671%0644%0631%064E%0651%0628%0650%0651%060C%0020%0648%064E%0623%064E%062E%064E%0630%064E%0020%0671%0645%0652%0631%064E%0623%064E%062A%064E%0647%064F%002E%0020--><span id=""cv1_25"" xmlns:usfmextensions=""urn:usfmextensions""><!--usfm:%005Cv%0020%0032%0035%0020--></span><!--usfm:%0648%064E%0644%064E%0645%0652%0020%064A%064E%0639%0652%0631%0650%0641%0652%0647%064E%0627%0020%062D%064E%062A%064E%0651%0649%0020%0648%064E%0644%064E%062F%064E%062A%0650%0020%0671%0628%0652%0646%064E%0647%064E%0627%0020%0671%0644%0652%0628%0650%0643%0652%0631%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EQCAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> خر13‏:2؛ لو2‏:7</span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E%0020%0648%064E%062F%064E%0639%064E%0627%0020%0671%0633%0652%0645%064E%0647%064F%0020%064A%064E%0633%064F%0648%0639%064E--><div class=""clearFloat note usfm_x usfmModify_"" id=""callee_ID0EXCAC"" attachmentId="""" attachmentOffset=""""><div class=""leadingFloat""><span class=""marker"">\x </span><span class=""callee notecallee"">+</span> </div><!--usfm:%005Cx%0020%002B%0020--><div class=""include"" contentEditable=""true""><span class=""notetext""><span class=""usfm_xt"" xmlns:usfmextensions=""urn:usfmextensions""><span class=""marker"">\xt</span> لو2‏:21 </span></span><span class=""exclude marker"" contentEditable=""false"">\x*</span></div></div><!--usfm:%005Cx%002A%002E--><span style=""font-size:4pt; line-height:0pt"">﻿</span></div>";

        readonly string _testData = @"body {
}
.leadingFloat
{
float:left;
}
.clearFloat {
 clear:both;
}
.align_start
{
text-align:left;
}
.align_center
{
text-align:center;
}
.align_end
{
text-align:right;
}
.usfm {
 font-family:"""";
 font-size:10pt;
}
.usfm_id { 
 font-size:100%;
 text-align:left;
}

.usfm_ide { 
 font-size:100%;
 text-align:left;
}

.usfm_h { 
 font-size:100%;
 text-align:left;
}

.usfm_h1 { 
 font-size:100%;
 text-align:left;
}

.usfm_h2 { 
 font-size:100%;
 text-align:left;
}

.usfm_h3 { 
 font-size:100%;
 text-align:left;
}

.usfm_toc1 { 
 font-weight:bold;
 color:#004000;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_toc2 { 
 color:#004000;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_toc3 { 
 font-weight:bold;
 color:#800000;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_rem { 
 color:#0000FF;
 font-size:100%;
 text-align:left;
}

.usfm_sts { 
 color:#0000FF;
 font-size:100%;
 text-align:left;
}

.usfm_restore { 
 color:#0000FF;
 font-size:100%;
 text-align:left;
}

.usfm_imt { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_imt1 { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_imt2 { 
 font-size:108%;
 font-style:italic;
 text-align:center;
 margin-bottom:3pt;
 margin-top:6pt;
}

.usfm_imt3 { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:2pt;
 margin-top:2pt;
}

.usfm_imt4 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
 margin-bottom:2pt;
 margin-top:2pt;
}

.usfm_imte { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_imte1 { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_imte2 { 
 font-size:133%;
 font-style:italic;
 text-align:center;
 margin-bottom:2pt;
}

.usfm_is { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_is1 { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_is2 { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_iot { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_io { 
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_io1 { 
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_io2 { 
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
}

.usfm_io3 { 
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_io4 { 
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_ior { 
 font-size:100%;
 text-align:left;
}

.usfm_ip { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
}

.usfm_im { 
 font-size:100%;
 text-align:left;
}

.usfm_ipi { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_imi { 
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_ili { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_ili1 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_ili2 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
}

.usfm_ipq { 
 text-indent:0.125in;
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_imq { 
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_ipr { 
 font-size:100%;
 font-style:italic;
 text-align:right;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_ib { 
 font-size:83%;
 text-align:left;
}

.usfm_iq { 
 text-indent:-0.750in;
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:1.000in;
}

.usfm_iq1 { 
 text-indent:-0.750in;
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:1.000in;
}

.usfm_iq2 { 
 text-indent:-0.500in;
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:1.000in;
}

.usfm_iq3 { 
 text-indent:-0.250in;
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-left:1.000in;
}

.usfm_iex { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-bottom:4pt;
 margin-top:4pt;
}

.usfm_iqt { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_ie { 
 font-size:83%;
 text-align:left;
}

.usfm_c { 
 font-weight:bold;
 font-size:150%;
 text-align:left;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_ca { 
 color:#228B22;
 font-size:133%;
 font-style:italic;
 text-align:left;
}

.usfm_cp { 
 font-weight:bold;
 color:#0000FF;
 font-size:150%;
 text-align:left;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_cl { 
 font-weight:bold;
 font-size:150%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_cd { 
 font-size:91%;
 text-align:left;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_v { 
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
 white-space:nowrap;
 unicode-bidi: embed;
}

.usfm_va { 
 color:#228B22;
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
}

.usfm_vp { 
 color:#0000FF;
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
}

.usfm_p { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
}

.usfm_m { 
 font-size:100%;
 text-align:left;
}

.usfm_pmo { 
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pm { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pmc { 
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pmr { 
 font-size:100%;
 text-align:right;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pi { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pi1 { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_pi2 { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
 margin-right:0.250in;
}

.usfm_pi3 { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
 margin-right:0.250in;
}

.usfm_pc { 
 font-size:100%;
 text-align:center;
}

.usfm_mi { 
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_nb { 
 font-size:100%;
 text-align:left;
}

.usfm_cls { 
 font-size:100%;
 text-align:right;
}

.usfm_q { 
 text-indent:-1.000in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_q1 { 
 text-indent:-1.000in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_q2 { 
 text-indent:-0.750in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_q3 { 
 text-indent:-0.500in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_q4 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_qc { 
 font-size:100%;
 text-align:center;
}

.usfm_qr { 
 font-size:100%;
 text-align:right;
}

.usfm_qs { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_qa { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_qac { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_qm { 
 text-indent:-0.750in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_qm1 { 
 text-indent:-0.750in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_qm2 { 
 text-indent:-0.500in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_qm3 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_b { 
 font-size:83%;
 text-align:left;
}

.usfm_mt { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_mt1 { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:2pt;
}

.usfm_mt2 { 
 font-size:133%;
 font-style:italic;
 text-align:center;
 margin-bottom:2pt;
}

.usfm_mt3 { 
 font-weight:bold;
 font-size:133%;
 text-align:center;
 margin-bottom:2pt;
 margin-top:2pt;
}

.usfm_mt4 { 
 font-size:100%;
 text-align:center;
 margin-bottom:2pt;
 margin-top:2pt;
}

.usfm_mte { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_mte1 { 
 font-weight:bold;
 font-size:166%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_mte2 { 
 font-size:133%;
 font-style:italic;
 text-align:center;
 margin-bottom:2pt;
}

.usfm_ms { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:16pt;
}

.usfm_ms1 { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:16pt;
}

.usfm_ms2 { 
 font-weight:bold;
 font-size:116%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:16pt;
}

.usfm_ms3 { 
 font-size:116%;
 font-style:italic;
 text-align:center;
 margin-bottom:4pt;
 margin-top:16pt;
}

.usfm_mr { 
 font-size:100%;
 font-style:italic;
 text-align:center;
 margin-bottom:4pt;
}

.usfm_s { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_s1 { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_s2 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_s3 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-bottom:3pt;
 margin-top:6pt;
}

.usfm_s4 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-bottom:3pt;
 margin-top:6pt;
}

.usfm_sr { 
 font-weight:bold;
 font-size:100%;
 text-align:center;
 margin-bottom:4pt;
}

.usfm_r { 
 font-size:100%;
 font-style:italic;
 text-align:center;
 margin-bottom:4pt;
}

.usfm_sp { 
 font-size:100%;
 font-style:italic;
 text-align:left;
 margin-bottom:4pt;
 margin-top:8pt;
}

.usfm_d { 
 font-size:100%;
 font-style:italic;
 text-align:center;
 margin-bottom:4pt;
 margin-top:4pt;
}

.usfm_tr { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_th1 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_th2 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_th3 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_th4 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_th5 { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_tc1 { 
 font-size:100%;
 text-align:left;
}

.usfm_tc2 { 
 font-size:100%;
 text-align:left;
}

.usfm_tc3 { 
 font-size:100%;
 text-align:left;
}

.usfm_tc4 { 
 font-size:100%;
 text-align:left;
}

.usfm_tc5 { 
 font-size:100%;
 text-align:left;
}

.usfm_thc1 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
}

.usfm_thc2 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
}

.usfm_thc3 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
}

.usfm_thc4 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
}

.usfm_thc5 { 
 font-size:100%;
 font-style:italic;
 text-align:center;
}

.usfm_tcc1 { 
 font-size:100%;
 text-align:center;
}

.usfm_tcc2 { 
 font-size:100%;
 text-align:center;
}

.usfm_tcc3 { 
 font-size:100%;
 text-align:center;
}

.usfm_tcc4 { 
 font-size:100%;
 text-align:center;
}

.usfm_tcc5 { 
 font-size:100%;
 text-align:center;
}

.usfm_thr1 { 
 font-size:100%;
 font-style:italic;
 text-align:right;
}

.usfm_thr2 { 
 font-size:100%;
 font-style:italic;
 text-align:right;
}

.usfm_thr3 { 
 font-size:100%;
 font-style:italic;
 text-align:right;
}

.usfm_thr4 { 
 font-size:100%;
 font-style:italic;
 text-align:right;
}

.usfm_thr5 { 
 font-size:100%;
 font-style:italic;
 text-align:right;
}

.usfm_tcr1 { 
 font-size:100%;
 text-align:right;
}

.usfm_tcr2 { 
 font-size:100%;
 text-align:right;
}

.usfm_tcr3 { 
 font-size:100%;
 text-align:right;
}

.usfm_tcr4 { 
 font-size:100%;
 text-align:right;
}

.usfm_tcr5 { 
 font-size:100%;
 text-align:right;
}

.usfm_li { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_li1 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_li2 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
}

.usfm_li3 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_li4 { 
 text-indent:-0.375in;
 font-size:100%;
 text-align:left;
 margin-left:1.250in;
}

.usfm_f { 
 font-size:100%;
 text-align:left;
}

.usfm_fe { 
 font-size:100%;
 text-align:left;
}

.usfm_fr { 
 font-weight:bold;
 font-size:100%;
 text-align:left;
}

.usfm_ft { 
 font-size:100%;
 text-align:left;
}

.usfm_fk { 
 font-weight:bold;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_fq { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_fqa { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_fl { 
 font-weight:bold;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_fp { 
 font-size:100%;
 text-align:left;
}

.usfm_fv { 
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
}

.usfm_fdc { 
 font-size:100%;
 text-align:left;
}

.usfm_fm { 
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
}

.usfm_x { 
 font-size:100%;
 text-align:left;
}

.usfm_xo { 
 font-weight:bold;
 font-size:100%;
 text-align:left;
}

.usfm_xt { 
 font-size:100%;
 text-align:left;
}

.usfm_xk { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_xq { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_xot { 
 font-size:100%;
 text-align:left;
}

.usfm_xnt { 
 font-size:100%;
 text-align:left;
}

.usfm_xdc { 
 font-size:100%;
 text-align:left;
}

.usfm_rq { 
 font-size:83%;
 font-style:italic;
 text-align:left;
}

.usfm_qt { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_nd { 
 font-size:100%;
 text-align:left;
 text-decoration:underline;
}

.usfm_tl { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_dc { 
 font-style:italic;
 text-align:left;
}

.usfm_bk { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_sig { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_pn { 
 font-weight:bold;
 font-size:100%;
 text-align:left;
 text-decoration:underline;
}

.usfm_addpn { 
 font-weight:bold;
 font-size:100%;
 font-style:italic;
 text-align:left;
 text-decoration:underline;
}

.usfm_wj { 
 color:#FF0000;
 font-size:100%;
 text-align:left;
}

.usfm_k { 
 font-weight:bold;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_sls { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_ord { 
 font-size:100%;
 text-align:left;
 vertical-align: text-top;
 font-size: 66%;
}

.usfm_add { 
 font-weight:bold;
 font-style:italic;
 text-align:left;
}

.usfm_lit { 
 font-weight:bold;
 font-size:100%;
 text-align:right;
}

.usfm_no { 
 font-size:100%;
 text-align:left;
}

.usfm_it { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_bd { 
 font-weight:bold;
 font-size:100%;
 text-align:left;
}

.usfm_bdit { 
 font-weight:bold;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_em { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_sc { 
 font-size:100%;
 font-variant: small-caps;
 text-align:left;
}

.usfm_pb { 
 font-size:100%;
 text-align:left;
}

.usfm_fig { 
 font-size:100%;
 text-align:left;
}

.usfm_pro { 
 font-size:83%;
 text-align:left;
}

.usfm_w { 
 font-size:100%;
 text-align:left;
}

.usfm_wh { 
 font-size:100%;
 text-align:left;
}

.usfm_wg { 
 font-size:100%;
 text-align:left;
}

.usfm_ndx { 
 font-size:100%;
 text-align:left;
}

.usfm_periph { 
 font-weight:bold;
 color:#FF8000;
 font-size:116%;
 text-align:left;
 margin-bottom:4pt;
 margin-top:16pt;
}

.usfm_p1 { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
}

.usfm_p2 { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.125in;
}

.usfm_k1 { 
 font-size:100%;
 text-align:left;
}

.usfm_k2 { 
 font-size:100%;
 text-align:left;
}

.usfm_xtSee { 
 color:#0000FF;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_xtSeeAlso { 
 color:#0000FF;
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_pr { 
 font-size:100%;
 text-align:right;
}

.usfm_ph { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_ph1 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_ph2 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
}

.usfm_ph3 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:1.000in;
}

.usfm_phi { 
 text-align:left;
 margin-left:1.000in;
}

.usfm_tr1 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.500in;
}

.usfm_tr2 { 
 text-indent:-0.250in;
 font-size:100%;
 text-align:left;
 margin-left:0.750in;
}

.usfm_ps { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
}

.usfm_psi { 
 text-indent:0.125in;
 font-size:100%;
 text-align:left;
 margin-left:0.250in;
 margin-right:0.250in;
}

.usfm_fs { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_wr { 
 font-size:100%;
 font-style:italic;
 text-align:left;
}

.usfm_pub { 
 font-size:83%;
 text-align:left;
}

.usfm_toc { 
 font-size:83%;
 text-align:left;
}

.usfm_pref { 
 font-size:83%;
 text-align:left;
}

.usfm_intro { 
 font-size:83%;
 text-align:left;
}

.usfm_conc { 
 font-size:83%;
 text-align:left;
}

.usfm_glo { 
 font-size:83%;
 text-align:left;
}

.usfm_idx { 
 font-size:83%;
 text-align:left;
}

.usfm_maps { 
 font-size:83%;
 text-align:left;
}

.usfm_cov { 
 font-size:83%;
 text-align:left;
}

.usfm_spine { 
 font-size:83%;
 text-align:left;
}

.usfm_pubinfo { 
 color:#0000FF;
 font-size:100%;
 text-align:left;
}

.usfm_zpa-xb { 
 font-size:100%;
 text-align:left;
}

.usfm_zpa-xc { 
 font-weight:bold;
 font-size:100%;
 text-align:left;
}

.usfm_zpa-xv { 
 font-size:100%;
 text-align:left;
}

.usfm_zpa-d { 
 font-size:100%;
 text-align:left;
}


.marker {
    color: green;
    font-size: 0.7em;
    unicode-bidi: embed;
}

.notetext {
    unicode-bidi: embed;
}

/* Used for unformatted displays */
.markerplain {
    unicode-bidi: embed;
}

.attribute
{
    color: #CCCCCC;
}

.invalid {
    color: #FF0000;
    font-weight: bold;
}

/* added for FB24898 */
/* Updated for FB34868 */
.usfm_xt {
	unicode-bidi: embed;
}

.caller_big {
    unicode-bidi: normal;
    color: #0000CC;
    font-weight: bold;
    text-indent:0pt;
    vertical-align: text-top;
    font-size: 0.66em;
}

.caller_small 
{
    unicode-bidi: normal;
    color: #0000CC;
    font-family: Times New Roman;
	vertical-align: text-top;
    text-indent:0pt;
    font-size: 0.66em;
}

.caller_highlight 
{
    background-color:#FFFFB5;
    border-top: solid 1px #0000FF;
    border-bottom: solid 1px #0000FF;
}

.opennote {
    color: #7777FF;
}

table {
	border-collapse: collapse; 
}

td { 
	border: 1px solid #000000; 
	page-break-inside: avoid;
	/* FB27281 adding padding based on font size*/
	padding-right: 0.28em; 
	padding-left: 0.28em;
}

td.markercell { border-style: none }

rt
{
    cursor: pointer;
}

/* Style statues */
.status_unknown
{
    color: #FF0000;
    font-weight: bold;
}

.status_invalid
{
	border-bottom: 1px solid #FF0000;
	color:Red;
}


.annot_comment_todo { border-bottom: 1px dashed #888888; }
.annot_comment_todo { border-bottom: 1px dashed #888888; }
span.unread img { background-color: #ffff99; position: relative; bottom: -1px; /* negative of border-width to align baseline */ border-width: 1px; border-style: solid; border-color: #808080; }
span.read img { background-color: transparent; position: relative; bottom: 0px; border-width: 0px; border-style: none; }


.annot_comment_todo {
	border-bottom: 1px dashed #888888;
}

.annot_comment_done {
	border-bottom: 1px dashed #888888;
}

.annot_greencursor {background-color: #ACDAC2} .annot_goldcursor {background-color: #FFD700} .annot_bluecursor {background-color: #87CEEB} .annot_greycursor {background-color: #C0C0C0} .annot_violetcursor {background-color: #EE82EE}

				.annot_spellingerror
{
background-image:url(""file:///E:/Projects/Paratext/Paratext/bin/x86/Debug/Checking/Spelling/wavyredunderline.gif"");
background-repeat:repeat-x;
background-position:left bottom;
padding-bottom:0px;
vertical-align:text-top;
}

.annot_spellingunknown
{
background-image:url(""file:///E:/Projects/Paratext/Paratext/bin/x86/Debug/Checking/Spelling/wavygrayunderline.gif"");
background-repeat:repeat-x;
background-position:left bottom;
padding-bottom:0px;
vertical-align:text-top;
}

.found_term { background-color: rgba(222,222,222,1); }
.guessed_term { background-color: rgba(255,191,143,1); }
.found_term.unselected_term { background-color: rgba(222,222,222,0.5); }
.guessed_term.unselected_term { background-color: rgba(255,191,143,0.5); }
.selected_term { border-style: none none solid none; border-width: thin;}
.annot_reference_link { border-bottom: 1px solid #93C4FF; } 
                .annot_invalid_reference { border-bottom: 1px solid #FF8080; }
.annot_checkError { border-top: 1px solid #FF0000; border-bottom: 1px solid #FF0000; background-color: rgba(255,204,204,0.5); }
";
        #endregion
    }
}
