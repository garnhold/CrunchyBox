using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface IList2D<T>
    {
        int GetWidth();
        int GetHeight();

        T this[int x, int y] { get; set; }
    }
}