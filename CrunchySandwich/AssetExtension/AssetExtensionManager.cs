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

        private Dictionary<UnityEngine.Object, List<AssetExtension>> sorted_asset_extensions;

        public override void StartInEditor()
        {
            asset_extensions = Resources.FindObjectsOfTypeAll<AssetExtension>().ToList();
            sorted_asset_extensions = null;

            this.SaveAssetAdvisory();
        }

        public T CreateAssetExtension<T>(UnityEngine.Object asset) where T : AssetExtension
        {
            T extension = AssetExtension.CreateInstance<T>();
            extension.SetTargetAsset(asset);

            asset_extensions.Add(extension);
            sorted_asset_extensions = null;

            this.SaveAssetAdvisory();
            return extension;
        }

        public IEnumerable<AssetExtension> GetAssetExtensions(UnityEngine.Object asset)
        {
            if (sorted_asset_extensions == null)
                sorted_asset_extensions = asset_extensions.ToMultiDictionary(e => e.GetTargetAsset());

            return sorted_asset_extensions.GetValues(asset);
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