using System;

namespace CrunchyDough
{
    static public class Array2DExtensions_Get
    {
        static public bool TryGet<T>(this T[,] item, int x, int y, out T value)
        {
            if (x >= 0 && x < item.GetWidth())
            {
                if (y >= 0 && y < item.GetHeight())
                {
                    value = item[x, y];
                    return true;
                }
            }

            value = default(T);
            return false;
        }

        static public T Get<T>(this T[,] item, int x, int y)
        {
            T value;

            item.TryGet(x, y, out value);
            return value;
        }

        static public T Get<T>(this T[,] item, int x, int y, T default_value)
        {
            T value;

            if (item.TryGet(x, y, out value))
                return value;

            return default_value;
        }
    }
}