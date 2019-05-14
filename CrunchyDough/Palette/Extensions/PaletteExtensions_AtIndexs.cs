using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class PaletteExtensions_AtIndexs
    {
        static public IEnumerable<T> AtIndexs<T>(this Palette<T> item, IEnumerable<int> indexs)
        {
            return indexs.Convert(i => item.GetValue(i));
        }
        static public IEnumerable<T> AtIndexs<T>(this Palette<T> item, params int[] indexs)
        {
            return item.AtIndexs((IEnumerable<int>)indexs);
        }
    }
}