using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberRealExtensions_Precision
    {
		static public float GetAtPrecision(this float item, int exponent)
		{
			return item.GetQuantizedMin((float)Mathq.Pow(10, exponent));
		}
		static public double GetAtPrecision(this double item, int exponent)
		{
			return item.GetQuantizedMin((double)Mathq.Pow(10, exponent));
		}
		static public decimal GetAtPrecision(this decimal item, int exponent)
		{
			return item.GetQuantizedMin((decimal)Mathq.Pow(10, exponent));
		}
	}
}