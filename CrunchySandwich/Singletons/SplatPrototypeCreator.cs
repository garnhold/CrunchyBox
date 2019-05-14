using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class SplatPrototypeCreator
    {
        static public SplatPrototype Create(Texture2D color_texture, Texture2D normal_texture, float metallic, float smoothness, Vector2 tile_size, Vector2 tile_offset)
        {
            SplatPrototype splat_prototype = new SplatPrototype();

            splat_prototype.texture = color_texture;
            splat_prototype.normalMap = normal_texture;

            splat_prototype.metallic = metallic;
            splat_prototype.smoothness = smoothness;

            splat_prototype.tileSize = tile_size;
            splat_prototype.tileOffset = tile_offset;

            return splat_prototype;
        }
    }
}