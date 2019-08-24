﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	
	[Serializable]
    public struct ByteRange
	{
		public readonly byte x1;
		public readonly byte x2;

		static public implicit operator ByteVariance(ByteRange r)
		{
			return r.GetVariance();
		}

		public ByteRange(byte nx1, byte nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			ByteRange cast;

			if(obj.Convert<ByteRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct ByteVariance
	{
		public readonly byte value;
		public readonly byte radius;

		static public implicit operator ByteRange(ByteVariance v)
		{
			return v.GetRange();
		}

		public ByteVariance(byte v, byte r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			ByteVariance cast;

			if(obj.Convert<ByteVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class ByteRangeVarianceExtensions
	{
		static public byte GetCenter(this ByteRange item)
		{
			return (byte)((item.x1 + item.x2) / 2);
		}
		static public byte GetRadius(this ByteRange item)
		{
			return (byte)(item.GetWidth() / 2);
		}

		static public byte GetBoundA(this ByteVariance item)
		{
			return (byte)(item.value - item.radius);
		}
		static public byte GetBoundB(this ByteVariance item)
		{
			return (byte)(item.value + item.radius);
		}

		static public byte GetWidth(this ByteRange item)
		{
			return (byte)(item.x2 - item.x1);
		}
		static public byte GetWidth(this ByteVariance item)
		{
			return (byte)(item.radius * 2);
		}

		static public ByteVariance GetVariance(this ByteRange item)
		{
			return new ByteVariance(item.GetCenter(), item.GetRadius());
		}
		static public ByteRange GetRange(this ByteVariance item)
		{
			return new ByteRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct ShortRange
	{
		public readonly short x1;
		public readonly short x2;

		static public implicit operator ShortVariance(ShortRange r)
		{
			return r.GetVariance();
		}

		public ShortRange(short nx1, short nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			ShortRange cast;

			if(obj.Convert<ShortRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct ShortVariance
	{
		public readonly short value;
		public readonly short radius;

		static public implicit operator ShortRange(ShortVariance v)
		{
			return v.GetRange();
		}

		public ShortVariance(short v, short r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			ShortVariance cast;

			if(obj.Convert<ShortVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class ShortRangeVarianceExtensions
	{
		static public short GetCenter(this ShortRange item)
		{
			return (short)((item.x1 + item.x2) / 2);
		}
		static public short GetRadius(this ShortRange item)
		{
			return (short)(item.GetWidth() / 2);
		}

		static public short GetBoundA(this ShortVariance item)
		{
			return (short)(item.value - item.radius);
		}
		static public short GetBoundB(this ShortVariance item)
		{
			return (short)(item.value + item.radius);
		}

		static public short GetWidth(this ShortRange item)
		{
			return (short)(item.x2 - item.x1);
		}
		static public short GetWidth(this ShortVariance item)
		{
			return (short)(item.radius * 2);
		}

		static public ShortVariance GetVariance(this ShortRange item)
		{
			return new ShortVariance(item.GetCenter(), item.GetRadius());
		}
		static public ShortRange GetRange(this ShortVariance item)
		{
			return new ShortRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct IntRange
	{
		public readonly int x1;
		public readonly int x2;

		static public implicit operator IntVariance(IntRange r)
		{
			return r.GetVariance();
		}

		public IntRange(int nx1, int nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			IntRange cast;

			if(obj.Convert<IntRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct IntVariance
	{
		public readonly int value;
		public readonly int radius;

		static public implicit operator IntRange(IntVariance v)
		{
			return v.GetRange();
		}

		public IntVariance(int v, int r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			IntVariance cast;

			if(obj.Convert<IntVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class IntRangeVarianceExtensions
	{
		static public int GetCenter(this IntRange item)
		{
			return (int)((item.x1 + item.x2) / 2);
		}
		static public int GetRadius(this IntRange item)
		{
			return (int)(item.GetWidth() / 2);
		}

		static public int GetBoundA(this IntVariance item)
		{
			return (int)(item.value - item.radius);
		}
		static public int GetBoundB(this IntVariance item)
		{
			return (int)(item.value + item.radius);
		}

		static public int GetWidth(this IntRange item)
		{
			return (int)(item.x2 - item.x1);
		}
		static public int GetWidth(this IntVariance item)
		{
			return (int)(item.radius * 2);
		}

		static public IntVariance GetVariance(this IntRange item)
		{
			return new IntVariance(item.GetCenter(), item.GetRadius());
		}
		static public IntRange GetRange(this IntVariance item)
		{
			return new IntRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct LongRange
	{
		public readonly long x1;
		public readonly long x2;

		static public implicit operator LongVariance(LongRange r)
		{
			return r.GetVariance();
		}

		public LongRange(long nx1, long nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			LongRange cast;

			if(obj.Convert<LongRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct LongVariance
	{
		public readonly long value;
		public readonly long radius;

		static public implicit operator LongRange(LongVariance v)
		{
			return v.GetRange();
		}

		public LongVariance(long v, long r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			LongVariance cast;

			if(obj.Convert<LongVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class LongRangeVarianceExtensions
	{
		static public long GetCenter(this LongRange item)
		{
			return (long)((item.x1 + item.x2) / 2);
		}
		static public long GetRadius(this LongRange item)
		{
			return (long)(item.GetWidth() / 2);
		}

		static public long GetBoundA(this LongVariance item)
		{
			return (long)(item.value - item.radius);
		}
		static public long GetBoundB(this LongVariance item)
		{
			return (long)(item.value + item.radius);
		}

		static public long GetWidth(this LongRange item)
		{
			return (long)(item.x2 - item.x1);
		}
		static public long GetWidth(this LongVariance item)
		{
			return (long)(item.radius * 2);
		}

		static public LongVariance GetVariance(this LongRange item)
		{
			return new LongVariance(item.GetCenter(), item.GetRadius());
		}
		static public LongRange GetRange(this LongVariance item)
		{
			return new LongRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct FloatRange
	{
		public readonly float x1;
		public readonly float x2;

		static public implicit operator FloatVariance(FloatRange r)
		{
			return r.GetVariance();
		}

		public FloatRange(float nx1, float nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			FloatRange cast;

			if(obj.Convert<FloatRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct FloatVariance
	{
		public readonly float value;
		public readonly float radius;

		static public implicit operator FloatRange(FloatVariance v)
		{
			return v.GetRange();
		}

		public FloatVariance(float v, float r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			FloatVariance cast;

			if(obj.Convert<FloatVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class FloatRangeVarianceExtensions
	{
		static public float GetCenter(this FloatRange item)
		{
			return (float)((item.x1 + item.x2) / 2);
		}
		static public float GetRadius(this FloatRange item)
		{
			return (float)(item.GetWidth() / 2);
		}

		static public float GetBoundA(this FloatVariance item)
		{
			return (float)(item.value - item.radius);
		}
		static public float GetBoundB(this FloatVariance item)
		{
			return (float)(item.value + item.radius);
		}

		static public float GetWidth(this FloatRange item)
		{
			return (float)(item.x2 - item.x1);
		}
		static public float GetWidth(this FloatVariance item)
		{
			return (float)(item.radius * 2);
		}

		static public FloatVariance GetVariance(this FloatRange item)
		{
			return new FloatVariance(item.GetCenter(), item.GetRadius());
		}
		static public FloatRange GetRange(this FloatVariance item)
		{
			return new FloatRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct DoubleRange
	{
		public readonly double x1;
		public readonly double x2;

		static public implicit operator DoubleVariance(DoubleRange r)
		{
			return r.GetVariance();
		}

		public DoubleRange(double nx1, double nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			DoubleRange cast;

			if(obj.Convert<DoubleRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct DoubleVariance
	{
		public readonly double value;
		public readonly double radius;

		static public implicit operator DoubleRange(DoubleVariance v)
		{
			return v.GetRange();
		}

		public DoubleVariance(double v, double r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			DoubleVariance cast;

			if(obj.Convert<DoubleVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class DoubleRangeVarianceExtensions
	{
		static public double GetCenter(this DoubleRange item)
		{
			return (double)((item.x1 + item.x2) / 2);
		}
		static public double GetRadius(this DoubleRange item)
		{
			return (double)(item.GetWidth() / 2);
		}

		static public double GetBoundA(this DoubleVariance item)
		{
			return (double)(item.value - item.radius);
		}
		static public double GetBoundB(this DoubleVariance item)
		{
			return (double)(item.value + item.radius);
		}

		static public double GetWidth(this DoubleRange item)
		{
			return (double)(item.x2 - item.x1);
		}
		static public double GetWidth(this DoubleVariance item)
		{
			return (double)(item.radius * 2);
		}

		static public DoubleVariance GetVariance(this DoubleRange item)
		{
			return new DoubleVariance(item.GetCenter(), item.GetRadius());
		}
		static public DoubleRange GetRange(this DoubleVariance item)
		{
			return new DoubleRange(item.GetBoundA(), item.GetBoundB());
		}
	}

	
	[Serializable]
    public struct DecimalRange
	{
		public readonly decimal x1;
		public readonly decimal x2;

		static public implicit operator DecimalVariance(DecimalRange r)
		{
			return r.GetVariance();
		}

		public DecimalRange(decimal nx1, decimal nx2)
		{
			x1 = nx1;
			x2 = nx2;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + x1.GetHashCode();
				hash = hash * 23 + x2.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			DecimalRange cast;

			if(obj.Convert<DecimalRange>(out cast))
			{
				if(cast.x1 == x1)
				{
					if(cast.x2 == x2)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return "[" + x1 + ", " + x2 + "]";
		}
	}

	[Serializable]
    public struct DecimalVariance
	{
		public readonly decimal value;
		public readonly decimal radius;

		static public implicit operator DecimalRange(DecimalVariance v)
		{
			return v.GetRange();
		}

		public DecimalVariance(decimal v, decimal r)
		{
			value = v;
			radius = r;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = 17;

				hash = hash * 23 + value.GetHashCode();
				hash = hash * 23 + radius.GetHashCode();
				return hash;
			}
		}

		public override bool Equals(object obj)
		{
			DecimalVariance cast;

			if(obj.Convert<DecimalVariance>(out cast))
			{
				if(cast.value == value)
				{
					if(cast.radius == radius)
						return true;
				}
			}

			return false;
		}

		public override string ToString()
		{
			return value + "\u00B1" + radius;
		}
	}

	static public class DecimalRangeVarianceExtensions
	{
		static public decimal GetCenter(this DecimalRange item)
		{
			return (decimal)((item.x1 + item.x2) / 2);
		}
		static public decimal GetRadius(this DecimalRange item)
		{
			return (decimal)(item.GetWidth() / 2);
		}

		static public decimal GetBoundA(this DecimalVariance item)
		{
			return (decimal)(item.value - item.radius);
		}
		static public decimal GetBoundB(this DecimalVariance item)
		{
			return (decimal)(item.value + item.radius);
		}

		static public decimal GetWidth(this DecimalRange item)
		{
			return (decimal)(item.x2 - item.x1);
		}
		static public decimal GetWidth(this DecimalVariance item)
		{
			return (decimal)(item.radius * 2);
		}

		static public DecimalVariance GetVariance(this DecimalRange item)
		{
			return new DecimalVariance(item.GetCenter(), item.GetRadius());
		}
		static public DecimalRange GetRange(this DecimalVariance item)
		{
			return new DecimalRange(item.GetBoundA(), item.GetBoundB());
		}
	}

}

