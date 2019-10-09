using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public struct TerrainSubTile
    {
        [SerializeField]private NeighborMask mask;
        [SerializeField]private Sprite sprite;

        public TerrainSubTile(NeighborMask m, Sprite s)
        {
            mask = m;
            sprite = s;
        }

        public NeighborMask GetMask()
        {
            return mask;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + mask.GetHashCodeEX();
                hash = hash * 23 + sprite.GetHashCodeEX();
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
                        return true;
                }
            }

            return false;
        }
    }
}