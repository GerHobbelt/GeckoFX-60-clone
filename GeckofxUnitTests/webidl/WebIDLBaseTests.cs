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
        private GeckoWebBrowser browser;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            var f = new Form();

            browser = new GeckoWebBrowser {Dock = DockStyle.Fill};
            f.Controls.Add(browser);
            f.Show();
        }

        [TestCase("hello", "hello")]
        [TestCase("h'ell'o", "h'ell'o")]
        [TestCase("h\"ell'o", "h\"ell'o")]
        [TestCase(@"he
llo", @"he
llo")]
        public void SetProperty_VariousValues(string val, string expectedResult)
        {
            browser.TestLoadHtml("hello world.");
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy) browser.Window.DomWindow, browser.Window.DomWindow);

            objectUnderTest.SetProperty("somethingRandom", val);

            Assert.AreEqual(expectedResult, objectUnderTest.GetProperty<string>("somethingRandom"));       
        }

        [TestCase]
        public void SetProperty_RegresstionTest_DoesNotThrowException()
        {
            var objectUnderTest = new WebIDLBase((mozIDOMWindowProxy)browser.Window.DomWindow, browser.Window.DomWindow);

            objectUnderTest.SetProperty("somethingRandom", _testData);

            Assert.AreEqual(_testData, objectUnderTest.GetProperty<string>("somethingRandom"));
        }


        #region TestData

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
