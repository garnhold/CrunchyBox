using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberConvertExtensions
    {
			static public byte GetBytePercent(this float item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this float item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this float item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public long GetLongPercent(this float item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
				static public byte GetBytePercent(this double item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this double item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this double item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public long GetLongPercent(this double item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
				static public byte GetBytePercent(this decimal item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this decimal item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this decimal item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public long GetLongPercent(this decimal item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
	
			static public float GetFloatPercent(this byte item)
		{
			return (float)item / byte.MaxValue;

		}
			static public double GetDoublePercent(this byte item)
		{
			return (double)item / byte.MaxValue;

		}
			static public decimal GetDecimalPercent(this byte item)
		{
			return (decimal)item / byte.MaxValue;

		}
				static public float GetFloatPercent(this short item)
		{
			return (float)item / short.MaxValue;

		}
			static public double GetDoublePercent(this short item)
		{
			return (double)item / short.MaxValue;

		}
			static public decimal GetDecimalPercent(this short item)
		{
			return (decimal)item / short.MaxValue;

		}
				static public float GetFloatPercent(this int item)
		{
			return (float)item / int.MaxValue;

		}
			static public double GetDoublePercent(this int item)
		{
			return (double)item / int.MaxValue;

		}
			static public decimal GetDecimalPercent(this int item)
		{
			return (decimal)item / int.MaxValue;

		}
				static public float GetFloatPercent(this long item)
		{
			return (float)item / long.MaxValue;

		}
			static public double GetDoublePercent(this long item)
		{
			return (double)item / long.MaxValue;

		}
			static public decimal GetDecimalPercent(this long item)
		{
			return (decimal)item / long.MaxValue;

		}
		}
}
