using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Get
    {
        static public T GetData<T>(this Grid<T> item, int x, int y)
        {
            T data;

            item.TryGetData(x, y, out data);
            return data;
        }
        static public T GetData<T>(this Grid<T> item, int x, int y, T default_value)
        {
            T data;

            if (item.TryGetData(x, y, out data))
                return data;

            return default_value;
        }

        static public IEnumerable<T> GetDataBetween<T>(this Grid<T> item, int x1, int y1, int x2, int y2)
        {
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                    yield return item.GetData(x, y);
            }
        }
        static public IEnumerable<T> GetDataBetween<T>(this Grid<T> item, int x1, int y1, int x2, int y2, T default_value)
        {
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                    yield return item.GetData(x, y, default_value);
            }
        }
    }
}