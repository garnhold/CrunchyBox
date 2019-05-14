using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Asset_Dependency
    {
        static public IEnumerable<string> GetAssetDependencyPaths(this UnityEngine.Object item, bool recursive)
        {
            return AssetDatabase.GetDependencies(item.GetAssetPath(), recursive);
        }

        static public IEnumerable<UnityEngine.Object> GetAssetDependencys(this UnityEngine.Object item, bool recursive)
        {
            return item.GetAssetDependencyPaths(recursive).Convert(p => (IEnumerable<UnityEngine.Object>)AssetDatabase.LoadAllAssetsAtPath(p));
        }

        static public IEnumerable<UnityEngine.Object> GetAssetDependents(this UnityEngine.Object item)
        {
            return AssetDatabase.GetAllAssetPaths()
                .Convert(p => AssetDatabase.LoadMainAssetAtPath(p))
                .Skip(item)
                .Narrow(o => o.GetAssetDependencyPaths(true).Has(item.GetAssetPath()));
        }

        static public bool IsAssetReferenced(this UnityEngine.Object item)
        {
            if (item.GetAssetDependents().IsNotEmpty())
                return true;

            return false;
        }

        static public bool IsAssetOrphaned(this UnityEngine.Object item)
        {
            if (item.IsAssetReferenced() == false)
                return true;

            return false;
        }
    }
}