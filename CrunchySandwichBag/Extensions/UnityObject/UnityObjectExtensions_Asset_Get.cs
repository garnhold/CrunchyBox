﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;

    static public class UnityObjectExtensions_Asset_Get
    {
        static public bool IsAssetSaved(this UnityEngine.Object item)
        {
            if (item.GetAssetPath().IsVisible())
                return true;

            return false;
        }

        static public bool IsAssetFolder(this UnityEngine.Object item)
        {
            return AssetDatabase.IsValidFolder(AssetDatabase.GetAssetPath(item));
        }

        static public string GetAssetPath(this UnityEngine.Object item)
        {
            if (item.IsNotNull())
            {
                string path = AssetDatabase.GetAssetPath(item);

                if (path.IsBlank())
                    path = PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(item);

                if (item.IsAssetFolder())
                    return path + "/";

                return path;
            }

            return null;
        }

        static public string GetAssetGUID(this UnityEngine.Object item)
        {
            return AssetDatabase.AssetPathToGUID(item.GetAssetPath());
        }

        static public string GetAssetDirectory(this UnityEngine.Object item)
        {
            return Filename.GetDirectory(item.GetAssetPath());
        }

        static public AssetInfo GetAssetInfo(this UnityEngine.Object item)
        {
            return new AssetInfo(item);
        }
    }
}