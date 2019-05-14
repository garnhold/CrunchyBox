using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class SpectrumLookupExtensions_Data
    {
        static public IEnumerable<T> LookupData<T>(this SpectrumLookup<T> item, float value)
        {
            return item.Lookup(value).Convert(b => b.GetData());
        }

        static public T LookupFirstData<T>(this SpectrumLookup<T> item, float value)
        {
            return item.LookupData(value).GetFirst();
        }
    }
}