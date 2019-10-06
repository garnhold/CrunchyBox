using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [UnityObjectEXOnValidateEditDistinction]
    static public class UnityObjectEXExtensions_OnValidate
    {
        [UnityObjectEXOnValidateEditDistinction]
        static public void OnValidate(UnityEngine.Object item)
        {
            if (item.IsPrefab())
            {
                string prefab_id = item.GetAssetGUID();

                PrefabLookup.GetInstance().RegisterPrefab(prefab_id, item);
                item.SetVariableValueByPath("prefab_id", prefab_id);
            }
        }
    }
}