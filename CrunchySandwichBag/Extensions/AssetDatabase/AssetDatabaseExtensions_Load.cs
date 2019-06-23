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
        static public IEnumerable<UnityEngine.Object> GetAssets(string filter, string directory, bool include_sub_asset, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            IEnumerable<string> paths = GetAssetPaths(filter, directory, labels, types);

            if(include_sub_asset)
                return paths.Convert(p => (IEnumerable<UnityEngine.Object>)AssetDatabase.LoadAllAssetsAtPath(p));

            return paths.Convert(p => AssetDatabase.LoadMainAssetAtPath(p));
        }
        static public IEnumerable<UnityEngine.Object> GetAssets(string filter, string directory, bool include_sub_asset, params object[] labels_and_types)
        {
            return GetAssets(
                filter,
                directory,
                include_sub_asset,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }
        static public IEnumerable<T> GetAssets<T>(string filter, string directory, bool include_sub_asset) where T : UnityEngine.Object
        {
            return GetAssets(filter, directory, include_sub_asset, typeof(T)).Convert<UnityEngine.Object, T>();
        }
    }
}