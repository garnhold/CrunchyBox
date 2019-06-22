using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class SpriteSequenceFrame
    {
        [SerializeField]private float value;
        [SerializeField]private Sprite sprite;

        public SpriteSequenceFrame()
        {
        }

        public SpriteSequenceFrame(float v, Sprite s)
        {
            value = v;
            sprite = s;
        }

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