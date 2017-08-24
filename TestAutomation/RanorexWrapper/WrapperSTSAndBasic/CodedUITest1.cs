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
    [DeploymentItem("STSAndBasic.exe")]
    [DeploymentItem("STSAndBasic.rxtst")]
    [DeploymentItem("STSAndBasic.rxtmg")]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        //[TestMethod]
        //public void CodedUITestMethod1()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        
        public void StartRanorexTestCase(string tc)
        {
            Ranorex.Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;

            int error = TestSuiteRunner.Run(typeof(STSAndBasic.Program), @"/pa:Device=32048ed1e6167153 /pa:Brand=Signia /pa:isTablet=False /zr /zrf:report.rxzlog /tc:" + tc);
            TestContext.AddResultFile("report.rxzlog");

            if (error != 0)
                throw new RanorexException("Test run failed! See report.rxzlog for further details!");
        }

        [TestMethod]
        public void TC_AppInfo()
        {
            StartRanorexTestCase("AppInfo");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

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
