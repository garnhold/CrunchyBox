using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Asset_AssetType
    {
        static public AssetType GetAssetType(this UnityEngine.Object item)
        {
            if (item.IsNotNull())
            {
                if (Filename.ArePathsEquivalent(item.GetAssetDirectory(), Project.GetInternalAssetDirectory()))
                    return AssetType.Internal;

                return AssetType.External;
            }

            return AssetType.None;
        }

        static public bool IsInternalAsset(this UnityEngine.Object item)
        {
            if (item.GetAssetType() == AssetType.Internal)
                return true;

            return false;
        }

        static public bool IsExternalAsset(this UnityEngine.Object item)
        {
            if (item.GetAssetType() == AssetType.External)
                return true;

            return false;
        }
    }
}