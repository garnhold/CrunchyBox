using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Get_Looped
    {
        static public T GetDataLooped<T>(this Grid<T> item, int x, int y)
        {
            return item.GetData(x.GetLooped(item.GetWidth()), y.GetLooped(item.GetHeight()));
        }
    }
}