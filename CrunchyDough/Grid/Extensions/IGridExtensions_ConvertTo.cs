using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_ConvertTo
    {
        static public IEnumerable<T> ConvertToData<T>(this IGrid<T> item)
        {
            if (item != null)
            {
                int width = item.GetWidth();
                int height = item.GetHeight();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                        yield return item[x, y];
                }
            }
        }

        static public IEnumerable<OUTPUT_TYPE> ConvertToData<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            return item.Convert(operation).ConvertToData();
        }

        static public IEnumerable<OUTPUT_TYPE> ConvertWithIndexsToData<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, int, INPUT_TYPE> operation)
        {
            return item.ConvertWithIndexs(operation).ConvertToData();
        }

        static public IEnumerable<OUTPUT_TYPE> ConvertWithIndexsToData<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, VectorI2, INPUT_TYPE> operation)
        {
            return item.ConvertWithIndexs(operation).ConvertToData();
        }

        static public IEnumerable<KeyValuePair<VectorI2, T>> ConvertToKeyValuePairs<T>(this IGrid<T> item)
        {
            return item.ConvertWithIndexsToData((i, v) => KeyValuePair.New(i, v));
        }
    }
}