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
    static public class Texture2DExtensions_Sprites_SequencedSprite
    {
        static public SequencedSprite CreateSimpleSequencedSprite(this Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<SequencedSprite>(
                Filename.SetExtension(texture.GetAssetPath(), "asset"),
                s => s.Initialize(new SpriteSequence(texture.GetSprites()))
            );
        }

        [MenuItem("Assets/Sprite/Create/Sequenced/Simple")]
        static private void CreateSimpleSequencedSprite()
        {
            ((Texture2D)Selection.activeObject).CreateSimpleSequencedSprite();
        }

        [MenuItem("Assets/Sprite/Create/Sequenced/Simple", true)]
        static private bool CreateSequencedSpriteValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}