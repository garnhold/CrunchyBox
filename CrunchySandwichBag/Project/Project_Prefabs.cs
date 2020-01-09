using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public partial class Project
    {
        static public IEnumerable<GameObject> GetAllPrefabs()
        {
            return GetAllAssetInfos<GameObject>()
                .Convert(a => a.Resolve<GameObject>());
        }

        static public IEnumerable<Component> GetAllPrefabs(Type type)
        {
            return GetAllPrefabs().ConvertComponent(type);
        }
        static public IEnumerable<T> GetAllPrefabs<T>()
        {
            return GetAllPrefabs(typeof(T)).Convert<Component, T>();
        }
    }
}