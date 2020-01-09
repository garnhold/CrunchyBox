using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{

	public class IdentifiableBool : Identifiable
	{
		private bool value;

		static public implicit operator IdentifiableBool(bool v) { return v.MakeIdentifiable(); }
		static public implicit operator bool(IdentifiableBool i) { return i.GetValue(); }

		public IdentifiableBool(bool v)
		{
			value = v;
		}

		public bool GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableBool cast;

			if(obj.Convert<IdentifiableBool>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableBoolExtensions
	{
		static public IEnumerable<bool> GetValues(this IEnumerable<IdentifiableBool> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableBool MakeIdentifiable(this bool item)
		{
			return new IdentifiableBool(item);
		}
		static public IdentifiableEnumerable<IdentifiableBool> MakeIdentifiable(this IEnumerable<bool> item)
		{
			return new IdentifiableEnumerable<IdentifiableBool>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableByte : Identifiable
	{
		private byte value;

		static public implicit operator IdentifiableByte(byte v) { return v.MakeIdentifiable(); }
		static public implicit operator byte(IdentifiableByte i) { return i.GetValue(); }

		public IdentifiableByte(byte v)
		{
			value = v;
		}

		public byte GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableByte cast;

			if(obj.Convert<IdentifiableByte>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableByteExtensions
	{
		static public IEnumerable<byte> GetValues(this IEnumerable<IdentifiableByte> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableByte MakeIdentifiable(this byte item)
		{
			return new IdentifiableByte(item);
		}
		static public IdentifiableEnumerable<IdentifiableByte> MakeIdentifiable(this IEnumerable<byte> item)
		{
			return new IdentifiableEnumerable<IdentifiableByte>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableShort : Identifiable
	{
		private short value;

		static public implicit operator IdentifiableShort(short v) { return v.MakeIdentifiable(); }
		static public implicit operator short(IdentifiableShort i) { return i.GetValue(); }

		public IdentifiableShort(short v)
		{
			value = v;
		}

		public short GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableShort cast;

			if(obj.Convert<IdentifiableShort>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableShortExtensions
	{
		static public IEnumerable<short> GetValues(this IEnumerable<IdentifiableShort> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableShort MakeIdentifiable(this short item)
		{
			return new IdentifiableShort(item);
		}
		static public IdentifiableEnumerable<IdentifiableShort> MakeIdentifiable(this IEnumerable<short> item)
		{
			return new IdentifiableEnumerable<IdentifiableShort>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableInt : Identifiable
	{
		private int value;

		static public implicit operator IdentifiableInt(int v) { return v.MakeIdentifiable(); }
		static public implicit operator int(IdentifiableInt i) { return i.GetValue(); }

		public IdentifiableInt(int v)
		{
			value = v;
		}

		public int GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableInt cast;

			if(obj.Convert<IdentifiableInt>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableIntExtensions
	{
		static public IEnumerable<int> GetValues(this IEnumerable<IdentifiableInt> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableInt MakeIdentifiable(this int item)
		{
			return new IdentifiableInt(item);
		}
		static public IdentifiableEnumerable<IdentifiableInt> MakeIdentifiable(this IEnumerable<int> item)
		{
			return new IdentifiableEnumerable<IdentifiableInt>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableLong : Identifiable
	{
		private long value;

		static public implicit operator IdentifiableLong(long v) { return v.MakeIdentifiable(); }
		static public implicit operator long(IdentifiableLong i) { return i.GetValue(); }

		public IdentifiableLong(long v)
		{
			value = v;
		}

		public long GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableLong cast;

			if(obj.Convert<IdentifiableLong>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableLongExtensions
	{
		static public IEnumerable<long> GetValues(this IEnumerable<IdentifiableLong> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableLong MakeIdentifiable(this long item)
		{
			return new IdentifiableLong(item);
		}
		static public IdentifiableEnumerable<IdentifiableLong> MakeIdentifiable(this IEnumerable<long> item)
		{
			return new IdentifiableEnumerable<IdentifiableLong>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableFloat : Identifiable
	{
		private float value;

		static public implicit operator IdentifiableFloat(float v) { return v.MakeIdentifiable(); }
		static public implicit operator float(IdentifiableFloat i) { return i.GetValue(); }

		public IdentifiableFloat(float v)
		{
			value = v;
		}

		public float GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableFloat cast;

			if(obj.Convert<IdentifiableFloat>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableFloatExtensions
	{
		static public IEnumerable<float> GetValues(this IEnumerable<IdentifiableFloat> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableFloat MakeIdentifiable(this float item)
		{
			return new IdentifiableFloat(item);
		}
		static public IdentifiableEnumerable<IdentifiableFloat> MakeIdentifiable(this IEnumerable<float> item)
		{
			return new IdentifiableEnumerable<IdentifiableFloat>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableDouble : Identifiable
	{
		private double value;

		static public implicit operator IdentifiableDouble(double v) { return v.MakeIdentifiable(); }
		static public implicit operator double(IdentifiableDouble i) { return i.GetValue(); }

		public IdentifiableDouble(double v)
		{
			value = v;
		}

		public double GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableDouble cast;

			if(obj.Convert<IdentifiableDouble>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableDoubleExtensions
	{
		static public IEnumerable<double> GetValues(this IEnumerable<IdentifiableDouble> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableDouble MakeIdentifiable(this double item)
		{
			return new IdentifiableDouble(item);
		}
		static public IdentifiableEnumerable<IdentifiableDouble> MakeIdentifiable(this IEnumerable<double> item)
		{
			return new IdentifiableEnumerable<IdentifiableDouble>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableDecimal : Identifiable
	{
		private decimal value;

		static public implicit operator IdentifiableDecimal(decimal v) { return v.MakeIdentifiable(); }
		static public implicit operator decimal(IdentifiableDecimal i) { return i.GetValue(); }

		public IdentifiableDecimal(decimal v)
		{
			value = v;
		}

		public decimal GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableDecimal cast;

			if(obj.Convert<IdentifiableDecimal>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableDecimalExtensions
	{
		static public IEnumerable<decimal> GetValues(this IEnumerable<IdentifiableDecimal> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableDecimal MakeIdentifiable(this decimal item)
		{
			return new IdentifiableDecimal(item);
		}
		static public IdentifiableEnumerable<IdentifiableDecimal> MakeIdentifiable(this IEnumerable<decimal> item)
		{
			return new IdentifiableEnumerable<IdentifiableDecimal>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableString : Identifiable
	{
		private string value;

		static public implicit operator IdentifiableString(string v) { return v.MakeIdentifiable(); }
		static public implicit operator string(IdentifiableString i) { return i.GetValue(); }

		public IdentifiableString(string v)
		{
			value = v;
		}

		public string GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableString cast;

			if(obj.Convert<IdentifiableString>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableStringExtensions
	{
		static public IEnumerable<string> GetValues(this IEnumerable<IdentifiableString> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableString MakeIdentifiable(this string item)
		{
			return new IdentifiableString(item);
		}
		static public IdentifiableEnumerable<IdentifiableString> MakeIdentifiable(this IEnumerable<string> item)
		{
			return new IdentifiableEnumerable<IdentifiableString>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableAssembly : Identifiable
	{
		private Assembly value;

		static public implicit operator IdentifiableAssembly(Assembly v) { return v.MakeIdentifiable(); }
		static public implicit operator Assembly(IdentifiableAssembly i) { return i.GetValue(); }

		public IdentifiableAssembly(Assembly v)
		{
			value = v;
		}

		public Assembly GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableAssembly cast;

			if(obj.Convert<IdentifiableAssembly>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableAssemblyExtensions
	{
		static public IEnumerable<Assembly> GetValues(this IEnumerable<IdentifiableAssembly> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableAssembly MakeIdentifiable(this Assembly item)
		{
			return new IdentifiableAssembly(item);
		}
		static public IdentifiableEnumerable<IdentifiableAssembly> MakeIdentifiable(this IEnumerable<Assembly> item)
		{
			return new IdentifiableEnumerable<IdentifiableAssembly>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}

	public class IdentifiableType : Identifiable
	{
		private Type value;

		static public implicit operator IdentifiableType(Type v) { return v.MakeIdentifiable(); }
		static public implicit operator Type(IdentifiableType i) { return i.GetValue(); }

		public IdentifiableType(Type v)
		{
			value = v;
		}

		public Type GetValue()
		{
			return value;
		}

		public string GetIdentity()
		{
			return value.ToStringEX();
		}

		public override bool Equals(object obj)
		{
			IdentifiableType cast;

			if(obj.Convert<IdentifiableType>(out cast))
			{
				if(cast.value.EqualsEX(value))
					return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return value.GetHashCodeEX();
		}
	}
	static public class IdentifiableTypeExtensions
	{
		static public IEnumerable<Type> GetValues(this IEnumerable<IdentifiableType> item)
		{
			return item.Convert(i => i.GetValue());
		}

		static public IdentifiableType MakeIdentifiable(this Type item)
		{
			return new IdentifiableType(item);
		}
		static public IdentifiableEnumerable<IdentifiableType> MakeIdentifiable(this IEnumerable<Type> item)
		{
			return new IdentifiableEnumerable<IdentifiableType>(
				item.Convert(i => i.MakeIdentifiable())
			);
		}
	}
}

