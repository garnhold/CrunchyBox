using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class LandRegionBuilder_Topographic_AngleBand : LandRegionBuilder_Topographic
    {
        [SerializeField]ValueCurve strength_curve;

        public override float CalculateLandRegionTypeStrength(TerrainSample terrain_sample)
        {
            return strength_curve.GetValue(terrain_sample.GetSurfaceAngle());
        }
    }
}