using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberRealExtensions_Interpolate
    {

		static public float GetInterpolate(this float item, float target, float amount)
        {
            amount = amount.BindBetween(0.0f, 1.0f);

            return item * (1.0f - amount) + target * amount;
        }

		static public float InterpolateWith(this float item, float source, float target)
		{
			return source.GetInterpolate(target, item);
		}

		static public double GetInterpolate(this double item, double target, double amount)
        {
            amount = amount.BindBetween(0.0, 1.0);

            return item * (1.0 - amount) + target * amount;
        }

		static public double InterpolateWith(this double item, double source, double target)
		{
			return source.GetInterpolate(target, item);
		}

		static public decimal GetInterpolate(this decimal item, decimal target, decimal amount)
        {
            amount = amount.BindBetween(0.0m, 1.0m);

            return item * (1.0m - amount) + target * amount;
        }

		static public decimal InterpolateWith(this decimal item, decimal source, decimal target)
		{
			return source.GetInterpolate(target, item);
		}
	}
}

