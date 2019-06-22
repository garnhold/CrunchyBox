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
    static public class AnimatedSpriteMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateAnimatedSpriteMenuItems()
        {
            CodeGenerator.GenerateStaticClass("AnimatedSpriteMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (AnimatedSpriteFormat format in CustomAssets.GetExternalCustomAssetsOfType<AnimatedSpriteFormat>())
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Create Sprite/Animated/" + format.name).StyleAsLiteralString(),
                        "FUNCTION_EXECUTE", ("Execute" + format.name).StyleAsFunctionName(),
                        "FUNCTION_VALIDATE", ("Validate" + format.name).StyleAsFunctionName(),
                        "FORMAT_PATH", format.GetAssetPath().StyleAsLiteralString()
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
            }, true);
        }
    }
}