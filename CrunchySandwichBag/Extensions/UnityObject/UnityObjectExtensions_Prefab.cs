using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Prefab
    {
        static public bool IsPrefab(this UnityEngine.Object item)
        {
            if (PrefabUtility.GetPrefabType(item) != PrefabType.None)
                return true;

            return false;
        }
    }
}