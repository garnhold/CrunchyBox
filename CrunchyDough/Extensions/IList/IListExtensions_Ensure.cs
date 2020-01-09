using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Ensure
    {
        static public void EnsureIndexWithEmptys<T>(this IList<T> item, int index)
        {
            item.EnsureSizeWithEmptys(index + 1);
        }
    }
}