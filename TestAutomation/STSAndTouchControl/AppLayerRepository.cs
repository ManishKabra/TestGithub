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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace STSAndTouchControl
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AppLayerRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    [RepositoryFolder("f13be46a-c2fa-47a0-8f5d-3a4c11b2b517")]
    public partial class AppLayerRepository : RepoGenBaseFolder
    {
        static AppLayerRepository instance = new AppLayerRepository();

        /// <summary>
        /// Gets the singleton class instance representing the AppLayerRepository element repository.
        /// </summary>
        [RepositoryFolder("f13be46a-c2fa-47a0-8f5d-3a4c11b2b517")]
        public static AppLayerRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AppLayerRepository() 
            : base("AppLayerRepository", "/", null, 0, false, "f13be46a-c2fa-47a0-8f5d-3a4c11b2b517", ".\\RepositoryImages\\AppLayerRepositoryf13be46a.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f13be46a-c2fa-47a0-8f5d-3a4c11b2b517")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
    public partial class AppLayerRepositoryFolders
    {
    }
#pragma warning restore 0436
}