using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	
	[Serializable]
    public struct ByteRange
	{
		public readonly byte x1;
		public readonly byte x2;

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
	static public class ByteRangeExtensions
	{
		static public byte GetWidth(this ByteRange item)
		{
			return (byte)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct ShortRange
	{
		public readonly short x1;
		public readonly short x2;

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
	static public class ShortRangeExtensions
	{
		static public short GetWidth(this ShortRange item)
		{
			return (short)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct IntRange
	{
		public readonly int x1;
		public readonly int x2;

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
	static public class IntRangeExtensions
	{
		static public int GetWidth(this IntRange item)
		{
			return (int)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct LongRange
	{
		public readonly long x1;
		public readonly long x2;

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
	static public class LongRangeExtensions
	{
		static public long GetWidth(this LongRange item)
		{
			return (long)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct FloatRange
	{
		public readonly float x1;
		public readonly float x2;

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
	static public class FloatRangeExtensions
	{
		static public float GetWidth(this FloatRange item)
		{
			return (float)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct DoubleRange
	{
		public readonly double x1;
		public readonly double x2;

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
	static public class DoubleRangeExtensions
	{
		static public double GetWidth(this DoubleRange item)
		{
			return (double)(item.x2 - item.x1);
		}
	}

	
	[Serializable]
    public struct DecimalRange
	{
		public readonly decimal x1;
		public readonly decimal x2;

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
	static public class DecimalRangeExtensions
	{
		static public decimal GetWidth(this DecimalRange item)
		{
			return (decimal)(item.x2 - item.x1);
		}
	}

}

