using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class AssetDatabaseExtensions
    {
        static public IEnumerable<UnityEngine.Object> GetAssets(bool include_sub_asset)
        {
            return GetAssets("", Project.GetAssetDirectory(), include_sub_asset);
        }

        static public IEnumerable<UnityEngine.Object> GetAssets(bool include_sub_asset, Type type)
        {
            return GetAssets("", Project.GetAssetDirectory(), include_sub_asset, type);
        }
        static public IEnumerable<T> GetAssets<T>(bool include_sub_asset)
        {
            return GetAssets(include_sub_asset, typeof(T)).Convert<UnityEngine.Object, T>();
        }

        static public IEnumerable<GameObject> GetPrefabs()
        {
            return GetAssets<GameObject>(false);
        }
    }
}