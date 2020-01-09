using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [Serializable]
    public class SpriteSequenceFrame
    {
        [SerializeField]private float value;
        [SerializeField]private Sprite sprite;

        public SpriteSequenceFrame(float v, Sprite s)
        {
            value = v;
            sprite = s;
        }

        public SpriteSequenceFrame(Sprite s) : this(1.0f, s) { }
        public SpriteSequenceFrame() : this(null) { }

        public float GetValue()
        {
            return value;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }
    }
}