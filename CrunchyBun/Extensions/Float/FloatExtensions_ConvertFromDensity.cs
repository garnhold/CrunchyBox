using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class FloatExtensions_ConvertFromDensity
    {
        static public int ConvertFromDensityToCount(this float item, float size)
        {
            float full_count = item * size;
            int int_count = (int)full_count;
            float float_count = full_count - int_count;

            if (RandChance.Get(float_count))
                int_count++;

            return int_count;
        }

        static public IEnumerable<T> ConvertDensity<T>(this float item, float size, Operation<T> operation)
        {
            return item.ConvertFromDensityToCount(size).RepeatOperation(operation);
        }

        static public void ProcessDensity(this float item, float size, Process process)
        {
            item.ConvertFromDensityToCount(size).RepeatProcess(process);
        }
    }
}