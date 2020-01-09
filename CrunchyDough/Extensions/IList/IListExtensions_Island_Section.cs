using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Island_Section
    {
        static public IListSubSection<T> SubSection<T>(this IList<T> item, IslandInfo info)
        {
            return item.SubSection(info.start, info.end);
        }
    }
}