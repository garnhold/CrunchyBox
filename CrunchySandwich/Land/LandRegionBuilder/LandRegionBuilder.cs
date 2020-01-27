using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Land")]
    public abstract class LandRegionBuilder : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type);
        public abstract bool BuildLandRegion(Land land, LandRegionType land_region_type, IGrid<LandPoint> grid);
    }
}