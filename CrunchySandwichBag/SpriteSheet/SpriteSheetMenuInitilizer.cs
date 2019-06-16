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
    static public class SpriteSheetMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateSpriteSheetMenuItems()
        {
            CodeGenerator.GenerateStaticClass("SpriteSheetMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (SpriteSheetFormat format in CustomAssets.GetExternalCustomAssetsOfType<SpriteSheetFormat>())
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Assets/Create SpriteSheet/" + format.name).StyleAsLiteralString(),
                        "FUNCTION_EXECUTE", ("Execute" + format.name).StyleAsFunctionName(),
                        "FUNCTION_VALIDATE", ("Validate" + format.name).StyleAsFunctionName(),
                        "FORMAT_PATH", format.GetAssetPath().StyleAsLiteralString()
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION_EXECUTE()", delegate() {
                        writer.Write("AssetDatabase.LoadAssetAtPath<SpriteSheetFormat>(?FORMAT_PATH).CreateSpriteSheet(Selection.activeObject as Texture2D);");
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