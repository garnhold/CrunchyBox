using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Data_Set_ByOperation
    {
        static public void SetDataBetween<T>(this Grid<T> item, int x1, int y1, int x2, int y2, Operation<T, int, int> operation)
        {
            item.GetCellsBetween(x1, y1, x2, y2).Process(c => c.SetData(operation(c.GetX() - x1, c.GetY() - y1)));
        }

        static public void SetDataBlock<T>(this Grid<T> item, int x, int y, int block_width, int block_height, Operation<T, int, int> operation)
        {
            item.SetDataBetween(x, y, x + block_width, y + block_height, operation);
        }

        static public void SetData<T>(this Grid<T> item, Operation<T, int, int> operation)
        {
            item.SetDataBlock(0, 0, item.GetWidth(), item.GetHeight(), operation);
        }
    }
}