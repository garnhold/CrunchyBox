using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    public interface SpectrumLookup<T>
    {
        float GetLowerBound();
        float GetUpperBound();

        IEnumerable<SpectrumBand<T>> Lookup(float value);
    }
}