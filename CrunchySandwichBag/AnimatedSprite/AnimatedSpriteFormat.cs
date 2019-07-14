﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [AssetClassCategory("Sprite")]
    public class AnimatedSpriteFormat : CustomAsset
    {
        [SerializeField]private SpriteAnimationFormat[] animation_formats;

        public AnimatedSprite CreateAnimatedSprite(Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<AnimatedSprite>(
                Filename.SetExtension(texture.GetAssetPath(), "asset"),
                s => s.Initialize(
                    animation_formats.Convert(f => f.CreateSpriteAnimation(texture))
                )
            );
        }
    }
}