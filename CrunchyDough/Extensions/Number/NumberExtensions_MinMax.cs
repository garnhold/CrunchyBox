using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_MinMax
    {
		static public void Order(this byte item, byte input, out byte lower, out byte upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this byte x1, byte y1, byte x2, byte y2, out byte low_x, out byte low_y, out byte high_x, out byte high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this byte x1, byte y1, byte x2, byte y2, out byte low_x, out byte low_y, out byte high_x, out byte high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this byte input1, byte input2, byte input3, out byte low, out byte mid, out byte high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public byte Min(this byte item, byte input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public byte Max(this byte item, byte input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this short item, short input, out short lower, out short upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this short x1, short y1, short x2, short y2, out short low_x, out short low_y, out short high_x, out short high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this short x1, short y1, short x2, short y2, out short low_x, out short low_y, out short high_x, out short high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this short input1, short input2, short input3, out short low, out short mid, out short high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public short Min(this short item, short input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public short Max(this short item, short input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this int item, int input, out int lower, out int upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this int x1, int y1, int x2, int y2, out int low_x, out int low_y, out int high_x, out int high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this int x1, int y1, int x2, int y2, out int low_x, out int low_y, out int high_x, out int high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this int input1, int input2, int input3, out int low, out int mid, out int high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public int Min(this int item, int input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public int Max(this int item, int input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this long item, long input, out long lower, out long upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this long x1, long y1, long x2, long y2, out long low_x, out long low_y, out long high_x, out long high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this long x1, long y1, long x2, long y2, out long low_x, out long low_y, out long high_x, out long high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this long input1, long input2, long input3, out long low, out long mid, out long high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public long Min(this long item, long input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public long Max(this long item, long input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this float item, float input, out float lower, out float upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this float x1, float y1, float x2, float y2, out float low_x, out float low_y, out float high_x, out float high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this float x1, float y1, float x2, float y2, out float low_x, out float low_y, out float high_x, out float high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this float input1, float input2, float input3, out float low, out float mid, out float high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public float Min(this float item, float input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public float Max(this float item, float input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this double item, double input, out double lower, out double upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this double x1, double y1, double x2, double y2, out double low_x, out double low_y, out double high_x, out double high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this double x1, double y1, double x2, double y2, out double low_x, out double low_y, out double high_x, out double high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this double input1, double input2, double input3, out double low, out double mid, out double high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public double Min(this double item, double input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public double Max(this double item, double input)
        {
            if (item > input)
                return item;

            return input;
        }
		static public void Order(this decimal item, decimal input, out decimal lower, out decimal upper)
        {
            if (item < input)
            {
                lower = item;
                upper = input;
            }
            else
            {
                lower = input;
                upper = item;
            }
        }

		static public void OrderPairByFirst(this decimal x1, decimal y1, decimal x2, decimal y2, out decimal low_x, out decimal low_y, out decimal high_x, out decimal high_y)
		{
			if (x1 < x2)
            {
                low_x = x1;
				low_y = y1;

				high_x = x2;
				high_y = y2;
            }
            else
            {
                low_x = x2;
				low_y = y2;

				high_x = x1;
				high_y = y1;
            }
		}
		static public void OrderPairBySecond(this decimal x1, decimal y1, decimal x2, decimal y2, out decimal low_x, out decimal low_y, out decimal high_x, out decimal high_y)
		{
			y1.OrderPairByFirst(x1, y2, x2, out low_y, out low_x, out high_y, out high_x);
		}

		static public void Order(this decimal input1, decimal input2, decimal input3, out decimal low, out decimal mid, out decimal high)
        {
			Order(input1, input2, out low, out high);
            Order(low, input3, out low, out mid);
            Order(mid, high, out mid, out high);
        }

        static public decimal Min(this decimal item, decimal input)
        {
            if (item < input)
                return item;

            return input;
        }

        static public decimal Max(this decimal item, decimal input)
        {
            if (item > input)
                return item;

            return input;
        }
	}
}