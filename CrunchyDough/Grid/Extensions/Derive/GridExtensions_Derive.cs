using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Derive
    {
        static public Grid<T> Derive<T, J>(this Grid<J> item, Operation<T, GridCell<J>> operation)
        {
            return new Grid<T>(item.GetWidth(), item.GetHeight(), item.Convert(operation));
        }
    }
}