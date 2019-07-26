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
        [MenuItem("Edit/Purge Orphaned Internal CustomAssets")]
        static public void PurgeOrphanedInternalCustomAssets()
        {
            Project.GetInternalAssetInfos<CustomAsset>()
                .Narrow(a => a.IsOrphaned())
                .Process(a => a.Delete());
        }
    }
}