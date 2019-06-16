using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class CustomAssets
    {
        static public CustomAsset CreateExternalCustomAsset(Type type, string filename, Process<CustomAsset> process)
        {
            CustomAsset asset = ScriptableObject.CreateInstance(type) as CustomAsset;

            process(asset);
            asset.SaveAsset(filename);
            return asset;
        }
        static public CustomAsset CreateExternalCustomAsset(Type type, string filename)
        {
            return CreateExternalCustomAsset(type, filename, a => { });
        }

        static public CustomAsset CreateExternalCustomAsset(Type type, Process<CustomAsset> process)
        {
            return CreateExternalCustomAsset(type, Project.MakeNewCurrentDirectoryFilename(type.Name, "asset"), process);
        }
        static public CustomAsset CreateExternalCustomAsset(Type type)
        {
            return CreateExternalCustomAsset(type, a => { });
        }

        static public T CreateExternalCustomAsset<T>(string filename, Process<T> process) where T : CustomAsset
        {
            return (T)CreateExternalCustomAsset(typeof(T), filename, a => process((T)a));
        }
        static public T CreateExternalCustomAsset<T>(string filename) where T : CustomAsset
        {
            return CreateExternalCustomAsset<T>(filename, a => { });
        }

        static public T CreateExternalCustomAsset<T>(Process<T> process) where T : CustomAsset
        {
            return CreateExternalCustomAsset<T>(Project.MakeNewCurrentDirectoryFilename(typeof(T).Name, "asset"), process);
        }
        static public T CreateExternalCustomAsset<T>() where T : CustomAsset
        {
            return CreateExternalCustomAsset<T>(a => { });
        }
    }
}