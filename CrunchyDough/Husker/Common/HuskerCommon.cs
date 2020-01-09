using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{

	public class BoolHusker : Husker<bool>
	{
		static public readonly BoolHusker INSTANCE = new BoolHusker();

		private BoolHusker() { }

		public override void Dehydrate(HuskWriter writer, bool to_dehydrate)
		{
			writer.WriteBool(to_dehydrate);
		}

        public override bool Hydrate(HuskReader reader)
		{
			return reader.ReadBool();
		}
	}
	public class BoolListHusker : ListHusker<bool>
	{
		static public readonly BoolListHusker INSTANCE = new BoolListHusker();

		private BoolListHusker() : base(BoolHusker.INSTANCE) { }
	}

	public class ByteHusker : Husker<byte>
	{
		static public readonly ByteHusker INSTANCE = new ByteHusker();

		private ByteHusker() { }

		public override void Dehydrate(HuskWriter writer, byte to_dehydrate)
		{
			writer.WriteByte(to_dehydrate);
		}

        public override byte Hydrate(HuskReader reader)
		{
			return reader.ReadByte();
		}
	}
	public class ByteListHusker : ListHusker<byte>
	{
		static public readonly ByteListHusker INSTANCE = new ByteListHusker();

		private ByteListHusker() : base(ByteHusker.INSTANCE) { }
	}

	public class ShortHusker : Husker<short>
	{
		static public readonly ShortHusker INSTANCE = new ShortHusker();

		private ShortHusker() { }

		public override void Dehydrate(HuskWriter writer, short to_dehydrate)
		{
			writer.WriteShort(to_dehydrate);
		}

        public override short Hydrate(HuskReader reader)
		{
			return reader.ReadShort();
		}
	}
	public class ShortListHusker : ListHusker<short>
	{
		static public readonly ShortListHusker INSTANCE = new ShortListHusker();

		private ShortListHusker() : base(ShortHusker.INSTANCE) { }
	}

	public class IntHusker : Husker<int>
	{
		static public readonly IntHusker INSTANCE = new IntHusker();

		private IntHusker() { }

		public override void Dehydrate(HuskWriter writer, int to_dehydrate)
		{
			writer.WriteInt(to_dehydrate);
		}

        public override int Hydrate(HuskReader reader)
		{
			return reader.ReadInt();
		}
	}
	public class IntListHusker : ListHusker<int>
	{
		static public readonly IntListHusker INSTANCE = new IntListHusker();

		private IntListHusker() : base(IntHusker.INSTANCE) { }
	}

	public class LongHusker : Husker<long>
	{
		static public readonly LongHusker INSTANCE = new LongHusker();

		private LongHusker() { }

		public override void Dehydrate(HuskWriter writer, long to_dehydrate)
		{
			writer.WriteLong(to_dehydrate);
		}

        public override long Hydrate(HuskReader reader)
		{
			return reader.ReadLong();
		}
	}
	public class LongListHusker : ListHusker<long>
	{
		static public readonly LongListHusker INSTANCE = new LongListHusker();

		private LongListHusker() : base(LongHusker.INSTANCE) { }
	}

	public class FloatHusker : Husker<float>
	{
		static public readonly FloatHusker INSTANCE = new FloatHusker();

		private FloatHusker() { }

		public override void Dehydrate(HuskWriter writer, float to_dehydrate)
		{
			writer.WriteFloat(to_dehydrate);
		}

        public override float Hydrate(HuskReader reader)
		{
			return reader.ReadFloat();
		}
	}
	public class FloatListHusker : ListHusker<float>
	{
		static public readonly FloatListHusker INSTANCE = new FloatListHusker();

		private FloatListHusker() : base(FloatHusker.INSTANCE) { }
	}

	public class DoubleHusker : Husker<double>
	{
		static public readonly DoubleHusker INSTANCE = new DoubleHusker();

		private DoubleHusker() { }

		public override void Dehydrate(HuskWriter writer, double to_dehydrate)
		{
			writer.WriteDouble(to_dehydrate);
		}

        public override double Hydrate(HuskReader reader)
		{
			return reader.ReadDouble();
		}
	}
	public class DoubleListHusker : ListHusker<double>
	{
		static public readonly DoubleListHusker INSTANCE = new DoubleListHusker();

		private DoubleListHusker() : base(DoubleHusker.INSTANCE) { }
	}

	public class DecimalHusker : Husker<decimal>
	{
		static public readonly DecimalHusker INSTANCE = new DecimalHusker();

		private DecimalHusker() { }

		public override void Dehydrate(HuskWriter writer, decimal to_dehydrate)
		{
			writer.WriteDecimal(to_dehydrate);
		}

        public override decimal Hydrate(HuskReader reader)
		{
			return reader.ReadDecimal();
		}
	}
	public class DecimalListHusker : ListHusker<decimal>
	{
		static public readonly DecimalListHusker INSTANCE = new DecimalListHusker();

		private DecimalListHusker() : base(DecimalHusker.INSTANCE) { }
	}

	public class StringHusker : Husker<string>
	{
		static public readonly StringHusker INSTANCE = new StringHusker();

		private StringHusker() { }

		public override void Dehydrate(HuskWriter writer, string to_dehydrate)
		{
			writer.WriteString(to_dehydrate);
		}

        public override string Hydrate(HuskReader reader)
		{
			return reader.ReadString();
		}
	}
	public class StringListHusker : ListHusker<string>
	{
		static public readonly StringListHusker INSTANCE = new StringListHusker();

		private StringListHusker() : base(StringHusker.INSTANCE) { }
	}
}

