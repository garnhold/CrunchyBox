using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
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