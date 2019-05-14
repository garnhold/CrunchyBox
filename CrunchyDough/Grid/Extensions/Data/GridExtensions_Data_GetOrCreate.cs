using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Data_GetOrCreate
    {
        static public T GetOrCreateData<T>(this Grid<T> item, int x, int y, Operation<T, int, int> operation)
        {
            GridCell<T> cell;

            if (item.TryGetCell(x, y, out cell))
            {
                if (cell.GetData().IsNull())
                    cell.SetData(operation(x, y));

                return cell.GetData();
            }

            return default(T);
        }
        static public T GetOrCreateData<T>(this Grid<T> item, int x, int y, Operation<T> operation)
        {
            return item.GetOrCreateData(x, y, (p1, p2) => operation());
        }
    }
}