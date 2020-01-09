using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class TerrainDataExtensions_Height
    {
        static public void SetHeightGrid(this TerrainData item, int x, int y, Grid<float> grid)
        {
            item.SetHeights(x, y, grid.GetDataArray2D());
        }
        static public void SetHeightGrid(this TerrainData item, Grid<float> grid)
        {
            item.SetHeightGrid(0, 0, grid);
        }

        static public Grid<float> GetHeightGrid(this TerrainData item, int x, int y, int width, int height)
        {
            return new Grid<float>(item.GetHeights(x, y, width, height));
        }
        static public Grid<float> GetHeightGrid(this TerrainData item)
        {
            return item.GetHeightGrid(0, 0, item.heightmapWidth, item.heightmapHeight);
        }
    }
}