using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Set_ByArray2D
    {
        static public void SetDataBlock<T>(this Grid<T> item, int dst_x, int dst_y, int src_x, int src_y, int width, int height, T[,] data)
        {
            item.SetDataBlock(dst_x, dst_y, width, height, delegate(int x, int y) {
                return data.Get(x + src_x, y + src_y);
            });
        }

        static public void SetDataBlock<T>(this Grid<T> item, int x, int y, T[,] data)
        {
            item.SetDataBlock(x, y, 0, 0, data.GetWidth(), data.GetHeight(), data);
        }

        static public void SetData<T>(this Grid<T> item, T[,] data)
        {
            item.SetDataBlock(0, 0, data);
        }
    }
}