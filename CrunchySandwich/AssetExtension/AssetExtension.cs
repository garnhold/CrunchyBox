using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class AssetExtension : ScriptableObject
    {
        [SerializeField] private UnityEngine.Object target_asset;

        public void SetTargetAsset(UnityEngine.Object asset)
        {
            target_asset = asset;
        }

        public UnityEngine.Object GetTargetAsset()
        {
            return target_asset;
        }
    }
}