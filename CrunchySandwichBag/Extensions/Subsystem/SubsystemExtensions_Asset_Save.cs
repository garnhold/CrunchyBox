using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class SubsystemExtensions_Asset_Save
    {
        static public void SaveSubsystemAsset(this Subsystem item)
        {
            item.SaveAsset(item.GetSubsystemAssetPath());

            SubsystemManager.GetInstance().Refresh();
        }
    }
}