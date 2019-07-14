using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class CustomAssets
    {
        static public CustomAsset CreateInternalCustomAsset(Type type, Process<CustomAsset> process)
        {
            CustomAsset asset = ScriptableObject.CreateInstance(type) as CustomAsset;

            process(asset);
            asset.SaveNewAsset(Filename.MakeUnusedFilename(Project.GetInternalAssetDirectory(), "asset"));
            return asset;
        }
        static public CustomAsset CreateInternalCustomAsset(Type type)
        {
            return CreateInternalCustomAsset(type, a => { });
        }

        static public T CreateInternalCustomAsset<T>(Process<T> process) where T : CustomAsset
        {
            return (T)CreateInternalCustomAsset(typeof(T), a => process((T)a));
        }
        static public T CreateInternalCustomAsset<T>() where T : CustomAsset
        {
            return CreateInternalCustomAsset<T>(a => { });
        }
    }
}