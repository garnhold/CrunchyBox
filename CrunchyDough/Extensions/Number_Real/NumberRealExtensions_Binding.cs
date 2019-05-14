using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberRealExtensions_Binding
    {

		static public float BindPercent(this float item)
		{
			return item.BindBetween(0.0f, 1.0f);
		}

		static public float BindOffset(this float item)
		{
			return item.BindBetween(-1.0f, 1.0f);
		}

		static public double BindPercent(this double item)
		{
			return item.BindBetween(0.0, 1.0);
		}

		static public double BindOffset(this double item)
		{
			return item.BindBetween(-1.0, 1.0);
		}

		static public decimal BindPercent(this decimal item)
		{
			return item.BindBetween(0.0m, 1.0m);
		}

		static public decimal BindOffset(this decimal item)
		{
			return item.BindBetween(-1.0m, 1.0m);
		}
	}
}

