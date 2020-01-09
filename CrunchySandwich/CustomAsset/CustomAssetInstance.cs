using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [Serializable]
    public abstract class CustomAssetInstance<T> where T : CustomAsset
    {
        [SerializeField]private T custom_asset;

        private T instance;
        private T custom_asset_instanced_from;

        public bool IsValid()
        {
            if (custom_asset != null)
                return true;

            return false;
        }

        public T GetInstance()
        {
            if (instance == null || custom_asset != custom_asset_instanced_from)
            {
                instance = custom_asset.SpawnInstance();
                custom_asset_instanced_from = custom_asset;
            }

            return instance;
        }
    }
}