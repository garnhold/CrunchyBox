using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class LandRegionBuilder_Topographic_AngleBand : LandRegionBuilder_Topographic
    {
        [SerializeField]ValueCurve strength_curve;

        public override float CalculateLandRegionTypeStrength(TerrainSample terrain_sample)
        {
            return strength_curve.GetValue(terrain_sample.GetSurfaceAngle());
        }
    }
}