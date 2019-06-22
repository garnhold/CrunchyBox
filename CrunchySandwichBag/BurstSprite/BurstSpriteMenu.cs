using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class BurstSpriteMenu
    {
        [MenuItem("Assets/Create Sprite/Burst")]
        static public void CreateBurstSprite()
        {
            CreateBurstSprite(Selection.activeObject as Texture2D);
        }

        [MenuItem("Assets/Create Sprite/Burst", true)]
        static public bool CreateBurstSpriteValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }

        static public BurstSprite CreateBurstSprite(Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<BurstSprite>(
                s => s.Initialize(1.0f, texture.GetSprites())
            );
        }
    }
}