using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_List
    {
        static public void AddData<T>(this Grid<List<T>> item, int x, int y, T value)
        {
            item.GetOrCreateData(x, y, () => new List<T>()).Add(value);
        }

        static public IEnumerable<T> GetDatas<T>(this Grid<List<T>> item, int x, int y)
        {
            List<T> list;

            if (item.TryGetData(x, y, out list))
                return list;

            return Empty.IEnumerable<T>();
        }
    }
}