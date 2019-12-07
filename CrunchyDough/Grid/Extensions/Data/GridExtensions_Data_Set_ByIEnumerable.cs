using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Set_ByIEnumerable
    {
        static public void SetDataBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height, IEnumerable<T> data)
        {
            data.ProcessWithIndex((i, d) => item.SetData(
                x + i % block_width,
                y + i / block_width,
                d
            ));
        }

        static public void SetData<T>(this Grid<T> item, IEnumerable<T> data)
        {
            item.SetDataBlock(0, 0, item.GetWidth(), item.GetHeight(), data);
        }
    }
}