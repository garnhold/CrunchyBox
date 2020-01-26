using System;

namespace Crunchy.Dough
{    
    static public class GridExtensions_Stamp
    {
        static public Stamp<T> CreateStamp<T>(this Grid<T> item)
        {
            return new Stamp<T>(item);
        }

        static public Stamp<T> CreateStamp<T>(this Grid<T> item, VectorF2 center)
        {
            return new Stamp<T>(center, item);
        }
    }
}