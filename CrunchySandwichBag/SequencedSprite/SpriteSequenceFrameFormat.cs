using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
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