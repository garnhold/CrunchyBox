using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public partial class CustomAssets
    {
        static public IEnumerable<string> GetExternalCustomAssetPathsOfType(Type type)
        {
            if (type.CanBeTreatedAs<CustomAsset>())
            {
                return AssetDatabase.FindAssets("t:" + type.Name)
                    .Convert(g => AssetDatabase.GUIDToAssetPath(g))
                    .Skip(p => p.StartsWith(Project.GetInternalAssetDirectory()));
            }

            return Empty.IEnumerable<string>();
        }

        static public IEnumerable<string> GetAllExternalCustomAssetPaths()
        {
            return GetExternalCustomAssetPathsOfType(typeof(CustomAsset));
        }

        static public IEnumerable<CustomAsset> GetExternalCustomAssetsOfType(Type type)
        {
            return GetExternalCustomAssetPathsOfType(type).Convert(p => AssetDatabase.LoadMainAssetAtPath(p) as CustomAsset);
        }
        static public IEnumerable<T> GetExternalCustomAssetsOfType<T>() where T : CustomAsset
        {
            return GetExternalCustomAssetsOfType(typeof(T)).Convert<CustomAsset, T>();
        }

        static public IEnumerable<CustomAsset> GetAllExternalCustomAssets()
        {
            return GetAllExternalCustomAssetPaths().Convert(p => AssetDatabase.LoadMainAssetAtPath(p) as CustomAsset);
        }
    }
}