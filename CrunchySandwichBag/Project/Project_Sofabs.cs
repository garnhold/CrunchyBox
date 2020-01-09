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
        static public IEnumerable<ScriptableObject> GetAllSofabs()
        {
            return GetAllAssetInfos<ScriptableObject>().Convert(i => i.Resolve<ScriptableObject>());
        }

        static public IEnumerable<ScriptableObject> GetAllSofabs(Type type)
        {
            if (type.CanBeTreatedAs<ScriptableObject>())
                return GetAllAssetInfos(type).Convert(i => i.Resolve<ScriptableObject>());

            return Empty.IEnumerable<ScriptableObject>();
        }

        static public IEnumerable<T> GetAllSofabs<T>() where T : ScriptableObject
        {
            return GetAllAssetInfos<T>().Convert(i => i.Resolve<T>());
        }
    }
}