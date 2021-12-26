using System;
using System.IO;

using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

using Crunchy.Dough;

namespace Crunchy.SandwichBag
{
    [ScriptedImporter(1, "tyon")]
    public class TyonImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext context)
        {
            TextAsset text_asset = new TextAsset(File.ReadAllText(context.assetPath));

            context.AddObjectToAsset("text", text_asset);
            context.SetMainObject(text_asset);
        }
    }
}