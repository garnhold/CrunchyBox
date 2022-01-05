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
        [SerializeField]private float slope;
        [SerializeField]private Sprite sprite;

        public SpriteSequenceFrame(float v, float m, Sprite s)
        {
            value = v;
            slope = m;
            sprite = s;
        }

        public SpriteSequenceFrame(Sprite s) : this(1.0f, 0.0f, s) { }
        public SpriteSequenceFrame() : this(null) { }

        public bool IsSloped()
        {
            if (slope != 0.0f)
                return true;

            return false;
        }

        public float GetValue()
        {
            return value;
        }

        public float GetSlope()
        {
            return slope;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }
    }
}