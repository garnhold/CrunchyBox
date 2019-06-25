using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Land")]
    public abstract class LandRegionBuilder : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type);
        public abstract bool BuildLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid);
    }
}