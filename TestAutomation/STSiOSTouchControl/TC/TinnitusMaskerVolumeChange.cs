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

namespace STSiOSTouchControl.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TinnitusMaskerVolumeChange recording.
    /// </summary>
    [TestModule("75189c0e-7840-4eea-a867-c97b41e447cb", ModuleType.Recording, 1)]
    public partial class TinnitusMaskerVolumeChange : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSTouchControl.STSiOSTouchControlRepository repository.
        /// </summary>
        public static STSiOSTouchControl.STSiOSTouchControlRepository repo = STSiOSTouchControl.STSiOSTouchControlRepository.Instance;

        static TinnitusMaskerVolumeChange instance = new TinnitusMaskerVolumeChange();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TinnitusMaskerVolumeChange()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TinnitusMaskerVolumeChange Instance
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

            // Step## Select “Tinnitus Masker” from program list.
            Report.Log(ReportLevel.Info, "Section", "Step## Select “Tinnitus Masker” from program list.", new RecordItemIndex(0));
            
            TapOnProgram();
            Delay.Milliseconds(0);
            
            TapOn("Tinnitus");
            Delay.Milliseconds(0);
            
            // Validation## Tinnitus Masker is selected and Tinnitus Masker volume control is displayed on touch screen.
            Report.Log(ReportLevel.Info, "Section", "Validation## Tinnitus Masker is selected and Tinnitus Masker volume control is displayed on touch screen.", new RecordItemIndex(3));
            
            ValidateContents("Tinnitus;Therapy signal");
            Delay.Milliseconds(0);
            
            // Step## Turn down the tinnitus masker volume by the slider.
            Report.Log(ReportLevel.Info, "Section", "Step## Turn down the tinnitus masker volume by the slider.", new RecordItemIndex(5));
            
            // Validation## HI tinnitus masker volume is turned down according to application control.
            Report.Log(ReportLevel.Info, "Section", "Validation## HI tinnitus masker volume is turned down according to application control.", new RecordItemIndex(6));
            
            ValidateTinnitusVolumeDecrease();
            Delay.Milliseconds(0);
            
            // Step## Turn up the tinnitus masker volume by the slider.
            Report.Log(ReportLevel.Info, "Section", "Step## Turn up the tinnitus masker volume by the slider.", new RecordItemIndex(8));
            
            // Validation## HI tinnitus masker volume is turned up according to application control.
            Report.Log(ReportLevel.Info, "Section", "Validation## HI tinnitus masker volume is turned up according to application control.", new RecordItemIndex(9));
            
            ValidateTinnitusVolumeIncrease();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
