using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_IEnumerable_Total
    {
		static public int Sum(this IEnumerable<int> item)
		{
			int total = 0;

			foreach(int sub_item in item)
				total += sub_item;

			return total;
		}

		static public int Product(this IEnumerable<int> item)
		{
			int total = 1;

			foreach(int sub_item in item)
				total *= sub_item;

			return total;
		}

		static public int Average(this IEnumerable<int> item)
		{
			int count = 0;
			int total = 0;

			foreach(int sub_item in item)
			{
				total += sub_item;
				count++;
			}

			return total / count;
		}

		static public int Min(this IEnumerable<int> item)
		{
			int min = item.GetFirst();

			foreach(int sub_item in item)
				min = min.Min(sub_item);

			return min;
		}

		static public int Max(this IEnumerable<int> item)
		{
			int max = item.GetFirst();

			foreach(int sub_item in item)
				max = max.Max(sub_item);

			return max;
		}
		static public long Sum(this IEnumerable<long> item)
		{
			long total = 0;

			foreach(long sub_item in item)
				total += sub_item;

			return total;
		}

		static public long Product(this IEnumerable<long> item)
		{
			long total = 1;

			foreach(long sub_item in item)
				total *= sub_item;

			return total;
		}

		static public long Average(this IEnumerable<long> item)
		{
			int count = 0;
			long total = 0;

			foreach(long sub_item in item)
			{
				total += sub_item;
				count++;
			}

			return total / count;
		}

		static public long Min(this IEnumerable<long> item)
		{
			long min = item.GetFirst();

			foreach(long sub_item in item)
				min = min.Min(sub_item);

			return min;
		}

		static public long Max(this IEnumerable<long> item)
		{
			long max = item.GetFirst();

			foreach(long sub_item in item)
				max = max.Max(sub_item);

			return max;
		}
		static public float Sum(this IEnumerable<float> item)
		{
			float total = 0;

			foreach(float sub_item in item)
				total += sub_item;

			return total;
		}

		static public float Product(this IEnumerable<float> item)
		{
			float total = 1;

			foreach(float sub_item in item)
				total *= sub_item;

			return total;
		}

		static public float Average(this IEnumerable<float> item)
		{
			int count = 0;
			float total = 0;

			foreach(float sub_item in item)
			{
				total += sub_item;
				count++;
			}

			return total / count;
		}

		static public float Min(this IEnumerable<float> item)
		{
			float min = item.GetFirst();

			foreach(float sub_item in item)
				min = min.Min(sub_item);

			return min;
		}

		static public float Max(this IEnumerable<float> item)
		{
			float max = item.GetFirst();

			foreach(float sub_item in item)
				max = max.Max(sub_item);

			return max;
		}
		static public double Sum(this IEnumerable<double> item)
		{
			double total = 0;

			foreach(double sub_item in item)
				total += sub_item;

			return total;
		}

		static public double Product(this IEnumerable<double> item)
		{
			double total = 1;

			foreach(double sub_item in item)
				total *= sub_item;

			return total;
		}

		static public double Average(this IEnumerable<double> item)
		{
			int count = 0;
			double total = 0;

			foreach(double sub_item in item)
			{
				total += sub_item;
				count++;
			}

			return total / count;
		}

		static public double Min(this IEnumerable<double> item)
		{
			double min = item.GetFirst();

			foreach(double sub_item in item)
				min = min.Min(sub_item);

			return min;
		}

		static public double Max(this IEnumerable<double> item)
		{
			double max = item.GetFirst();

			foreach(double sub_item in item)
				max = max.Max(sub_item);

			return max;
		}
		static public decimal Sum(this IEnumerable<decimal> item)
		{
			decimal total = 0;

			foreach(decimal sub_item in item)
				total += sub_item;

			return total;
		}

		static public decimal Product(this IEnumerable<decimal> item)
		{
			decimal total = 1;

			foreach(decimal sub_item in item)
				total *= sub_item;

			return total;
		}

		static public decimal Average(this IEnumerable<decimal> item)
		{
			int count = 0;
			decimal total = 0;

			foreach(decimal sub_item in item)
			{
				total += sub_item;
				count++;
			}

			return total / count;
		}

		static public decimal Min(this IEnumerable<decimal> item)
		{
			decimal min = item.GetFirst();

			foreach(decimal sub_item in item)
				min = min.Min(sub_item);

			return min;
		}

		static public decimal Max(this IEnumerable<decimal> item)
		{
			decimal max = item.GetFirst();

			foreach(decimal sub_item in item)
				max = max.Max(sub_item);

			return max;
		}
	}
}