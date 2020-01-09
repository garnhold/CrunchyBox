using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberRealExtensions_Components
    {
		static public void GetComponents(this float item, out int whole, out float fractional)
		{
			whole = item.GetWholeComponent();
            fractional = item - whole;
		}

		static public int GetWholeComponent(this float item)
		{
			return (int)item;
		}

		static public float GetFractionalComponent(this float item)
		{
			return item - item.GetWholeComponent();
		}
		static public void GetComponents(this double item, out int whole, out double fractional)
		{
			whole = item.GetWholeComponent();
            fractional = item - whole;
		}

		static public int GetWholeComponent(this double item)
		{
			return (int)item;
		}

		static public double GetFractionalComponent(this double item)
		{
			return item - item.GetWholeComponent();
		}
		static public void GetComponents(this decimal item, out int whole, out decimal fractional)
		{
			whole = item.GetWholeComponent();
            fractional = item - whole;
		}

		static public int GetWholeComponent(this decimal item)
		{
			return (int)item;
		}

		static public decimal GetFractionalComponent(this decimal item)
		{
			return item - item.GetWholeComponent();
		}
	}
}