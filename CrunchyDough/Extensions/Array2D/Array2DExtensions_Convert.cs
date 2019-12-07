using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Array2DExtensions_Convert
    {
        static public T[,] ConvertTo2D<T>(this IEnumerable<T> item, int width, int height)
        {
            T[,] array = new T[width, height];

            item.ProcessWithIndex((i, s) => array[i % width, i / width] = s);
            return array;
        }

        static public IEnumerable<T> ConvertTo1D<T>(this T[,] item)
        {
            int i = 0;
            T[] array = new T[item.GetWidth() * item.GetHeight()];

            for (int y = 0; y < item.GetHeight(); y++)
            {
                for(int x = 0; x < item.GetWidth(); x++)
                    array[i++] = item[x, y];
            }

            return array;
        }
    }
}