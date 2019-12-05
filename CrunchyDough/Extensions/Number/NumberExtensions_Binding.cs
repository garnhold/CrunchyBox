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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public byte BindBetween(this byte item, ByteRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this byte item, ByteRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public byte BindAround(this byte item, byte value, byte radius)
        {
            if(radius > 0)
            {
                byte lower = (byte)(value - radius);
                byte upper = (byte)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public byte BindAround(this byte item, ByteVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this byte item, byte value, byte radius)
        {
            if(radius >= 0)
            {
                byte lower = (byte)(value - radius);
                byte upper = (byte)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this byte item, ByteVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public short BindBetween(this short item, ShortRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this short item, ShortRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public short BindAround(this short item, short value, short radius)
        {
            if(radius > 0)
            {
                short lower = (short)(value - radius);
                short upper = (short)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public short BindAround(this short item, ShortVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this short item, short value, short radius)
        {
            if(radius >= 0)
            {
                short lower = (short)(value - radius);
                short upper = (short)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this short item, ShortVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public int BindBetween(this int item, IntRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this int item, IntRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public int BindAround(this int item, int value, int radius)
        {
            if(radius > 0)
            {
                int lower = (int)(value - radius);
                int upper = (int)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public int BindAround(this int item, IntVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this int item, int value, int radius)
        {
            if(radius >= 0)
            {
                int lower = (int)(value - radius);
                int upper = (int)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this int item, IntVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public long BindBetween(this long item, LongRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this long item, LongRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public long BindAround(this long item, long value, long radius)
        {
            if(radius > 0L)
            {
                long lower = (long)(value - radius);
                long upper = (long)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public long BindAround(this long item, LongVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this long item, long value, long radius)
        {
            if(radius >= 0L)
            {
                long lower = (long)(value - radius);
                long upper = (long)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this long item, LongVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public float BindBetween(this float item, FloatRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this float item, FloatRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public float BindAround(this float item, float value, float radius)
        {
            if(radius > 0.0f)
            {
                float lower = (float)(value - radius);
                float upper = (float)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public float BindAround(this float item, FloatVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this float item, float value, float radius)
        {
            if(radius >= 0.0f)
            {
                float lower = (float)(value - radius);
                float upper = (float)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this float item, FloatVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public double BindBetween(this double item, DoubleRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this double item, DoubleRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public double BindAround(this double item, double value, double radius)
        {
            if(radius > 0.0)
            {
                double lower = (double)(value - radius);
                double upper = (double)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public double BindAround(this double item, DoubleVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this double item, double value, double radius)
        {
            if(radius >= 0.0)
            {
                double lower = (double)(value - radius);
                double upper = (double)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this double item, DoubleVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
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
            
            if(item < lower)
                return lower;
                
            if(item > upper)
                return upper;
                
            return item;
        }
		static public decimal BindBetween(this decimal item, DecimalRange range)
		{
			return item.BindBetween(range.x1, range.x2);
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
		static public bool IsBoundBetween(this decimal item, DecimalRange range)
		{
			return item.IsBoundBetween(range.x1, range.x2);
		}
        
        static public decimal BindAround(this decimal item, decimal value, decimal radius)
        {
            if(radius > 0.0m)
            {
                decimal lower = (decimal)(value - radius);
                decimal upper = (decimal)(value + radius);
                
                if(item < lower)
                    return lower;
                    
                if(item > upper)
                    return upper;
                    
                return item;
            }
            
            return value;
        }
        static public decimal BindAround(this decimal item, DecimalVariance variance)
        {
            return item.BindAround(variance.value, variance.radius);
        }
        
        static public bool IsBoundAround(this decimal item, decimal value, decimal radius)
        {
            if(radius >= 0.0m)
            {
                decimal lower = (decimal)(value - radius);
                decimal upper = (decimal)(value + radius);
                
                if(item >= lower && item <= upper)
                    return true;
            }
            
            return false;
        }
        static public bool IsBoundAround(this decimal item, DecimalVariance variance)
        {
            return item.IsBoundAround(variance.value, variance.radius);
        }
	}
}
