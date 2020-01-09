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
    static public class AnimatedSpriteMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateAnimatedSpriteMenuItems()
        {
            CodeGenerator.GenerateStaticClass("AnimatedSpriteMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (AnimatedSpriteFormat format in CustomAssets.GetExternalCustomAssetsOfType<AnimatedSpriteFormat>())
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Sprite/Create/Animated/" + format.name).StyleAsDoubleQuoteLiteral(),
                        "FUNCTION_EXECUTE", ("Execute" + format.name).StyleAsFunctionName(),
                        "FUNCTION_VALIDATE", ("Validate" + format.name).StyleAsFunctionName(),
                        "FORMAT_PATH", format.GetAssetPath().StyleAsDoubleQuoteLiteral()
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION_EXECUTE()", delegate() {
                        writer.Write("AssetDatabase.LoadAssetAtPath<AnimatedSpriteFormat>(?FORMAT_PATH).CreateAnimatedSprite(Selection.activeObject as Texture2D);");
                    });

                    writer.Write("[MenuItem(?PATH, true)]");
                    writer.Write("static public bool ?FUNCTION_VALIDATE()", delegate() {
                        writer.Write("if(Selection.activeObject is Texture2D)", delegate() {
                            writer.Write("return true;");
                        });

                        writer.Write("return false;");
                    });
                }
            }, GeneratedCodeType.EditorOnlyLeaf);
        }
    }
}