using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    [Serializable]
    public struct ByteWeighted
	{
		public readonly byte value;
        public readonly float weight;
        
        public ByteWeighted(byte v, float w)
        {
            value = v;
            weight = w;
        }
	}
    static public class ByteWeightedExtensions
    {
        static public byte Average(this IEnumerable<ByteWeighted> item)
        {
            float total = 0;
            float divisor = 0;
            
            foreach(ByteWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (byte)(total / divisor);
        }
    }

    [Serializable]
    public struct ShortWeighted
	{
		public readonly short value;
        public readonly float weight;
        
        public ShortWeighted(short v, float w)
        {
            value = v;
            weight = w;
        }
	}
    static public class ShortWeightedExtensions
    {
        static public short Average(this IEnumerable<ShortWeighted> item)
        {
            float total = 0;
            float divisor = 0;
            
            foreach(ShortWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (short)(total / divisor);
        }
    }

    [Serializable]
    public struct IntWeighted
	{
		public readonly int value;
        public readonly float weight;
        
        public IntWeighted(int v, float w)
        {
            value = v;
            weight = w;
        }
	}
    static public class IntWeightedExtensions
    {
        static public int Average(this IEnumerable<IntWeighted> item)
        {
            float total = 0;
            float divisor = 0;
            
            foreach(IntWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (int)(total / divisor);
        }
    }

    [Serializable]
    public struct LongWeighted
	{
		public readonly long value;
        public readonly float weight;
        
        public LongWeighted(long v, float w)
        {
            value = v;
            weight = w;
        }
	}
    static public class LongWeightedExtensions
    {
        static public long Average(this IEnumerable<LongWeighted> item)
        {
            float total = 0;
            float divisor = 0;
            
            foreach(LongWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (long)(total / divisor);
        }
    }

    [Serializable]
    public struct FloatWeighted
	{
		public readonly float value;
        public readonly float weight;
        
        public FloatWeighted(float v, float w)
        {
            value = v;
            weight = w;
        }
	}
    static public class FloatWeightedExtensions
    {
        static public float Average(this IEnumerable<FloatWeighted> item)
        {
            float total = 0;
            float divisor = 0;
            
            foreach(FloatWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (float)(total / divisor);
        }
    }

    [Serializable]
    public struct DoubleWeighted
	{
		public readonly double value;
        public readonly double weight;
        
        public DoubleWeighted(double v, double w)
        {
            value = v;
            weight = w;
        }
	}
    static public class DoubleWeightedExtensions
    {
        static public double Average(this IEnumerable<DoubleWeighted> item)
        {
            double total = 0;
            double divisor = 0;
            
            foreach(DoubleWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (double)(total / divisor);
        }
    }

    [Serializable]
    public struct DecimalWeighted
	{
		public readonly decimal value;
        public readonly decimal weight;
        
        public DecimalWeighted(decimal v, decimal w)
        {
            value = v;
            weight = w;
        }
	}
    static public class DecimalWeightedExtensions
    {
        static public decimal Average(this IEnumerable<DecimalWeighted> item)
        {
            decimal total = 0;
            decimal divisor = 0;
            
            foreach(DecimalWeighted sub_item in item)
            {
                total += sub_item.value * sub_item.weight;
                divisor += sub_item.weight;
            }
            
            return (decimal)(total / divisor);
        }
    }

}

