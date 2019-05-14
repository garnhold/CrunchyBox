using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Data_Set_ByGrid
    {
        static public void SetDataBlock<T>(this Grid<T> item, int dst_x, int dst_y, int src_x, int src_y, int width, int height, Grid<T> src)
        {
            item.SetDataBlock(dst_x, dst_y, width, height, delegate(int x, int y) {
                return src.GetData(x + src_x, y + src_y);
            });
        }

        static public void SetDataBlock<T>(this Grid<T> item, int x, int y, Grid<T> src)
        {
            item.SetDataBlock(x, y, 0, 0, src.GetWidth(), src.GetHeight(), src);
        }
    }
}