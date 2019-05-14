using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class TerrainDataExtensions_Sample
    {
        static public TerrainSample GetSample(this TerrainData item, float x, float y)
        {
            return new TerrainSample(
                item.GetInterpolatedHeight(x, y),
                item.GetInterpolatedNormal(x, y)
            );
        }

        static public Grid<TerrainSample> GetSampleGrid(this TerrainData item, float x, float y, int width, int height, float dx, float dy)
        {
            return new Grid<TerrainSample>(width, height, delegate(int ix, int iy) {
                return item.GetSample(x + ix*dx, y + iy*dy);
            });
        }

        static public Grid<TerrainSample> GetSampleGrid(this TerrainData item, int width, int height)
        {
            return item.GetSampleGrid(0.0f, 0.0f, width, height, 1.0f / width, 1.0f / height);
        }

        static public Grid<TerrainSample> GetSampleGridWithHeightMapDimensions(this TerrainData item)
        {
            return item.GetSampleGrid(item.heightmapWidth, item.heightmapHeight);
        }

        static public Grid<TerrainSample> GetSampleGridWithAlphaMapDimensions(this TerrainData item)
        {
            return item.GetSampleGrid(item.alphamapWidth, item.alphamapHeight);
        }
    }
}