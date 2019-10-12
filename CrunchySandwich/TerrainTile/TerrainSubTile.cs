using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public class TerrainSubTile
    {
        [SerializeField]private NeighborMask mask;
        [SerializeField]private Sprite sprite;

        [SerializeField]private float weight = 1.0f;

        public TerrainSubTile(NeighborMask m, Sprite s, float w)
        {
            mask = m;
            sprite = s;

            weight = w;
        }

        public TerrainSubTile(Sprite s) : this(new NeighborMask(), s, 1.0f) { }
        public TerrainSubTile() : this(null) { }

        public NeighborMask GetMask()
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
            TerrainSubTile cast;

            if (obj.Convert<TerrainSubTile>(out cast))
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