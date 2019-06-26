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
    static public class SequencedSpriteMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateSequencedSpriteMenuItems()
        {
            CodeGenerator.GenerateStaticClass("SequencedSpriteMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (SequencedSpriteFormat format in CustomAssets.GetExternalCustomAssetsOfType<SequencedSpriteFormat>())
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Sprite/Create/Sequenced/" + format.name).StyleAsLiteralString(),
                        "FUNCTION_EXECUTE", ("Execute" + format.name).StyleAsFunctionName(),
                        "FUNCTION_VALIDATE", ("Validate" + format.name).StyleAsFunctionName(),
                        "FORMAT_PATH", format.GetAssetPath().StyleAsLiteralString()
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION_EXECUTE()", delegate() {
                        writer.Write("AssetDatabase.LoadAssetAtPath<SequencedSpriteFormat>(?FORMAT_PATH).CreateSequencedSprite(Selection.activeObject as Texture2D);");
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