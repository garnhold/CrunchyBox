using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Land")]
    public abstract class LandRegionPopulater : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type);
        public abstract void PopulateLandRegion(Land land, LandRegionType land_region_type, IList2D<LandPoint> grid, GameObject parent);
    }
}