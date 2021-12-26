using System;
using System.IO;

using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;

    [ScriptedImporter(2, "tyon")]
    public class TyonAssetImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext context)
        {
            TyonAsset asset = TyonAsset.CreateInstance<TyonAsset>();

            asset.SetTyon(File.ReadAllText(context.assetPath));

            context.AddObjectToAsset("tyon", asset);
            context.SetMainObject(asset);
        }
    }
}