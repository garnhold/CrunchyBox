using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [AssetClassCategory("Sprite")]
    public class SequencedSpriteFormat : CustomAsset
    {
        [SerializeField]private SpriteSequenceFormat[] sequence_formats;

        public SequencedSprite CreateSequencedSprite(Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<SequencedSprite>(
                Filename.SetExtension(texture.GetAssetPath(), "asset"),
                s => s.Initialize(
                    sequence_formats.Convert(f => f.CreateSpriteSequence(texture))
                )
            );
        }
    }
}