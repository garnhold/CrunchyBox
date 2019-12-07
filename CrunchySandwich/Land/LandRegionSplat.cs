using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [AssetClassCategory("Land")]
    public class LandRegionSplat : CustomAsset
    {
        [SerializeField]private Texture2D color_texture;
        [SerializeField]private Texture2D normal_texture;

        [SerializeField]private float alpha;
        [SerializeField]private float metallic;
        [SerializeField]private float smoothness;

        [SerializeField]private Vector2 tile_size;
        [SerializeField]private Vector2 tile_offset;

        public SplatPrototype GetSplatPrototype()
        {
            return SplatPrototypeCreator.Create(color_texture, normal_texture, metallic, smoothness, tile_size, tile_offset);
        }

        public Texture2D GetColorTexture()
        {
            return color_texture;
        }

        public Texture2D GetNormalTexture()
        {
            return normal_texture;
        }

        public float GetAlpha()
        {
            return alpha;
        }

        public float GetAlphaAt(LandPoint land_point)
        {
            return alpha * land_point.GetLandRegionSplatAlpha(this);
        }

        public float GetMetallic()
        {
            return metallic;
        }

        public float GetSmoothness()
        {
            return smoothness;
        }

        public Vector2 GetTileSize()
        {
            return tile_size;
        }

        public Vector2 GetTileOffset()
        {
            return tile_offset;
        }
    }
}