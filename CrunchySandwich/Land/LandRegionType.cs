using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Land")]
    public class LandRegionType : CustomAsset
    {
        [SerializeField]private int ground_offset;

        [SerializeField]private LandRegionBuilder builder;
        [SerializeField]private LandRegionPainter painter;
        [SerializeField]private LandRegionPopulater populater;

        public void InitilizeLandRegion(Land land, Palette<LandRegionSplat> palette)
        {
            if(builder != null)
                builder.InitilizeLandRegion(land, this);

            if(painter != null)
                painter.InitilizeLandRegion(land, this, palette);

            if(populater != null)
                populater.InitilizeLandRegion(land, this);
        }

        public bool BuildLandRegion(Land land, IGrid<LandPoint> grid)
        {
            if(builder != null)
                return builder.BuildLandRegion(land, this, grid);

            return true;
        }

        public void PaintLandRegion(Land land, IGrid<LandPoint> grid)
        {
            if(painter != null)
                painter.PaintLandRegion(land, this, grid);
        }

        public void PopulateLandRegion(Land land, IGrid<LandPoint> grid, GameObject parent)
        {
            if(populater != null)
                populater.PopulateLandRegion(land, this, grid, parent.SpawnEmptyChild());
        }

        public int GetGroundOffset()
        {
            return ground_offset;
        }
    }
}