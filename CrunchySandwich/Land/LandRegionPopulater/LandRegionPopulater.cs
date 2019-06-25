using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Land")]
    public abstract class LandRegionPopulater : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type);
        public abstract void PopulateLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid, GameObject parent);
    }
}