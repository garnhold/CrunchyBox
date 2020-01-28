using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface ISparseGrid<T> : IGrid<T>
    {
        bool HasIndex(int x, int y);

        IEnumerable<VectorI2> GetIndexs();
    }
}