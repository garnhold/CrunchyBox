using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CustomAssetCategory("Sprite")]
    public class SpriteAnimationFormat : CustomAsset
    {
        [SerializeField]private string name;
        [SerializeField]private int[] indexs;

        public SpriteAnimation CreateSpriteAnimation(Texture2D texture)
        {
            return CustomAssets.CreateInternalCustomAsset<SpriteAnimation>(a => a.Initialize(
                name,
                texture.GetSprites().ToArray().AtIndexs(indexs)
            ));
        }
    }
}