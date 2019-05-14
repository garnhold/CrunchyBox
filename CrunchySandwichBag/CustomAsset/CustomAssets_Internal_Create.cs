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
        static public CustomAsset CreateInternalCustomAsset(Type type)
        {
            CustomAsset asset = ScriptableObject.CreateInstance(type) as CustomAsset;

            asset.SaveAsset(Filename.MakeNewFilename(Project.GetInternalAssetDirectory(), "asset"));
            return asset;
        }
    }
}