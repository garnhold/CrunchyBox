using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class AssetImporterExtensions_Reserialize
    {
        static public void Reserialize(this AssetImporter item)
        {
            AssetDatabase.ForceReserializeAssets(Enumerable.New<string>(item.assetPath), ForceReserializeAssetsOptions.ReserializeMetadata);
        }
    }
}