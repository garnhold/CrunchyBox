using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberExtensions_IEnumerable_Running
    {
		static public IEnumerable<byte> RunningSum(this IEnumerable<byte> item)
		{
			byte total = 0;

			foreach(byte sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<byte> RunningProduct(this IEnumerable<byte> item)
		{
			byte total = 1;

			foreach(byte sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<short> RunningSum(this IEnumerable<short> item)
		{
			short total = 0;

			foreach(short sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<short> RunningProduct(this IEnumerable<short> item)
		{
			short total = 1;

			foreach(short sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<int> RunningSum(this IEnumerable<int> item)
		{
			int total = 0;

			foreach(int sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<int> RunningProduct(this IEnumerable<int> item)
		{
			int total = 1;

			foreach(int sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<long> RunningSum(this IEnumerable<long> item)
		{
			long total = 0;

			foreach(long sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<long> RunningProduct(this IEnumerable<long> item)
		{
			long total = 1;

			foreach(long sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<float> RunningSum(this IEnumerable<float> item)
		{
			float total = 0;

			foreach(float sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<float> RunningProduct(this IEnumerable<float> item)
		{
			float total = 1;

			foreach(float sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<double> RunningSum(this IEnumerable<double> item)
		{
			double total = 0;

			foreach(double sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<double> RunningProduct(this IEnumerable<double> item)
		{
			double total = 1;

			foreach(double sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
		static public IEnumerable<decimal> RunningSum(this IEnumerable<decimal> item)
		{
			decimal total = 0;

			foreach(decimal sub_item in item)
			{
				total += sub_item;
				yield return total;
			}
		}

		static public IEnumerable<decimal> RunningProduct(this IEnumerable<decimal> item)
		{
			decimal total = 1;

			foreach(decimal sub_item in item)
			{
				total *= sub_item;
				yield return total;
			}
		}
	}
}