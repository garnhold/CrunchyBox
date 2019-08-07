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
    static public class SpriteVectorizerMenuInitilizer
    {
        [CodeGenerator]
        static private void GenerateSpriteVectorizerMenuItems()
        {
            CodeGenerator.GenerateStaticClass("SpriteVectorizerMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (SpriteVectorizer vectorizer in CustomAssets.GetExternalCustomAssetsOfType<SpriteVectorizer>())
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "SPRITE_PATH", ("Assets/Sprite/Generate/Collider/" + vectorizer.name).StyleAsLiteralString(),
                        "TEXTURE_PATH", ("Assets/Sprite/Generate/Colliders/" + vectorizer.name).StyleAsLiteralString(),
                        "FUNCTION_SPRITE_EXECUTE", ("ExecuteSprite" + vectorizer.name).StyleAsFunctionName(),
                        "FUNCTION_SPRITE_VALIDATE", ("ValidateSprite" + vectorizer.name).StyleAsFunctionName(),
                        "FUNCTION_TEXTURE_EXECUTE", ("ExecuteTexture" + vectorizer.name).StyleAsFunctionName(),
                        "FUNCTION_TEXTURE_VALIDATE", ("ValidateTexture" + vectorizer.name).StyleAsFunctionName(),
                        "VECTORIZER_PATH", vectorizer.GetAssetPath().StyleAsLiteralString()
                    );

                    writer.Write("[MenuItem(?SPRITE_PATH)]");
                    writer.Write("static public void ?FUNCTION_SPRITE_EXECUTE()", delegate() {
                        writer.Write("(Selection.activeObject as Sprite).GenerateSpriteCollider(AssetDatabase.LoadAssetAtPath<SpriteVectorizer>(?VECTORIZER_PATH));");
                    });

                    writer.Write("[MenuItem(?SPRITE_PATH, true)]");
                    writer.Write("static public bool ?FUNCTION_SPRITE_VALIDATE()", delegate() {
                        writer.Write("if(Selection.activeObject is Sprite)", delegate() {
                            writer.Write("return true;");
                        });

                        writer.Write("return false;");
                    });

                    writer.Write("[MenuItem(?TEXTURE_PATH)]");
                    writer.Write("static public void ?FUNCTION_TEXTURE_EXECUTE()", delegate() {
                        writer.Write("(Selection.activeObject as Texture2D).GenerateSpriteColliders(AssetDatabase.LoadAssetAtPath<SpriteVectorizer>(?VECTORIZER_PATH));");
                    });

                    writer.Write("[MenuItem(?TEXTURE_PATH, true)]");
                    writer.Write("static public bool ?FUNCTION_TEXTURE_VALIDATE()", delegate() {
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