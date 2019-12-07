using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Modify_ByIEnumerable
    {
        static public void ModifyDataBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height, IEnumerable<T> data, Operation<T, T, T> operation)
        {
            data.ProcessWithIndex((i, d) => item.ModifyData(
                x + i % block_width,
                y + i / block_width,
                d,
                operation
            ));
        }

        static public void ModifyData<T>(this Grid<T> item, IEnumerable<T> data, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(0, 0, item.GetWidth(), item.GetHeight(), data, operation);
        }
    }
}