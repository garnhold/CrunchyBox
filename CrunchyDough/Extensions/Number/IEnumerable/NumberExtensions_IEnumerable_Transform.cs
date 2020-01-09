using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_IEnumerable_Transform
    {
		static public IEnumerable<int> Shift(this IEnumerable<int> item, int amount)
		{
			foreach(int sub_item in item)
				yield return sub_item + amount;
		}

		static public IEnumerable<int> Stretch(this IEnumerable<int> item, int amount)
		{
			foreach(int sub_item in item)
				yield return sub_item * amount;
		}
		static public IEnumerable<long> Shift(this IEnumerable<long> item, long amount)
		{
			foreach(long sub_item in item)
				yield return sub_item + amount;
		}

		static public IEnumerable<long> Stretch(this IEnumerable<long> item, long amount)
		{
			foreach(long sub_item in item)
				yield return sub_item * amount;
		}
		static public IEnumerable<float> Shift(this IEnumerable<float> item, float amount)
		{
			foreach(float sub_item in item)
				yield return sub_item + amount;
		}

		static public IEnumerable<float> Stretch(this IEnumerable<float> item, float amount)
		{
			foreach(float sub_item in item)
				yield return sub_item * amount;
		}
		static public IEnumerable<double> Shift(this IEnumerable<double> item, double amount)
		{
			foreach(double sub_item in item)
				yield return sub_item + amount;
		}

		static public IEnumerable<double> Stretch(this IEnumerable<double> item, double amount)
		{
			foreach(double sub_item in item)
				yield return sub_item * amount;
		}
		static public IEnumerable<decimal> Shift(this IEnumerable<decimal> item, decimal amount)
		{
			foreach(decimal sub_item in item)
				yield return sub_item + amount;
		}

		static public IEnumerable<decimal> Stretch(this IEnumerable<decimal> item, decimal amount)
		{
			foreach(decimal sub_item in item)
				yield return sub_item * amount;
		}
	}
}