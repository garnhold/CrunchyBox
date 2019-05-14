using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [CustomAssetCategory("Land")]
    public abstract class LandRegionPainter : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type, Palette<LandRegionSplat> palette);
        public abstract void PaintLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid);
    }
}