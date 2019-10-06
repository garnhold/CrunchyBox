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
    [UnityObjectEXOnValidateEditDistinction]
    static public class UnityObjectEXExtensions_PrefabId
    {
        [UnityObjectEXOnValidateEditDistinction]
        static public string OnValidate(UnityEngine.Object item)
        {
            string prefab_id = item.GetAssetGUID();

            PrefabLookup.GetInstance().RegisterPrefab(prefab_id, item);
            return prefab_id;
        }
    }
}