using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_IEnumerable
    {
        static public IEnumerable<T> GetData<T>(this IList2D<T> item)
        {
            int height = item.GetHeight();
            int width = item.GetWidth();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    yield return item[x, y];
            }
        }

        static public IEnumerable<IList2DCell<T>> GetCells<T>(this IList2D<T> item)
        {
            int height = item.GetHeight();
            int width = item.GetWidth();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    yield return new IList2DCell<T>(x, y, item);
            }
        }

        static public IEnumerable<KeyValuePair<VectorI2, T>> GetKeyValuePairs<T>(this IList2D<T> item)
        {
            int height = item.GetHeight();
            int width = item.GetWidth();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    yield return KeyValuePair.New(new VectorI2(x, y), item[x, y]);
            }
        }
    }
}