using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [SpawnInstanceEditDistinctionAttribute]
    static public class UnityObjectExtensions_Spawn
    {
        [SpawnInstanceEditDistinctionAttribute]
        static public UnityEngine.Object SpawnInstance(UnityEngine.Object item)
        {
            return PrefabUtility.InstantiatePrefab(item);
        }
    }
}