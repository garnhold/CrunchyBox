using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberExtensions_Binding
    {
		static public byte BindAbove(this byte item, byte lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this byte item, byte lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public byte BindBelow(this byte item, byte upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this byte item, byte upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public byte BindBetween(this byte item, byte value1, byte value2)
        {
            byte lower;
            byte upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this byte item, byte value1, byte value2)
		{
			byte low;
            byte high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public short BindAbove(this short item, short lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this short item, short lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public short BindBelow(this short item, short upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this short item, short upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public short BindBetween(this short item, short value1, short value2)
        {
            short lower;
            short upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this short item, short value1, short value2)
		{
			short low;
            short high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public int BindAbove(this int item, int lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this int item, int lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public int BindBelow(this int item, int upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this int item, int upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public int BindBetween(this int item, int value1, int value2)
        {
            int lower;
            int upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this int item, int value1, int value2)
		{
			int low;
            int high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public long BindAbove(this long item, long lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this long item, long lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public long BindBelow(this long item, long upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this long item, long upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public long BindBetween(this long item, long value1, long value2)
        {
            long lower;
            long upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this long item, long value1, long value2)
		{
			long low;
            long high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public float BindAbove(this float item, float lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this float item, float lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public float BindBelow(this float item, float upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this float item, float upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public float BindBetween(this float item, float value1, float value2)
        {
            float lower;
            float upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this float item, float value1, float value2)
		{
			float low;
            float high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public double BindAbove(this double item, double lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this double item, double lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public double BindBelow(this double item, double upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this double item, double upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public double BindBetween(this double item, double value1, double value2)
        {
            double lower;
            double upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this double item, double value1, double value2)
		{
			double low;
            double high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
		static public decimal BindAbove(this decimal item, decimal lower)
        {
            if (item > lower)
                return item;

            return lower;
        }
		static public bool IsBoundAbove(this decimal item, decimal lower)
		{
			if (item >= lower)
				return true;

			return false;
		}

        static public decimal BindBelow(this decimal item, decimal upper)
        {
            if (item < upper)
                return item;

            return upper;
        }
		static public bool IsBoundBelow(this decimal item, decimal upper)
		{
			if (item <= upper)
				return true;

			return false;
		}

        static public decimal BindBetween(this decimal item, decimal value1, decimal value2)
        {
            decimal lower;
            decimal upper;

            value1.Order(value2, out lower, out upper);

            if (item > lower)
            {
                if (item < upper)
                    return item;

                return upper;
            }

            return lower;
        }
		static public bool IsBoundBetween(this decimal item, decimal value1, decimal value2)
		{
			decimal low;
            decimal high;

            value1.Order(value2, out low, out high);

            if (item.IsBoundAbove(low) && item.IsBoundBelow(high))
                return true;

            return false;
		}
	}
}