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

        public NeighborMask GetMask()
        {
            return mask;
        }

        public Sprite GetSprite()
        {
            return sprite;
        }
    }
}