using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_Looped
    {
		static public byte GetLooped(this byte item, byte length)
        {
			if(length > 0)
			{
				item = (byte)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public short GetLooped(this short item, short length)
        {
			if(length > 0)
			{
				item = (short)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public int GetLooped(this int item, int length)
        {
			if(length > 0)
			{
				item = (int)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public long GetLooped(this long item, long length)
        {
			if(length > 0)
			{
				item = (long)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public float GetLooped(this float item, float length)
        {
			if(length > 0)
			{
				item = (float)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public double GetLooped(this double item, double length)
        {
			if(length > 0)
			{
				item = (double)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
		static public decimal GetLooped(this decimal item, decimal length)
        {
			if(length > 0)
			{
				item = (decimal)(item % length);
				if (item < 0)
					item += length;

				return item;
			}

			return 0;
        }
	}
}