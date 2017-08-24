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
    ///The TabMonauralFlowRecommendationGiven recording.
    /// </summary>
    [TestModule("874ad072-f8a5-4dee-810f-5d610855d680", ModuleType.Recording, 1)]
    public partial class TabMonauralFlowRecommendationGiven : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabMonauralFlowRecommendationGiven instance = new TabMonauralFlowRecommendationGiven();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabMonauralFlowRecommendationGiven()
        {
            H1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabMonauralFlowRecommendationGiven Instance
        {
            get { return instance; }
        }

#region Variables

        string _H1;

        /// <summary>
        /// Gets or sets the value of variable H1.
        /// </summary>
        [TestVariable("d5219586-f24f-4650-a9f6-5216eee7315a")]
        public string H1
        {
            get { return _H1; }
            set { _H1 = value; }
        }

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

            // Step## Pre-Condition - Initial setup and Access code setup is done.Customer created with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-Condition - Initial setup and Access code setup is done.Customer created with audiogram configured", new RecordItemIndex(0));
            
            CreatePatient("Flow", "Monaural");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, select List and select the existing customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, select List and select the existing customer", new RecordItemIndex(4));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("Monaural");
            Delay.Milliseconds(0);
            
            SelectCustomer("Flow", "Monaural");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram -Left with 60, 65 ,85, 90 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram -Left with 60, 65 ,85, 90 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done", new RecordItemIndex(8));
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "500,60;1000,65;2000,85;4000,90");
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Pop up appears to enter values for right ear.
            Report.Log(ReportLevel.Info, "Section", "Validation## Pop up appears to enter values for right ear.", new RecordItemIndex(12));
            
            ValidateALertMessage("Do you want to enter values for the \"right\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Press No for the popup appeared
            Report.Log(ReportLevel.Info, "Section", "Step## Press No for the popup appeared", new RecordItemIndex(14));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Returns to the overview screen with recommendation given for HI, Coupling and Cluster
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the overview screen with recommendation given for HI, Coupling and Cluster", new RecordItemIndex(16));
            
            ValidateMonauralHISelected(H1, "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Tip", "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Left");
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect-Pair HI
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect-Pair HI", new RecordItemIndex(20));
            
            SelectPage("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output. HI is successfully paired
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output. HI is successfully paired", new RecordItemIndex(22));
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Selected Sound Profile has high amplification output.");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            TapOn("Yes");
            Delay.Milliseconds(0);
            
            TapOn("OK");
            Delay.Milliseconds(0);
            
            // Step## Press Sound Comfort
            Report.Log(ReportLevel.Info, "Section", "Step## Press Sound Comfort", new RecordItemIndex(28));
            
            SelectPage("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            // Step## Increase/Decrease the volume and sound balancers using +/- buttons or slider
            Report.Log(ReportLevel.Info, "Section", "Step## Increase/Decrease the volume and sound balancers using +/- buttons or slider", new RecordItemIndex(30));
            
            VolumeIncrease();
            Delay.Milliseconds(0);
            
            SoundSharper();
            Delay.Milliseconds(0);
            
            // Step## Press Test OK
            Report.Log(ReportLevel.Info, "Section", "Step## Press Test OK", new RecordItemIndex(33));
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            // Validation## Session is completed
            Report.Log(ReportLevel.Info, "Section", "Validation## Session is completed", new RecordItemIndex(35));
            
            VerifyActionBarTitle("Session Completed");
            Delay.Milliseconds(0);
            
            // Step## Press Close session
            Report.Log(ReportLevel.Info, "Section", "Step## Press Close session", new RecordItemIndex(37));
            
            CloseSession();
            Delay.Milliseconds(0);
            
            // Validation## Returns to the Customer List screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the Customer List screen", new RecordItemIndex(39));
            
            TabVerifyNavBarTitle("Client List");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
