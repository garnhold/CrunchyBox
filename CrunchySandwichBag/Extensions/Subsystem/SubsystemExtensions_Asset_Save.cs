using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    static public class SubsystemExtensions_Asset_Save
    {
        static public void SaveSubsystemAsset(this Subsystem item)
        {
            item.SaveNewAsset(item.GetSubsystemAssetPath());

            SubsystemManager.GetInstance().Refresh();
        }
    }
}