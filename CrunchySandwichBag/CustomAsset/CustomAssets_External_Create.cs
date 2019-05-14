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
        static public CustomAsset CreateExternalCustomAsset(Type type, string filename)
        {
            CustomAsset asset = ScriptableObject.CreateInstance(type) as CustomAsset;

            asset.SaveAndFocusAsset(filename);
            return asset;
        }
        static public CustomAsset CreateExternalCustomAsset(Type type)
        {
            return CreateExternalCustomAsset(type, Project.MakeNewCurrentDirectoryFilename(type.Name, "asset"));
        }

        static public T CreateExternalCustomAsset<T>(string filename) where T : CustomAsset
        {
            return (T)CreateExternalCustomAsset(typeof(T), filename);
        }
        static public T CreateExternalCustomAsset<T>() where T : CustomAsset
        {
            return CreateExternalCustomAsset<T>(Project.MakeNewCurrentDirectoryFilename(typeof(T).Name, "asset"));
        }
    }
}