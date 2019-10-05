using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [UnityObjectEXPrefabIdEditDistinction]
    static public class UnityObjectEXExtensions_PrefabId
    {
        [UnityObjectEXPrefabIdEditDistinction]
        static public string GetPrefabId(UnityEngine.Object item)
        {
            return item.GetAssetGUID();
        }
    }
}