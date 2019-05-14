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
    static public class UnityObjectExtensions_Asset_Cohabitants
    {
        static public IEnumerable<UnityEngine.Object> GetAssetCohabitants(this UnityEngine.Object item)
        {
            return AssetDatabase.LoadAllAssetsAtPath(item.GetAssetPath());
        }
    }
}