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
            item.ModifyAllSprites(p => GenerateSpriteCollider(item, p, vectorizer));
        }

        static public void GenerateSpriteCollider(this Texture2D item, Sprite sprite, SpriteVectorizer vectorizer)
        {
            item.ModifySprite(sprite, p => GenerateSpriteCollider(item, p, vectorizer));
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
    }
}