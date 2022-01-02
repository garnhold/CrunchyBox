using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;

    static public class UnityObjectExtensions_Asset_Extension
    {
        static public T CreateAssetExtension<T>(this UnityEngine.Object item) where T : AssetExtension
        {
            T extension = AssetExtensionManager.GetInstance().SoftCreateAssetExtension<T>(item);

            extension.SaveNewAsset(Project.GetAssetExtensionDirectory() + item.name + "_" + typeof(T).Name);
            AssetExtensionManager.GetInstance().SaveAsset();
            return extension;
        }

        static public IEnumerable<AssetExtension> GetAssetExtensions(this UnityEngine.Object asset)
        {
            return AssetExtensionManager.GetInstance().GetAssetExtensions(asset);
        }
        static public IEnumerable<T> GetAssetExtensions<T>(this UnityEngine.Object asset) where T : AssetExtension
        {
            return AssetExtensionManager.GetInstance().GetAssetExtensions<T>(asset);
        }
        static public T GetAssetExtension<T>(this UnityEngine.Object asset) where T : AssetExtension
        {
            return AssetExtensionManager.GetInstance().GetAssetExtension<T>(asset);
        }

        static public T FetchAssetExtension<T>(this UnityEngine.Object item) where T : AssetExtension
        {
            T extension = item.GetAssetExtension<T>();

            if (extension == null)
                extension = item.CreateAssetExtension<T>();

            return extension;
        }
    }
}