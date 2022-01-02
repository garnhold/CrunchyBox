using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;

    static public class UnityObjectExtensions_Prefab
    {
        static public bool IsPrefab(this UnityEngine.Object item)
        {
            if (PrefabUtility.GetPrefabAssetType(item) != PrefabAssetType.NotAPrefab)
                return true;

            return false;
        }

        static public bool IsPrefabInstance(this UnityEngine.Object item)
        {
            if (PrefabUtility.GetPrefabInstanceStatus(item) != PrefabInstanceStatus.NotAPrefab)
                return true;

            return false;
        }
    }
}