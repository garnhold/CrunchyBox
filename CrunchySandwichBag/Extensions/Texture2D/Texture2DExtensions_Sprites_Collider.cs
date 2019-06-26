using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class Texture2DExtensions_Sprites_Collider
    {
        static public void GenerateSpriteColliders(this Texture2D item)
        {
            item.ModifyAssetImporter(delegate(SerializedObject obj) {
                GetSpriteSerializedPropertys(obj)
                    .Process(p => GenerateSpriteCollider(item, p));
            });
        }

        static public void GenerateSpriteCollider(this Texture2D item, Sprite sprite)
        {
            item.ModifyAssetImporter(delegate(SerializedObject obj) {
                GetSpriteSerializedPropertys(obj)
                    .Narrow(p => p.GetChildValue<string>("m_SpriteID") == sprite.GetSpriteId())
                    .Process(p => GenerateSpriteCollider(item, p));
            });
        }
        
        static private void GenerateSpriteCollider(Texture2D texture, SerializedProperty property)
        {
            GenerateSpriteCollider(
                texture.GetSpriteById(property.GetChildValue<string>("m_SpriteID")),
                property
            );
        }
        static private void GenerateSpriteCollider(Sprite sprite, SerializedProperty property)
        {
            property.SetChildValue("m_PhysicsShape", SpriteVectorizer.Vectorize(sprite));
        }
        static private IEnumerable<SerializedProperty> GetSpriteSerializedPropertys(SerializedObject obj)
        {
            switch (obj.GetChildValue<SpriteImportMode>("m_SpriteMode"))
            {
                case SpriteImportMode.Single:
                    return obj.FindProperty("m_SpriteSheet").WrapAsEnumerable();

                case SpriteImportMode.Multiple:
                    return obj.FindProperty("m_SpriteSheet.m_Sprites").GetArrayElements();
            }

            return Empty.IEnumerable<SerializedProperty>();
        }

        [MenuItem("Assets/Sprite/Generate Colliders")]
        static private void GenerateSpriteColliders()
        {
            ((Texture2D)Selection.activeObject).GenerateSpriteColliders();
        }

        [MenuItem("Assets/Sprite/Generate Colliders", true)]
        static private bool GenerateSpriteCollidersValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}