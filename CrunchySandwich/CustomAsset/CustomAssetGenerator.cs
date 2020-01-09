using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [Serializable]
    public abstract class CustomAssetGenerator<T> where T : CustomAsset
    {
        [SerializeField]private T custom_asset;

        public bool IsValid()
        {
            if (custom_asset != null)
                return true;

            return false;
        }

        public T CreateInstance()
        {
            if (custom_asset != null)
                return custom_asset.SpawnInstance();

            return default(T);
        }
    }
}