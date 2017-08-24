﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSiOSMFApp.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TabAppVersion recording.
    /// </summary>
    [TestModule("44b5760b-33ee-47bf-8fd0-b9301ad5b1c8", ModuleType.Recording, 1)]
    public partial class TabAppVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabAppVersion instance = new TabAppVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabAppVersion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabAppVersion Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Step## Open the app, tap on the info icon
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, tap on the info icon", new RecordItemIndex(0));
            
            TapOn("InfoIcon");
            Delay.Milliseconds(0);
            
            // Validation## Info menu opens up
            Report.Log(ReportLevel.Info, "Section", "Validation## Info menu opens up", new RecordItemIndex(2));
            
            TabVerifyNavBarTitle("Info");
            Delay.Milliseconds(0);
            
            // Validation## Application version information is displayed and it's same as installed version number.(Android 1.x.x.xx)
            Report.Log(ReportLevel.Info, "Section", "Validation## Application version information is displayed and it's same as installed version number.(Android 1.x.x.xx)", new RecordItemIndex(4));
            
            ValidateAppVersion();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
