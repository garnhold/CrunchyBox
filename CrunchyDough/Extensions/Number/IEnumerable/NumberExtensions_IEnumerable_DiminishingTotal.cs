using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_IEnumerable_DiminishingTotal
    {
		static public int DiminishingAverage(this IEnumerable<int> item, double ratio)
		{
			double current_weight = 1.0;

			double total = 0.0;
			double total_weight = 0.0;

			foreach(int sub_item in item)
			{
				total += sub_item * current_weight;
				total_weight += current_weight;

				current_weight *= ratio;
			}

			return (int)(total / total_weight);
		}
		static public long DiminishingAverage(this IEnumerable<long> item, double ratio)
		{
			double current_weight = 1.0;

			double total = 0.0;
			double total_weight = 0.0;

			foreach(long sub_item in item)
			{
				total += sub_item * current_weight;
				total_weight += current_weight;

				current_weight *= ratio;
			}

			return (long)(total / total_weight);
		}
		static public float DiminishingAverage(this IEnumerable<float> item, double ratio)
		{
			double current_weight = 1.0;

			double total = 0.0;
			double total_weight = 0.0;

			foreach(float sub_item in item)
			{
				total += sub_item * current_weight;
				total_weight += current_weight;

				current_weight *= ratio;
			}

			return (float)(total / total_weight);
		}
		static public double DiminishingAverage(this IEnumerable<double> item, double ratio)
		{
			double current_weight = 1.0;

			double total = 0.0;
			double total_weight = 0.0;

			foreach(double sub_item in item)
			{
				total += sub_item * current_weight;
				total_weight += current_weight;

				current_weight *= ratio;
			}

			return (double)(total / total_weight);
		}
	}
}