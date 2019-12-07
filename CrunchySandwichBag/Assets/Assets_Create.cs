using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class Assets
    {
        static public T CreateAsset<T>(Type type, string filename, Process<T> process) where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance(type) as T;

            process(asset);
            asset.SaveNewAsset(filename);
            asset.FocusAsset();
            return asset;
        }
        static public T CreateAsset<T>(Type type, string filename) where T : ScriptableObject
        {
            return CreateAsset<T>(type, filename, a => { });
        }

        static public T CreateAsset<T>(Type type, Process<T> process) where T : ScriptableObject
        {
            return CreateAsset<T>(type, Project.MakeUnusedCurrentDirectoryFilename(type.Name, "asset"), process);
        }
        static public T CreateAsset<T>(Type type) where T : ScriptableObject
        {
            return CreateAsset<T>(type, a => { });
        }

        static public T CreateAsset<T>(string filename, Process<T> process) where T : ScriptableObject
        {
            return CreateAsset<T>(typeof(T), filename, process);
        }
        static public T CreateAsset<T>(string filename) where T : ScriptableObject
        {
            return CreateAsset<T>(filename, a => { });
        }

        static public T CreateAsset<T>(Process<T> process) where T : ScriptableObject
        {
            return CreateAsset<T>(typeof(T), process);
        }
        static public T CreateAsset<T>() where T : ScriptableObject
        {
            return CreateAsset<T>(a => { });
        }
    }
}