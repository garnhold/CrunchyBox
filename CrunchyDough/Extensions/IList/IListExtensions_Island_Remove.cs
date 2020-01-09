using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Island_Remove
    {
        static public void RemoveSubSection<T>(this IList<T> item, IslandInfo info)
        {
            item.RemoveSubSection(info.start, info.end);
        }
    }
}