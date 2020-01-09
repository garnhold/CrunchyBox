using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_ConvertFromRate
    {
        static public int ConvertFromRateToCount(this float item, float time)
        {
            return item.ConvertFromDensityToCount(time);
        }

        static public IEnumerable<T> ConvertRate<T>(this float item, float time, Operation<T> operation)
        {
            return item.ConvertDensity(time, operation);
        }

        static public void ProcessRate(this float item, float time, Process process)
        {
            item.ProcessDensity(time, process);
        }
    }
}