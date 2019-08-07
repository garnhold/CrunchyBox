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
    static public class AssetClassMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateAssetClassMenuItems()
        {
            CodeGenerator.GenerateStaticClass("AssetClassMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.HasCustomAttributeOfType<AssetClassAttribute>(true),
                    Filterer_Type.IsConcreteClass(),
                    Filterer_Type.IsNonGenericClass()
                ))
                {
                    string category = type.GetCustomLabeledAttributeOfTypeLabel<AssetClassCategoryAttribute>(true);

                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Create Custom/" + category.AppendToVisible("/") + type.Name.Replace("_", "/")).StyleAsLiteralString(),
                        "FUNCTION", ("Create" + type.Name).StyleAsFunctionName(),
                        "TYPENAME", type.Namespace.AppendToVisible(".") + type.Name
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION()", delegate() {
                        writer.Write("Assets.CreateAsset<?TYPENAME>();");
                    });
                }
            }, GeneratedCodeType.EditorOnlyLeaf);
        }
    }
}