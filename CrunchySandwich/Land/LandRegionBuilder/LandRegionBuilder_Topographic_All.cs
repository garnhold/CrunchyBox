using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class LandRegionBuilder_Topographic_All : LandRegionBuilder_Topographic
    {
        [SerializeField]private float strength;

        public override float CalculateLandRegionTypeStrength(TerrainSample terrain_sample)
        {
            return strength;
        }
    }
}