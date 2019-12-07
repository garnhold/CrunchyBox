using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Modify_ByOperation
    {
        static public void ModifyDataBetween<T>(this Grid<T> item, int x1, int y1, int x2, int y2, Operation<T, int, int> get_operation, Operation<T, T, T> operation)
        {
            item.GetCellsBetween(x1, y1, x2, y2).Process(c => c.ModifyData(get_operation(c.GetX() - x1, c.GetY() - y1), operation));
        }

        static public void ModifyDataBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height, Operation<T, int, int> get_operation, Operation<T, T, T> operation)
        {
            item.ModifyDataBetween(x, y, x + block_width, y + block_height, get_operation, operation);
        }

        static public void ModifyData<T>(this Grid<T> item, Operation<T, int, int> get_operation, Operation<T, T, T> operation)
        {
            item.ModifyDataBlock(0, 0, item.GetWidth(), item.GetHeight(), get_operation, operation);
        }
    }
}