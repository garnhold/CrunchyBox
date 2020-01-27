using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class List2D
    {
        static public IList2D<T> Operation<T>(int width, int height, Operation<T, int, int> operation)
        {
            return new IList2DTransform<T>(width, height, operation);
        }
    }
}