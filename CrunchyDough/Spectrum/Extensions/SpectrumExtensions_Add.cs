using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class SpectrumExtensions_Add
    {
        static public void Add<T>(this Spectrum<T> item, IEnumerable<SpectrumBand<T>> to_add)
        {
            to_add.Process(b => item.Add(b));
        }
        static public void Add<T>(this Spectrum<T> item, params SpectrumBand<T>[] to_add)
        {
            item.Add((IEnumerable<SpectrumBand<T>>)to_add);
        }
    }
}