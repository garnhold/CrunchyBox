using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class TerrainDataExtensions_Sample
    {
        static public TerrainSample GetSample(this TerrainData item, float x, float y)
        {
            return new TerrainSample(
                item.GetInterpolatedHeight(x, y),
                item.GetInterpolatedNormal(x, y)
            );
        }

        static public IList2D<TerrainSample> ConvertToSampleGrid(this TerrainData item, int width, int height)
        {
            float dx = 1.0f / width;
            float dy = 1.0f / height;

            return new IList2DTransform<TerrainSample>(
                () => width,
                () => height,
                (x, y) => item.GetSample(x * dx, y * dy)
            );
        }

        static public IList2D<TerrainSample> ConvertToSampleGridWithHeightMapDimensions(this TerrainData item)
        {
            return item.ConvertToSampleGrid(item.heightmapWidth, item.heightmapHeight);
        }

        static public IList2D<TerrainSample> ConvertToSampleGridWithAlphaMapDimensions(this TerrainData item)
        {
            return item.ConvertToSampleGrid(item.alphamapWidth, item.alphamapHeight);
        }
    }
}