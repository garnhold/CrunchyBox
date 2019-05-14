using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class LandRegionPopulater_Basic : LandRegionPopulater
    {
        public abstract IEnumerable<LandRegionPrefabPopulater> GetLandRegionPrefabPopulaters();

        public override void InitilizeLandRegion(Land land, LandRegionType land_region_type)
        {
        }

        public override void PopulateLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid, GameObject parent)
        {
            grid.Process(c =>
                GetLandRegionPrefabPopulaters().Process(pp =>
                    pp.Populate(
                        parent,
                        land.GetCellBounds(c.GetX(), c.GetY()),
                        c.GetData().GetLandRegionTypePresence(land_region_type)
                    )
                )
            );
        }
    }
}