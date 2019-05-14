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
        static public IEnumerable<UnityEngine.Object> GetMainAssets(string filter, string directory, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            return GetAssetPaths(filter, directory, labels, types).Convert(p => AssetDatabase.LoadMainAssetAtPath(p));
        }
        static public IEnumerable<UnityEngine.Object> GetMainAssets(string filter, string directory, params object[] labels_and_types)
        {
            return GetMainAssets(
                filter,
                directory,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }
        static public IEnumerable<T> GetMainAssets<T>(string filter, string directory) where T : UnityEngine.Object
        {
            return GetMainAssets(filter, directory, typeof(T)).Convert<UnityEngine.Object, T>();
        }

        static public IEnumerable<UnityEngine.Object> GetAllAssets(string filter, string directory, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            return GetAssetPaths(filter, directory, labels, types)
                .Convert(p => (IEnumerable<UnityEngine.Object>)AssetDatabase.LoadAllAssetsAtPath(p));
        }
        static public IEnumerable<UnityEngine.Object> GetAllAssets(string filter, string directory, params object[] labels_and_types)
        {
            return GetAllAssets(
                filter,
                directory,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }
        static public IEnumerable<T> GetAllAssets<T>(string filter, string directory) where T : UnityEngine.Object
        {
            return GetAllAssets(filter, directory, typeof(T)).Convert<UnityEngine.Object, T>();
        }
    }
}