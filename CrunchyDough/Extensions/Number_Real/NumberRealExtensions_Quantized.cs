using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberRealExtensions_Quantized
    {
        static public float GetQuantizedRound(this float item, float interval)
        {
            return (float)(Math.Round(item / interval) * interval);
        }
        static public double GetQuantizedRound(this double item, double interval)
        {
            return (double)(Math.Round(item / interval) * interval);
        }
        static public decimal GetQuantizedRound(this decimal item, decimal interval)
        {
            return (decimal)(Math.Round(item / interval) * interval);
        }
	}
}

