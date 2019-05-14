using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberExtensions_Looped
    {
		static public byte GetLooped(this byte item, byte length)
        {
            item = (byte)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public short GetLooped(this short item, short length)
        {
            item = (short)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public int GetLooped(this int item, int length)
        {
            item = (int)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public long GetLooped(this long item, long length)
        {
            item = (long)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public float GetLooped(this float item, float length)
        {
            item = (float)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public double GetLooped(this double item, double length)
        {
            item = (double)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
		static public decimal GetLooped(this decimal item, decimal length)
        {
            item = (decimal)(item % length);
            if (item < 0)
                item += length;

            return item;
        }
	}
}