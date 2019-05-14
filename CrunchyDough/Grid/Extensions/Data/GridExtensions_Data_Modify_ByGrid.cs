using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Data_Modify_ByGrid
    {
        static public void ModifyDataBlock<T>(this Grid<T> item, int dst_x, int dst_y, int src_x, int src_y, int width, int height, Grid<T> src, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(dst_x, dst_y, width, height, delegate(int x, int y) {
                return src.GetData(x + src_x, y + src_y);
            }, operation);
        }

        static public void ModifyDataBlock<T>(this Grid<T> item, int x, int y, Grid<T> src, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(x, y, 0, 0, src.GetWidth(), src.GetHeight(), src, operation);
        }

        static public void ModifyData<T>(this Grid<T> item, Grid<T> src, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(0, 0, src, operation);
        }
    }
}