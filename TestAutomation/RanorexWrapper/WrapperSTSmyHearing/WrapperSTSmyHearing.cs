using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

using Ranorex;
using Ranorex.Core.Testing;


namespace WrapperSTSAndBasic
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    [DeploymentItem("STSmyHearing.exe")]
    [DeploymentItem("STSmyHearing.rxtst")]
    [DeploymentItem("STSmyHearing.rxtmg")]
    public class WrapperSTSmyHearing
    {
        public WrapperSTSmyHearing()
        {
        }

        public void StartRanorexTestCase(string tc)
        {
            Ranorex.Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error;

            error = TestSuiteRunner.Run(typeof(STSmyHearing.Program), @"/zr /zrf:report.rxzlog /tc:" + tc);
            TestContext.AddResultFile("report.rxzlog");

            if (error != 0)
                throw new RanorexException("Test run failed! See report.rxzlog for further details!");
        }

        [TestMethod]
        public void TC_LegalTexts()
        {
            StartRanorexTestCase("LegalTexts");
        }

        [TestMethod]
        public void TC_RiskRelatedInfo()
        {
            StartRanorexTestCase("RiskRelatedInfo");
        }

        #region Additional test attributes

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private TestContext testContextInstance;
    }
}
