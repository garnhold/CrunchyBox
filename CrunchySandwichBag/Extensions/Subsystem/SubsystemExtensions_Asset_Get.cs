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
    static public class SubsystemExtensions_Asset_Get
    {
        static public string GetSubsystemAssetPath(this Subsystem item)
        {
            return SubsystemExtensions_Asset.GetSubsystemAssetPath(item.GetType());
        }
    }
}