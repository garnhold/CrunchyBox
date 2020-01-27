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

        public override void PaintLandRegion(Land land, LandRegionType land_region_type, IGrid<LandPoint> grid)
        {
            IGrid<float> overlay_tile = overlay_tile_texture.CreateGrayscaleGrid();

            grid.ProcessWithIndexs(delegate (int x, int y, LandPoint point) {
                float main_weight = overlay_tile.GetLooped((int)(x * overlay_scale), (int)(y * overlay_scale));
                float secondary_weight = 1.0f - main_weight;

                point.PaintLandRegionSplatAlpha(land_region_type, main_splat, main_weight);
                point.PaintLandRegionSplatAlpha(land_region_type, secondary_splat, secondary_weight);
            });
        }
    }
}