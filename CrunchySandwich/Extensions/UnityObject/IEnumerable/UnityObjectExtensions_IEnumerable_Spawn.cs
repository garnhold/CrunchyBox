using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    static public class UnityObjectExtensions_IEnumerable_Spawn
    {
        static public IEnumerable<T> SpawnInstances<T>(this IEnumerable<T> item) where T : UnityEngine.Object
        {
            return item.Convert(i => i.SpawnInstance());
        }
    }
}