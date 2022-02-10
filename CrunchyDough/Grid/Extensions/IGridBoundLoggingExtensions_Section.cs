using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridBoundLoggingExtensions_Section
    {
        static public IGrid<T> GetBoundSubSection<T>(this IGridBoundLogging<T> item)
        {
            return item.BoundSubSection(item.GetLowerLeftBound(), item.GetUpperRightBound());
        }
    }
}