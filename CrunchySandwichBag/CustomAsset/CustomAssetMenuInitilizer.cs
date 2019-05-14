using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class CustomAssetMenuInitilizer
    {
        [MenuItem("Edit/Force Custom Asset Menu Regeneration")]
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateCustomAssetMenuItems()
        {
            CodeGenerator.GenerateEditorClassFromTypes<CustomAsset>("CustomAssetMenuItems", delegate(Type type, CSTextDocumentBuilder builder) {
                string category = type.GetCustomLabeledAttributeOfTypeLabel<CustomAssetCategoryAttribute>(true);

                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "PATH", ("Assets/Create/" + category.AppendToVisible("/") + type.Name.Replace("_", "/")).StyleAsLiteralString(),
                    "FUNCTION", ("Create" + type.Name).StyleAsFunctionName(),
                    "TYPENAME", type.Namespace.AppendToVisible(".") + type.Name
                );

                writer.Write("[MenuItem(?PATH)]");
                writer.Write("static public void ?FUNCTION()", delegate() {
                    writer.Write("CustomAssets.CreateExternalCustomAsset<?TYPENAME>();");
                });
            });
        }
    }
}