using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [Serializable]
    public class SpriteAnimationFormat
    {
        [SerializeField]private string name;
        [SerializeField]private float duration;
        [SerializeField]private int[] indexs;

        public SpriteAnimation CreateSpriteAnimation(Texture2D texture)
        {
            return new SpriteAnimation(name, duration, texture.GetSprites().ToArray().AtIndexs(indexs));
        }
    }
}