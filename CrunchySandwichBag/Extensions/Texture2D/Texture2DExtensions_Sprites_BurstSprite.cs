using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class Texture2DExtensions_Sprites_BurstSprite
    {
        static public BurstSprite CreateBurstSprite(this Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<BurstSprite>(
                Filename.SetExtension(texture.GetAssetPath(), "asset"),
                s => s.Initialize(1.0f, texture.GetSprites())
            );
        }

        [MenuItem("Assets/Sprite/Create/Burst")]
        static private void CreateBurstSprite()
        {
            ((Texture2D)Selection.activeObject).CreateBurstSprite();
        }

        [MenuItem("Assets/Sprite/Create/Burst", true)]
        static private bool CreateBurstSpriteValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}