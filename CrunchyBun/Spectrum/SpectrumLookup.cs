using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public interface SpectrumLookup<T>
    {
        float GetLowerBound();
        float GetUpperBound();

        IEnumerable<SpectrumBand<T>> Lookup(float value);
    }
}