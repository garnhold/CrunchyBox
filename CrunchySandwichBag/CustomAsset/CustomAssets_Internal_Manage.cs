using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class CustomAssets
    {
        static public IEnumerable<CustomAsset> GetAllInternalCustomAssets()
        {
            return AssetDatabaseExtensions.GetAssets<CustomAsset>("", Project.GetInternalAssetDirectory(), false);
        }

        static public IEnumerable<CustomAsset> GetAllOrphanedInternalCustomAssets()
        {
            return GetAllInternalCustomAssets().Narrow(a => a.IsAssetOrphaned());
        }

        [MenuItem("Edit/Purge Orphaned Internal CustomAssets")]
        static public void PurgeOrphanedInternalCustomAssets()
        {
            GetAllOrphanedInternalCustomAssets().Process(a => a.DeleteAsset());
        }
    }
}