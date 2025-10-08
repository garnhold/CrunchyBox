using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class NumberRealExtensions_ConvertFromOffset
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
        
        static public int ConvertFromDensityToCount(this double item, double size)
        {
            double full_count = item * size;
            int int_count = (int)full_count;
            double float_count = full_count - int_count;

            if (RandChance.Get(float_count))
                int_count++;

            return int_count;
        }

        static public IEnumerable<T> ConvertDensity<T>(this double item, double size, Operation<T> operation)
        {
            return item.ConvertFromDensityToCount(size).RepeatOperation(operation);
        }

        static public void ProcessDensity(this double item, double size, Process process)
        {
            item.ConvertFromDensityToCount(size).RepeatProcess(process);
        }
        
        static public int ConvertFromDensityToCount(this decimal item, decimal size)
        {
            decimal full_count = item * size;
            int int_count = (int)full_count;
            decimal float_count = full_count - int_count;

            if (RandChance.Get(float_count))
                int_count++;

            return int_count;
        }

        static public IEnumerable<T> ConvertDensity<T>(this decimal item, decimal size, Operation<T> operation)
        {
            return item.ConvertFromDensityToCount(size).RepeatOperation(operation);
        }

        static public void ProcessDensity(this decimal item, decimal size, Process process)
        {
            item.ConvertFromDensityToCount(size).RepeatProcess(process);
        }
        
    }
}

