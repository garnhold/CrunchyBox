using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberExtensions_Operations
    {
		static public int GetAbs(this int item)
		{
			if(item < 0)
				return -item;

			return item;
		}

		static public int GetPositive(this int item)
		{
			return item.GetAbs();
		}

		static public int GetNegative(this int item)
		{
			return -item.GetAbs();
		}

		static public int GetSquared(this int item)
		{
			return item * item;
		}

		static public int GetTowards(this int item, int target, int amount)
		{
			if(item < target)
			{
				item += amount;

				if(item < target)
					return item;
			}
			else
			{
				item -= amount;

				if(item > target)
					return item;
			}

			return target;
		}
		static public long GetAbs(this long item)
		{
			if(item < 0)
				return -item;

			return item;
		}

		static public long GetPositive(this long item)
		{
			return item.GetAbs();
		}

		static public long GetNegative(this long item)
		{
			return -item.GetAbs();
		}

		static public long GetSquared(this long item)
		{
			return item * item;
		}

		static public long GetTowards(this long item, long target, long amount)
		{
			if(item < target)
			{
				item += amount;

				if(item < target)
					return item;
			}
			else
			{
				item -= amount;

				if(item > target)
					return item;
			}

			return target;
		}
		static public float GetAbs(this float item)
		{
			if(item < 0)
				return -item;

			return item;
		}

		static public float GetPositive(this float item)
		{
			return item.GetAbs();
		}

		static public float GetNegative(this float item)
		{
			return -item.GetAbs();
		}

		static public float GetSquared(this float item)
		{
			return item * item;
		}

		static public float GetTowards(this float item, float target, float amount)
		{
			if(item < target)
			{
				item += amount;

				if(item < target)
					return item;
			}
			else
			{
				item -= amount;

				if(item > target)
					return item;
			}

			return target;
		}
		static public double GetAbs(this double item)
		{
			if(item < 0)
				return -item;

			return item;
		}

		static public double GetPositive(this double item)
		{
			return item.GetAbs();
		}

		static public double GetNegative(this double item)
		{
			return -item.GetAbs();
		}

		static public double GetSquared(this double item)
		{
			return item * item;
		}

		static public double GetTowards(this double item, double target, double amount)
		{
			if(item < target)
			{
				item += amount;

				if(item < target)
					return item;
			}
			else
			{
				item -= amount;

				if(item > target)
					return item;
			}

			return target;
		}
		static public decimal GetAbs(this decimal item)
		{
			if(item < 0)
				return -item;

			return item;
		}

		static public decimal GetPositive(this decimal item)
		{
			return item.GetAbs();
		}

		static public decimal GetNegative(this decimal item)
		{
			return -item.GetAbs();
		}

		static public decimal GetSquared(this decimal item)
		{
			return item * item;
		}

		static public decimal GetTowards(this decimal item, decimal target, decimal amount)
		{
			if(item < target)
			{
				item += amount;

				if(item < target)
					return item;
			}
			else
			{
				item -= amount;

				if(item > target)
					return item;
			}

			return target;
		}
	}
}