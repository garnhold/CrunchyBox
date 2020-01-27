using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class LandRegionBuilder_Topographic : LandRegionBuilder
    {
        public abstract float CalculateLandRegionTypeStrength(TerrainSample terrain_sample);

        public override void InitilizeLandRegion(Land land, LandRegionType land_region_type)
        {
        }

        public override bool BuildLandRegion(Land land, LandRegionType land_region_type, IGrid<LandPoint> grid)
        {
            grid.GetData().Process(p =>
                p.PaintLandRegionTypeStrength(land_region_type, CalculateLandRegionTypeStrength(p.GetTerrainSample()))
            );

            return true;
        }
    }
}