using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
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
            amount = amount.GetAbs();
            
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

		static public bool GetMoveTowards(this int item, int target, int amount, out int output)
		{
            amount = amount.GetAbs();
            
			if(item < target)
			{
				item += amount;

				if(item < target)
				{
					output = item;
					return false;
				}
			}
			else
			{
				item -= amount;

				if(item > target)
				{
					output = item;
					return false;
				}
			}

			output = target;
			return true;
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
            amount = amount.GetAbs();
            
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

		static public bool GetMoveTowards(this long item, long target, long amount, out long output)
		{
            amount = amount.GetAbs();
            
			if(item < target)
			{
				item += amount;

				if(item < target)
				{
					output = item;
					return false;
				}
			}
			else
			{
				item -= amount;

				if(item > target)
				{
					output = item;
					return false;
				}
			}

			output = target;
			return true;
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
            amount = amount.GetAbs();
            
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

		static public bool GetMoveTowards(this float item, float target, float amount, out float output)
		{
            amount = amount.GetAbs();
            
			if(item < target)
			{
				item += amount;

				if(item < target)
				{
					output = item;
					return false;
				}
			}
			else
			{
				item -= amount;

				if(item > target)
				{
					output = item;
					return false;
				}
			}

			output = target;
			return true;
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
            amount = amount.GetAbs();
            
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

		static public bool GetMoveTowards(this double item, double target, double amount, out double output)
		{
            amount = amount.GetAbs();
            
			if(item < target)
			{
				item += amount;

				if(item < target)
				{
					output = item;
					return false;
				}
			}
			else
			{
				item -= amount;

				if(item > target)
				{
					output = item;
					return false;
				}
			}

			output = target;
			return true;
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
            amount = amount.GetAbs();
            
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

		static public bool GetMoveTowards(this decimal item, decimal target, decimal amount, out decimal output)
		{
            amount = amount.GetAbs();
            
			if(item < target)
			{
				item += amount;

				if(item < target)
				{
					output = item;
					return false;
				}
			}
			else
			{
				item -= amount;

				if(item > target)
				{
					output = item;
					return false;
				}
			}

			output = target;
			return true;
		}
	}
}