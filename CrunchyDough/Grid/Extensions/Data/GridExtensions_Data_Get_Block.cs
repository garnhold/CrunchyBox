using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Get_Block
    {
        static public IEnumerable<T> GetDataBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height)
        {
            return item.GetDataBetween(x, y, x + block_width, y + block_height);
        }
    }
}