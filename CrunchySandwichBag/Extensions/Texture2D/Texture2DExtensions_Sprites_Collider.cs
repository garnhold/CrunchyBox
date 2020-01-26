using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class Texture2DExtensions_Sprites_Collider
    {
        static public void GenerateSpriteColliders(this Texture2D item, SpriteVectorizer vectorizer)
        {
            item.ModifyAssetImporter(delegate(SerializedObject obj) {
                GetSpriteSerializedPropertys(obj)
                    .Process(p => GenerateSpriteCollider(item, p, vectorizer));
            });
        }

        static public void GenerateSpriteCollider(this Texture2D item, Sprite sprite, SpriteVectorizer vectorizer)
        {
            item.ModifyAssetImporter(delegate(SerializedObject obj) {
                GetSpriteSerializedPropertys(obj)
                    .Narrow(p => p.GetChildValue<string>("m_SpriteID") == sprite.GetSpriteId())
                    .Process(p => GenerateSpriteCollider(item, p, vectorizer));
            });
        }

        static private void GenerateSpriteCollider(Texture2D texture, SerializedProperty property, SpriteVectorizer vectorizer)
        {
            GenerateSpriteCollider(
                texture.GetSpriteById(property.GetChildValue<string>("m_SpriteID")),
                property,
                vectorizer
            );
        }
        static private void GenerateSpriteCollider(Sprite sprite, SerializedProperty property, SpriteVectorizer vectorizer)
        {
            property.SetChildValue("m_PhysicsShape", vectorizer.VectorizeSprite(sprite));
        }
        static private IEnumerable<SerializedProperty> GetSpriteSerializedPropertys(SerializedObject obj)
        {
            switch (obj.GetChildValue<SpriteImportMode>("m_SpriteMode"))
            {
                case SpriteImportMode.Single:
                    return obj.ForceProperty("m_SpriteSheet").WrapAsEnumerable();

                case SpriteImportMode.Multiple:
                    return obj.ForceProperty("m_SpriteSheet.m_Sprites").GetArrayElements();
            }

            return Empty.IEnumerable<SerializedProperty>();
        }
    }
}