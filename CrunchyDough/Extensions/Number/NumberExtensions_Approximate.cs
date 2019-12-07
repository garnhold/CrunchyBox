using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Approximate
    {

		static public bool IsApproximatelyEqualTo(this byte item, byte other, byte tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this short item, short other, short tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this int item, int other, int tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this long item, long other, long tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this float item, float other, float tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this double item, double other, double tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}

		static public bool IsApproximatelyEqualTo(this decimal item, decimal other, decimal tolerance)
		{
			if((item - other).GetAbs() <= tolerance)
				return true;

			return false;
		}
	}
}