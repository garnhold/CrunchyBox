using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CustomAssetCategory("Sprite")]
    public class SequencedSpriteFormat : CustomAsset
    {
        [SerializeField]private SpriteSequenceFormat[] sequence_formats;

        public SequencedSprite CreateSequencedSprite(Texture2D texture)
        {
            return CustomAssets.CreateExternalCustomAsset<SequencedSprite>(s => s.Initialize(
                sequence_formats.Convert(f => f.CreateSpriteSequence(texture))
            ));
        }
    }
}