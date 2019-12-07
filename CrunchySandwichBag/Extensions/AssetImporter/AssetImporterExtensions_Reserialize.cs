using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Salt;
    using Bun;
    using Sandwich;
    
    static public class AssetImporterExtensions_Reserialize
    {
        static public void Reserialize(this AssetImporter item)
        {
            AssetDatabase.ForceReserializeAssets(Enumerable.New<string>(item.assetPath), ForceReserializeAssetsOptions.ReserializeMetadata);
        }
    }
}