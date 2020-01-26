using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class LandRegionPainter_DualTiledOverlay : LandRegionPainter
    {
        [SerializeField]private float overlay_scale;
        [SerializeField]private Texture2D overlay_tile_texture;

        [SerializeField]private LandRegionSplat main_splat;
        [SerializeField]private LandRegionSplat secondary_splat;

        public override void InitilizeLandRegion(Land land, LandRegionType land_region_type, Palette<LandRegionSplat> palette)
        {
            palette.Add(main_splat);
            palette.Add(secondary_splat);
        }

        public override void PaintLandRegion(Land land, LandRegionType land_region_type, Grid<LandPoint> grid)
        {
            Grid<float> overlay_tile = overlay_tile_texture.CreateGrayscaleGrid();

            foreach (GridCell<LandPoint> cell in grid)
            {
                int x = (int)(cell.GetX() * overlay_scale);
                int y = (int)(cell.GetY() * overlay_scale);

                float main_weight = overlay_tile.GetDataLooped(x, y);
                float secondary_weight = 1.0f - main_weight;

                cell.GetData().PaintLandRegionSplatAlpha(land_region_type, main_splat, main_weight);
                cell.GetData().PaintLandRegionSplatAlpha(land_region_type, secondary_splat, secondary_weight);
            }
        }
    }
}