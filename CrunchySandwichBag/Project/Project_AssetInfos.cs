using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;

namespace CrunchySandwichBag
{
    static public partial class Project
    {
        static public IEnumerable<AssetInfo> GetAssetInfos(string filter, string directory, IEnumerable<string> labels, IEnumerable<Type> types)
        {
            return AssetDatabase.FindAssets(
                labels.Narrow(l => l.IsId()).Convert(l => "l:" + l)
                    .Append(types.Convert(t => "t:" + t.Name))
                    .PrependIf(filter.IsId(), filter)
                    .Join(" "),
                new string[] { directory.TrimSuffix("/") }
            ).Convert(g => new AssetInfo(g));
        }
        static public IEnumerable<AssetInfo> GetAssetInfos(string filter, string directory, params object[] labels_and_types)
        {
            return GetAssetInfos(
                filter,
                directory,
                labels_and_types.Convert<string>(),
                labels_and_types.Convert<Type>()
            );
        }
    }
}