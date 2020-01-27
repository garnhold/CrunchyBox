using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class TerrainDataExtensions_Height
    {
        static public void SetHeightGrid(this TerrainData item, int x, int y, IGrid<float> grid)
        {
            item.SetHeights(x, y, grid.ToArray2D());
        }
        static public void SetHeightGrid(this TerrainData item, IGrid<float> grid)
        {
            item.SetHeightGrid(0, 0, grid);
        }

        static public IGrid<float> GetHeightGrid(this TerrainData item, int x, int y, int width, int height)
        {
            return item.GetHeights(x, y, width, height).ConvertToIGrid();
        }
        static public IGrid<float> GetHeightGrid(this TerrainData item)
        {
            return item.GetHeightGrid(0, 0, item.heightmapWidth, item.heightmapHeight);
        }
    }
}