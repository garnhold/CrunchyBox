using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CustomAssetCategory("Sprite")]
    public class SpriteSheetFormat : CustomAsset
    {
        [SerializeField]private SpriteAnimationFormat[] animation_formats;

        public SpriteSheet CreateSpriteSheet(Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<SpriteSheet>(s => s.Initialize(
                animation_formats.Convert(f => f.CreateSpriteAnimation(texture))
            ));
        }
    }
}