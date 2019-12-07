using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Modify_ByArray2D
    {
        static public void ModifyDataBlock<T>(this Grid<T> item, int dst_x, int dst_y, int src_x, int src_y, int width, int height, T[,] data, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(dst_x, dst_y, width, height, delegate(int x, int y) {
                return data.Get(x + src_x, y + src_y);
            }, operation);
        }

        static public void ModifyDataBlock<T>(this Grid<T> item, int x, int y, T[,] data, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(x, y, 0, 0, data.GetWidth(), data.GetHeight(), data, operation);
        }

        static public void ModifyData<T>(this Grid<T> item, T[,] data, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(0, 0, data, operation);
        }
    }
}