using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Get_All
    {
        static public IEnumerable<T> GetData<T>(this Grid<T> item)
        {
            return item.Convert(c => c.GetData());
        }
    }
}