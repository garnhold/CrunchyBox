using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Quantized
    {
		static public byte GetQuantizedMin(this byte item, byte interval)
        {
			return (byte)((int)(item / interval) * interval);
        }
		static public short GetQuantizedMin(this short item, short interval)
        {
			return (short)((int)(item / interval) * interval);
        }
		static public int GetQuantizedMin(this int item, int interval)
        {
			return (int)((int)(item / interval) * interval);
        }
		static public long GetQuantizedMin(this long item, long interval)
        {
			return (long)((int)(item / interval) * interval);
        }
		static public float GetQuantizedMin(this float item, float interval)
        {
			return (float)((int)(item / interval) * interval);
        }
		static public double GetQuantizedMin(this double item, double interval)
        {
			return (double)((int)(item / interval) * interval);
        }
		static public decimal GetQuantizedMin(this decimal item, decimal interval)
        {
			return (decimal)((int)(item / interval) * interval);
        }
	}
}