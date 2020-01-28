using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ISparseGridExtensions_Has
    {
        static public bool HasIndex<T>(this ISparseGrid<T> item, VectorI2 index)
        {
            return item.HasIndex(index.x, index.y);
        }
    }
}