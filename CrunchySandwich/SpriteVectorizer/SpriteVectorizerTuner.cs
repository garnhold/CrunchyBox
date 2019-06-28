using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class SpriteVectorizerTuner
    {
        [SerializeField]private Sprite sprite;

        [SerializeField]private float line_thickness = 1.0f;
        [SerializeField]private float point_size = 0.0f;

        public SpriteVectorizerTuner(Sprite s, float l, float p)
        {
            sprite = s;

            line_thickness = l;
            point_size = p;
        }

        public SpriteVectorizerTuner() : this(null, 1.0f, 0.0f) { }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public float GetLineThickness()
        {
            return line_thickness;
        }

        public float GetPointSize()
        {
            return point_size;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + sprite.GetHashCodeEX();
                hash = hash * 23 + line_thickness.GetHashCodeEX();
                hash = hash * 23 + point_size.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            SpriteVectorizerTuner cast;

            if (obj.Convert<SpriteVectorizerTuner>(out cast))
            {
                if (cast.sprite == sprite)
                {
                    if (cast.line_thickness == line_thickness)
                    {
                        if (cast.point_size == point_size)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}