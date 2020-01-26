using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class SpectrumLookupExtensions_Lookup
    {
        static public SpectrumBand<T> LookupFirst<T>(this SpectrumLookup<T> item, float value)
        {
            return item.Lookup(value).GetFirst();
        }
    }
}