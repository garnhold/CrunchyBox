using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class LandRegionPopulater_Basic : LandRegionPopulater
    {
        public abstract IEnumerable<LandRegionPrefabPopulater> GetLandRegionPrefabPopulaters();

        public override void InitilizeLandRegion(Land land, LandRegionType land_region_type)
        {
        }

        public override void PopulateLandRegion(Land land, LandRegionType land_region_type, IList2D<LandPoint> grid, GameObject parent)
        {
            grid.ProcessWithIndexs(delegate (int x, int y, LandPoint point) {
                GetLandRegionPrefabPopulaters().Process(pp => 
                    pp.Populate(
                        parent,
                        land.GetCellBounds(x, y),
                        point.GetLandRegionTypePresence(land_region_type)
                    )
                );
            });
        }
    }
}