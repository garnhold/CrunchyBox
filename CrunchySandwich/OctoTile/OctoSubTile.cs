using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [Serializable]
    public class OctoSubTile
    {
        [SerializeField]private OctoMask mask;
        [SerializeField]private Sprite sprite;

        [SerializeField]private float weight = 1.0f;

        public OctoSubTile(OctoMask m, Sprite s, float w)
        {
            mask = m;
            sprite = s;

            weight = w;
        }

        public OctoSubTile(Sprite s) : this(new OctoMask(), s, 1.0f) { }
        public OctoSubTile() : this(null) { }

        public OctoMask GetMask()
        {
            return mask;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public float GetWeight()
        {
            return weight;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + mask.GetHashCodeEX();
                hash = hash * 23 + sprite.GetHashCodeEX();
                hash = hash * 23 + weight.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            OctoSubTile cast;

            if (obj.Convert<OctoSubTile>(out cast))
            {
                if (cast.mask.EqualsEX(mask))
                {
                    if (cast.sprite.EqualsEX(sprite))
                    {
                        if (cast.weight.EqualsEX(weight))
                            return true;
                    }
                }
            }

            return false;
        }
    }
}