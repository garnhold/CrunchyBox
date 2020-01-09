using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Land")]
    public abstract class LandRegionPainter : CustomAsset
    {
        public abstract void InitilizeLandRegion(Land land, LandRegionType land_region_type, Palette<LandRegionSplat> palette);
        public abstract void PaintLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid);
    }
}