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
    static public class Texture2DExtensions_Sprites_AnimatedSprite
    {
        static public AnimatedSprite CreateSimpleAnimatedSprite(this Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<AnimatedSprite>(
                Filename.SetExtension(texture.GetAssetPath(), "asset"),
                s => s.Initialize(new SpriteAnimation(texture.GetSprites()))
            );
        }

        [MenuItem("Assets/Sprite/Create/Animated/Simple")]
        static private void CreateSimpleAnimatedSprite()
        {
            ((Texture2D)Selection.activeObject).CreateSimpleAnimatedSprite();
        }

        [MenuItem("Assets/Sprite/Create/Animated/Simple", true)]
        static private bool CreateAnimatedSpriteValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}