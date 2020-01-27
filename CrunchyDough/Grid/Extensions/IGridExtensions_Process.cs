using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Process
    {
        static public void ProcessWithIndexs<T>(this IGrid<T> item, Process<int, int, T> process)
        {
            for (int y = 0; y < item.GetHeight(); y++)
            {
                for (int x = 0; x < item.GetWidth(); x++)
                    process(x, y, item[x, y]);
            }
        }
        static public void ProcessWithIndexs<T>(this IGrid<T> item, Process<VectorI2, T> process)
        {
            item.ProcessWithIndexs<T>((x, y, v) => process(new VectorI2(x, y), v));
        }
    }
}