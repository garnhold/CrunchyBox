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
        static public bool DoesAssetPathExist(string path)
        {
            if (AssetDatabase.GetAllAssetPaths().Has(path))
                return true;

            return false;
        }

        static public IEnumerable<string> GetAssetGUIDs(string filter, string directory, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            return AssetDatabase.FindAssets(
                labels.Narrow(l => l.IsId()).Convert(l => "l:" + l)
                    .Append(types.Convert(t => "t:" + t.Name))
                    .PrependIf(filter.IsId(), filter)
                    .Join(" "),
                new string[] { directory.TrimSuffix("/") }
            );
        }
        static public IEnumerable<string> GetAssetGUIDs(string filter, string directory, params object[] labels_and_types)
        {
            return GetAssetGUIDs(
                filter,
                directory,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }

        static public IEnumerable<string> GetAssetPaths(string filter, string directory, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            return GetAssetGUIDs(filter, directory, labels, types).Convert(g => AssetDatabase.GUIDToAssetPath(g));
        }
        static public IEnumerable<string> GetAssetPaths(string filter, string directory, params object[] labels_and_types)
        {
            return GetAssetPaths(
                filter,
                directory,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }
    }
}