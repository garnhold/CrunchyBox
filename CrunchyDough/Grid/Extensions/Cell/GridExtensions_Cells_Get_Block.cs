using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Cells_Get_Block
    {
        static public IEnumerable<GridCell<T>> GetCellBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height)
        {
            return item.GetCellsBetween(x, y, x + block_width, y + block_height);
        }
    }
}