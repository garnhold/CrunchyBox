using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class CustomAssets
    {
        static public CustomAsset CreateExternalCustomAsset(Type type, string filename, Process<CustomAsset> process)
        {
            return Assets.CreateAsset<CustomAsset>(type, filename, process);
        }
        static public CustomAsset CreateExternalCustomAsset(Type type, string filename)
        {
            return Assets.CreateAsset<CustomAsset>(type, filename);
        }

        static public CustomAsset CreateExternalCustomAsset(Type type, Process<CustomAsset> process)
        {
            return Assets.CreateAsset<CustomAsset>(type, process);
        }
        static public CustomAsset CreateExternalCustomAsset(Type type)
        {
            return Assets.CreateAsset<CustomAsset>(type);
        }

        static public T CreateExternalCustomAsset<T>(string filename, Process<T> process) where T : ScriptableObject
        {
            return Assets.CreateAsset<T>(filename, process);
        }
        static public T CreateExternalCustomAsset<T>(string filename) where T : ScriptableObject
        {
            return Assets.CreateAsset<T>(filename);
        }

        static public T CreateExternalCustomAsset<T>(Process<T> process) where T : ScriptableObject
        {
            return Assets.CreateAsset<T>(process);
        }
        static public T CreateExternalCustomAsset<T>() where T : ScriptableObject
        {
            return Assets.CreateAsset<T>();
        }
    }
}