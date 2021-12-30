using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class AssetExtensionManager : Subsystem<AssetExtensionManager>
    {
        [SerializeField] private List<AssetExtension> asset_extensions;

        private OperationCache<Dictionary<UnityEngine.Object, List<AssetExtension>>> sorted_asset_extensions;

        public AssetExtensionManager()
        {
            sorted_asset_extensions = new OperationCache<Dictionary<UnityEngine.Object, List<AssetExtension>>>("sorted_asset_extensions", delegate () {
                return asset_extensions.ToMultiDictionary(e => e.GetTargetAsset());
            });
        }

        public T SoftCreateAssetExtension<T>(UnityEngine.Object asset) where T : AssetExtension
        {
            T extension = AssetExtension.CreateInstance<T>();

            extension.SetTargetAsset(asset);
            asset_extensions.Add(extension);
            return extension;
        }

        public IEnumerable<AssetExtension> GetAssetExtensions(UnityEngine.Object asset)
        {
            return sorted_asset_extensions.Fetch().GetValues(asset);
        }
        public IEnumerable<T> GetAssetExtensions<T>(UnityEngine.Object asset) where T : AssetExtension
        {
            return GetAssetExtensions(asset).Convert<T>();
        }
        public T GetAssetExtension<T>(UnityEngine.Object asset) where T : AssetExtension
        {
            return GetAssetExtensions<T>(asset).GetFirst();
        }
    }
}