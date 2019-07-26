using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class AssetInfoExtensions_AssetType
    {
        static public bool IsInternalAsset(this AssetInfo item)
        {
            if(Filename.ArePathsEquivalent(item.GetDirectory(), Project.GetInternalAssetDirectory()))
                return true;

            return false;
        }

        static public bool IsExternalAsset(this AssetInfo item)
        {
            if (item.IsInternalAsset() == false)
                return true;

            return false;
        }
    }
}