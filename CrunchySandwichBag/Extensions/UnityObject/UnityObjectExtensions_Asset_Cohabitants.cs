using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class UnityObjectExtensions_Asset_Cohabitants
    {
        static public IEnumerable<UnityEngine.Object> GetAssetCohabitants(this UnityEngine.Object item)
        {
            return AssetDatabase.LoadAllAssetsAtPath(item.GetAssetPath());
        }

        static public IEnumerable<T> GetAssetCohabitants<T>(this UnityEngine.Object item) where T : UnityEngine.Object
        {
            return item.GetAssetCohabitants()
                .Convert<T>();
        }
    }
}