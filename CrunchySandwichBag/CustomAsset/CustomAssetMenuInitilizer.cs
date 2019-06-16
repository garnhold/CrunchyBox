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
    [CodeGenerator]
    static public class CustomAssetMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateCustomAssetMenuItems()
        {
            CodeGenerator.GenerateStaticClass("CustomAssetMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.CanBeTreatedAs<CustomAsset>(),
                    Filterer_Type.IsConcreteClass()
                ))
                {
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
                }
            }, true);
        }
    }
}