using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    [CodeGenerator]
    static public class AssetClassMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateAssetClassMenuItems()
        {
            CodeGenerator.GenerateStaticClass("AssetClassMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in Types.GetFilteredTypes(
                    Filterer_Type.HasCustomAttributeOfType<AssetClassAttribute>(true),
                    Filterer_Type.IsConcreteClass(),
                    Filterer_Type.IsNonGenericClass()
                ))
                {
                    string category = type.GetCustomLabeledAttributeOfTypeLabel<AssetClassCategoryAttribute>(true);

                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Create Custom/" + category.AppendToVisible("/") + type.Name.Replace("_", "/")).StyleAsDoubleQuoteLiteral(),
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