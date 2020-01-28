using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class LandRegionPainter_Basic : LandRegionPainter
    {
        public abstract IEnumerable<LandRegionSplat> GetLandRegionSplats();

        public override void InitilizeLandRegion(Land land, LandRegionType land_region_type, Palette<LandRegionSplat> palette)
        {
            palette.AddRange(GetLandRegionSplats());
        }

        public override void PaintLandRegion(Land land, LandRegionType land_region_type, IGrid<LandPoint> grid)
        {
            grid.Process(p =>
                GetLandRegionSplats().Process(s => p.PaintLandRegionSplatAlpha(land_region_type, s))
            );
        }
    }
}