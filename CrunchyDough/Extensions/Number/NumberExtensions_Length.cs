using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Length
    {

		static public int GetWholeComponentLength(this byte item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this short item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this int item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this long item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this float item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this double item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}

		static public int GetWholeComponentLength(this decimal item)
		{
			return (int)(Math.Log10((double)item)) + 1;
		}
	}
}