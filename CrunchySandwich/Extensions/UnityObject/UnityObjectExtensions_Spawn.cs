using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    static public class UnityObjectExtensions_Spawn
    {
        static public T SpawnInstance<T>(this T item) where T : UnityEngine.Object
        {
            if (Application.isPlaying)
                return UnityEngine.Object.Instantiate<T>(item);

            return (T)PlayEditDistinction<SpawnInstanceEditDistinctionAttribute>
                .ExecuteEditDistinction<UnityEngine.Object, UnityEngine.Object>(item);
        }
    }

    public class SpawnInstanceEditDistinctionAttribute : EditDistinctionAttribute { }
}