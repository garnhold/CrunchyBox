using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [Serializable]
    public class SpriteSequenceFrameFormat
    {
        [SerializeField]private int index;
        [SerializeField]private float value;

        public SpriteSequenceFrame CreateSpriteSequenceFrame(Texture2D texture)
        {
            return new SpriteSequenceFrame(value, texture.GetSprites().Get(index));
        }
    }
}