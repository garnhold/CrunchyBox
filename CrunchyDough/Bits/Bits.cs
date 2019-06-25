using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ByteBits
	{
		public const int NUMBER_BITS = 8;
		public const int NUMBER_BYTES = 1;

			public const byte BIT0 = 1 << 0;
			public const byte BIT1 = 1 << 1;
			public const byte BIT2 = 1 << 2;
			public const byte BIT3 = 1 << 3;
			public const byte BIT4 = 1 << 4;
			public const byte BIT5 = 1 << 5;
			public const byte BIT6 = 1 << 6;
			public const byte BIT7 = 1 << 7;
	
			public const byte BYTE0_NIBBLE0_HALF0 = BIT0 | BIT1;
        public const byte BYTE0_NIBBLE0_HALF1 = BIT2 | BIT3;
        public const byte BYTE0_NIBBLE0 = BYTE0_NIBBLE0_HALF0 | BYTE0_NIBBLE0_HALF1;

        public const byte BYTE0_NIBBLE1_HALF0 = BIT4 | BIT5;
        public const byte BYTE0_NIBBLE1_HALF1 = BIT6 | BIT7;
        public const byte BYTE0_NIBBLE1 = BYTE0_NIBBLE1_HALF0 | BYTE0_NIBBLE1_HALF1;

        public const byte BYTE0 = BYTE0_NIBBLE0 | BYTE0_NIBBLE1;
	
	
	
		public const byte NO_BITS = 0;
		public const byte ALL_BITS = BYTE0;

		static public byte Get(bool bit0, bool bit1, bool bit2, bool bit3, bool bit4, bool bit5, bool bit6, bool bit7)
		{
			byte value = 0;

				if(bit0)value |= BIT0;
				if(bit1)value |= BIT1;
				if(bit2)value |= BIT2;
				if(bit3)value |= BIT3;
				if(bit4)value |= BIT4;
				if(bit5)value |= BIT5;
				if(bit6)value |= BIT6;
				if(bit7)value |= BIT7;
	
			return value;
		}

        static public byte GetNthBitValue(int n)
        {
            return (byte)(1 << n);
        }
	}

	static public class ByteBitsExtensions
	{
		static public byte GetBitUnion(this byte item, byte other)
		{
			return (byte)(item | other);
		}

		static public byte GetBitIntersection(this byte item, byte other)
		{
			return (byte)(item & other);
		}

		static public byte GetBitExclusion(this byte item, byte other)
		{
			return (byte)(item & (~other));
		}

		static public bool HasAnyBits(this byte item, byte bits)
        {
            if ((item & bits) != 0)
                return true;

            return false;
        }

        static public bool HasAllBits(this byte item, byte bits)
        {
            if ((item & bits) == bits)
                return true;

            return false;
        }

        static public bool HasNoBits(this byte item, byte bits)
        {
            if ((item & bits) == 0)
                return true;

            return false;
        }

		static public bool HasNoOtherBits(this byte item, byte bits)
		{
			if ((item & (~bits)) == 0)
				return true;

			return false;
		}

		static public bool HasNthBit(this byte item, int n)
		{
			if(item.HasAllBits(ByteBits.GetNthBitValue(n)))
				return true;

			return false;
		}

	
		static private byte[] LOWEST_BIT_INDEX_TABLE;
		static private byte GetLowestBitIndexInternal(this byte item)
		{
			unchecked
			{
				if(item.HasAnyBits((byte)0x0F))
{
if(item.HasAnyBits((byte)0x03))
{
if(item.HasAnyBits((byte)0x01))
{
return 0;}
else
{
return 1;}
}
else
{
if(item.HasAnyBits((byte)0x04))
{
return 2;}
else
{
return 3;}
}
}
else
{
if(item.HasAnyBits((byte)0x30))
{
if(item.HasAnyBits((byte)0x10))
{
return 4;}
else
{
return 5;}
}
else
{
if(item.HasAnyBits((byte)0x40))
{
return 6;}
else
{
return 7;}
}
}

			}
		}
		static public byte GetLowestBitIndex(this byte item)
		{
			if(LOWEST_BIT_INDEX_TABLE == null)
				LOWEST_BIT_INDEX_TABLE = Ints.Range(0, byte.MaxValue, true).Convert(i => GetLowestBitIndexInternal((byte)i)).ToArray();

			return LOWEST_BIT_INDEX_TABLE[item];
		}

		static private byte[] HIGHEST_BIT_INDEX_TABLE;
		static private byte GetHighestBitIndexInternal(this byte item)
		{
			unchecked
			{
				if(item.HasAnyBits((byte)0xF0))
{
if(item.HasAnyBits((byte)0xC0))
{
if(item.HasAnyBits((byte)0x80))
{
return 7;}
else
{
return 6;}
}
else
{
if(item.HasAnyBits((byte)0x20))
{
return 5;}
else
{
return 4;}
}
}
else
{
if(item.HasAnyBits((byte)0x0C))
{
if(item.HasAnyBits((byte)0x08))
{
return 3;}
else
{
return 2;}
}
else
{
if(item.HasAnyBits((byte)0x02))
{
return 1;}
else
{
return 0;}
}
}

			}
		}
		static public byte GetHighestBitIndex(this byte item)
		{
			if(HIGHEST_BIT_INDEX_TABLE == null)
				HIGHEST_BIT_INDEX_TABLE = Ints.Range(0, byte.MaxValue, true).Convert(i => GetHighestBitIndexInternal((byte)i)).ToArray();

			return HIGHEST_BIT_INDEX_TABLE[item];
		}

		static private byte[] NUMBER_BITS_TABLE;
		static private byte GetNumberBitsInternal(this byte item)
		{
			unchecked
			{
				byte count = 0;
if(item.HasAnyBits((byte)0x0F))
{
if(item.HasAnyBits((byte)0x03))
{
if(item.HasAnyBits((byte)0x01))
{
count++;}
if(item.HasAnyBits((byte)0x02))
{
count++;}
}
if(item.HasAnyBits((byte)0x0C))
{
if(item.HasAnyBits((byte)0x04))
{
count++;}
if(item.HasAnyBits((byte)0x08))
{
count++;}
}
}
if(item.HasAnyBits((byte)0xF0))
{
if(item.HasAnyBits((byte)0x30))
{
if(item.HasAnyBits((byte)0x10))
{
count++;}
if(item.HasAnyBits((byte)0x20))
{
count++;}
}
if(item.HasAnyBits((byte)0xC0))
{
if(item.HasAnyBits((byte)0x40))
{
count++;}
if(item.HasAnyBits((byte)0x80))
{
count++;}
}
}

return count;
			}
		}
		static public byte GetNumberBits(this byte item)
		{
			if(NUMBER_BITS_TABLE == null)
				 NUMBER_BITS_TABLE = Ints.Range(0, byte.MaxValue, true).Convert(i => GetNumberBitsInternal((byte)i)).ToArray();

			return NUMBER_BITS_TABLE[item];
		}
	
		static public IEnumerable<byte> GetBitIndexs(this byte item)
		{
			unchecked
			{
				if(item.HasAnyBits((byte)0x0F))
{
if(item.HasAnyBits((byte)0x03))
{
if(item.HasAnyBits((byte)0x01))
{
yield return 0;}
if(item.HasAnyBits((byte)0x02))
{
yield return 1;}
}
if(item.HasAnyBits((byte)0x0C))
{
if(item.HasAnyBits((byte)0x04))
{
yield return 2;}
if(item.HasAnyBits((byte)0x08))
{
yield return 3;}
}
}
if(item.HasAnyBits((byte)0xF0))
{
if(item.HasAnyBits((byte)0x30))
{
if(item.HasAnyBits((byte)0x10))
{
yield return 4;}
if(item.HasAnyBits((byte)0x20))
{
yield return 5;}
}
if(item.HasAnyBits((byte)0xC0))
{
if(item.HasAnyBits((byte)0x40))
{
yield return 6;}
if(item.HasAnyBits((byte)0x80))
{
yield return 7;}
}
}

			}
		}
	
		static public byte GetLowestBitValue(this byte item)
        {
            return ByteBits.GetNthBitValue(item.GetLowestBitIndex());
        }

		static public byte GetHighestBitValue(this byte item)
        {
            return ByteBits.GetNthBitValue(item.GetHighestBitIndex());
        }

	
			static public byte BitwiseOR(this IEnumerable<byte> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (byte)(v1 | v2));
		}
			static public byte BitwiseAND(this IEnumerable<byte> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (byte)(v1 & v2));
		}
			static public byte BitwiseXOR(this IEnumerable<byte> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (byte)(v1 ^ v2));
		}
		}
    static public class IntBits
	{
		public const int NUMBER_BITS = 32;
		public const int NUMBER_BYTES = 4;

			public const int BIT0 = 1 << 0;
			public const int BIT1 = 1 << 1;
			public const int BIT2 = 1 << 2;
			public const int BIT3 = 1 << 3;
			public const int BIT4 = 1 << 4;
			public const int BIT5 = 1 << 5;
			public const int BIT6 = 1 << 6;
			public const int BIT7 = 1 << 7;
			public const int BIT8 = 1 << 8;
			public const int BIT9 = 1 << 9;
			public const int BIT10 = 1 << 10;
			public const int BIT11 = 1 << 11;
			public const int BIT12 = 1 << 12;
			public const int BIT13 = 1 << 13;
			public const int BIT14 = 1 << 14;
			public const int BIT15 = 1 << 15;
			public const int BIT16 = 1 << 16;
			public const int BIT17 = 1 << 17;
			public const int BIT18 = 1 << 18;
			public const int BIT19 = 1 << 19;
			public const int BIT20 = 1 << 20;
			public const int BIT21 = 1 << 21;
			public const int BIT22 = 1 << 22;
			public const int BIT23 = 1 << 23;
			public const int BIT24 = 1 << 24;
			public const int BIT25 = 1 << 25;
			public const int BIT26 = 1 << 26;
			public const int BIT27 = 1 << 27;
			public const int BIT28 = 1 << 28;
			public const int BIT29 = 1 << 29;
			public const int BIT30 = 1 << 30;
			public const int BIT31 = 1 << 31;
	
			public const int BYTE0_NIBBLE0_HALF0 = BIT0 | BIT1;
        public const int BYTE0_NIBBLE0_HALF1 = BIT2 | BIT3;
        public const int BYTE0_NIBBLE0 = BYTE0_NIBBLE0_HALF0 | BYTE0_NIBBLE0_HALF1;

        public const int BYTE0_NIBBLE1_HALF0 = BIT4 | BIT5;
        public const int BYTE0_NIBBLE1_HALF1 = BIT6 | BIT7;
        public const int BYTE0_NIBBLE1 = BYTE0_NIBBLE1_HALF0 | BYTE0_NIBBLE1_HALF1;

        public const int BYTE0 = BYTE0_NIBBLE0 | BYTE0_NIBBLE1;
			public const int BYTE1_NIBBLE0_HALF0 = BIT8 | BIT9;
        public const int BYTE1_NIBBLE0_HALF1 = BIT10 | BIT11;
        public const int BYTE1_NIBBLE0 = BYTE1_NIBBLE0_HALF0 | BYTE1_NIBBLE0_HALF1;

        public const int BYTE1_NIBBLE1_HALF0 = BIT12 | BIT13;
        public const int BYTE1_NIBBLE1_HALF1 = BIT14 | BIT15;
        public const int BYTE1_NIBBLE1 = BYTE1_NIBBLE1_HALF0 | BYTE1_NIBBLE1_HALF1;

        public const int BYTE1 = BYTE1_NIBBLE0 | BYTE1_NIBBLE1;
			public const int BYTE2_NIBBLE0_HALF0 = BIT16 | BIT17;
        public const int BYTE2_NIBBLE0_HALF1 = BIT18 | BIT19;
        public const int BYTE2_NIBBLE0 = BYTE2_NIBBLE0_HALF0 | BYTE2_NIBBLE0_HALF1;

        public const int BYTE2_NIBBLE1_HALF0 = BIT20 | BIT21;
        public const int BYTE2_NIBBLE1_HALF1 = BIT22 | BIT23;
        public const int BYTE2_NIBBLE1 = BYTE2_NIBBLE1_HALF0 | BYTE2_NIBBLE1_HALF1;

        public const int BYTE2 = BYTE2_NIBBLE0 | BYTE2_NIBBLE1;
			public const int BYTE3_NIBBLE0_HALF0 = BIT24 | BIT25;
        public const int BYTE3_NIBBLE0_HALF1 = BIT26 | BIT27;
        public const int BYTE3_NIBBLE0 = BYTE3_NIBBLE0_HALF0 | BYTE3_NIBBLE0_HALF1;

        public const int BYTE3_NIBBLE1_HALF0 = BIT28 | BIT29;
        public const int BYTE3_NIBBLE1_HALF1 = BIT30 | BIT31;
        public const int BYTE3_NIBBLE1 = BYTE3_NIBBLE1_HALF0 | BYTE3_NIBBLE1_HALF1;

        public const int BYTE3 = BYTE3_NIBBLE0 | BYTE3_NIBBLE1;
	
			public const int BYTE0_BYTE1 = BYTE0 | BYTE1;
			public const int BYTE2_BYTE3 = BYTE2 | BYTE3;
	
			public const int BYTE0_BYTE1_BYTE2_BYTE3 = BYTE0 | BYTE1 | BYTE2 | BYTE3;
	
		public const int NO_BITS = 0;
		public const int ALL_BITS = BYTE0_BYTE1_BYTE2_BYTE3;

		static public int Get(bool bit0, bool bit1, bool bit2, bool bit3, bool bit4, bool bit5, bool bit6, bool bit7, bool bit8, bool bit9, bool bit10, bool bit11, bool bit12, bool bit13, bool bit14, bool bit15, bool bit16, bool bit17, bool bit18, bool bit19, bool bit20, bool bit21, bool bit22, bool bit23, bool bit24, bool bit25, bool bit26, bool bit27, bool bit28, bool bit29, bool bit30, bool bit31)
		{
			int value = 0;

				if(bit0)value |= BIT0;
				if(bit1)value |= BIT1;
				if(bit2)value |= BIT2;
				if(bit3)value |= BIT3;
				if(bit4)value |= BIT4;
				if(bit5)value |= BIT5;
				if(bit6)value |= BIT6;
				if(bit7)value |= BIT7;
				if(bit8)value |= BIT8;
				if(bit9)value |= BIT9;
				if(bit10)value |= BIT10;
				if(bit11)value |= BIT11;
				if(bit12)value |= BIT12;
				if(bit13)value |= BIT13;
				if(bit14)value |= BIT14;
				if(bit15)value |= BIT15;
				if(bit16)value |= BIT16;
				if(bit17)value |= BIT17;
				if(bit18)value |= BIT18;
				if(bit19)value |= BIT19;
				if(bit20)value |= BIT20;
				if(bit21)value |= BIT21;
				if(bit22)value |= BIT22;
				if(bit23)value |= BIT23;
				if(bit24)value |= BIT24;
				if(bit25)value |= BIT25;
				if(bit26)value |= BIT26;
				if(bit27)value |= BIT27;
				if(bit28)value |= BIT28;
				if(bit29)value |= BIT29;
				if(bit30)value |= BIT30;
				if(bit31)value |= BIT31;
	
			return value;
		}

        static public int GetNthBitValue(int n)
        {
            return (int)(1 << n);
        }
	}

	static public class IntBitsExtensions
	{
		static public int GetBitUnion(this int item, int other)
		{
			return (int)(item | other);
		}

		static public int GetBitIntersection(this int item, int other)
		{
			return (int)(item & other);
		}

		static public int GetBitExclusion(this int item, int other)
		{
			return (int)(item & (~other));
		}

		static public bool HasAnyBits(this int item, int bits)
        {
            if ((item & bits) != 0)
                return true;

            return false;
        }

        static public bool HasAllBits(this int item, int bits)
        {
            if ((item & bits) == bits)
                return true;

            return false;
        }

        static public bool HasNoBits(this int item, int bits)
        {
            if ((item & bits) == 0)
                return true;

            return false;
        }

		static public bool HasNoOtherBits(this int item, int bits)
		{
			if ((item & (~bits)) == 0)
				return true;

			return false;
		}

		static public bool HasNthBit(this int item, int n)
		{
			if(item.HasAllBits(IntBits.GetNthBitValue(n)))
				return true;

			return false;
		}

	
		static public byte GetLowestBitIndex(this int item)
		{
			unchecked
			{
				if(item.HasAnyBits((int)0x0000FFFF))
{
if(item.HasAnyBits((int)0x000000FF))
{
if(item.HasAnyBits((int)0x0000000F))
{
if(item.HasAnyBits((int)0x00000003))
{
if(item.HasAnyBits((int)0x00000001))
{
return 0;}
else
{
return 1;}
}
else
{
if(item.HasAnyBits((int)0x00000004))
{
return 2;}
else
{
return 3;}
}
}
else
{
if(item.HasAnyBits((int)0x00000030))
{
if(item.HasAnyBits((int)0x00000010))
{
return 4;}
else
{
return 5;}
}
else
{
if(item.HasAnyBits((int)0x00000040))
{
return 6;}
else
{
return 7;}
}
}
}
else
{
if(item.HasAnyBits((int)0x00000F00))
{
if(item.HasAnyBits((int)0x00000300))
{
if(item.HasAnyBits((int)0x00000100))
{
return 8;}
else
{
return 9;}
}
else
{
if(item.HasAnyBits((int)0x00000400))
{
return 10;}
else
{
return 11;}
}
}
else
{
if(item.HasAnyBits((int)0x00003000))
{
if(item.HasAnyBits((int)0x00001000))
{
return 12;}
else
{
return 13;}
}
else
{
if(item.HasAnyBits((int)0x00004000))
{
return 14;}
else
{
return 15;}
}
}
}
}
else
{
if(item.HasAnyBits((int)0x00FF0000))
{
if(item.HasAnyBits((int)0x000F0000))
{
if(item.HasAnyBits((int)0x00030000))
{
if(item.HasAnyBits((int)0x00010000))
{
return 16;}
else
{
return 17;}
}
else
{
if(item.HasAnyBits((int)0x00040000))
{
return 18;}
else
{
return 19;}
}
}
else
{
if(item.HasAnyBits((int)0x00300000))
{
if(item.HasAnyBits((int)0x00100000))
{
return 20;}
else
{
return 21;}
}
else
{
if(item.HasAnyBits((int)0x00400000))
{
return 22;}
else
{
return 23;}
}
}
}
else
{
if(item.HasAnyBits((int)0x0F000000))
{
if(item.HasAnyBits((int)0x03000000))
{
if(item.HasAnyBits((int)0x01000000))
{
return 24;}
else
{
return 25;}
}
else
{
if(item.HasAnyBits((int)0x04000000))
{
return 26;}
else
{
return 27;}
}
}
else
{
if(item.HasAnyBits((int)0x30000000))
{
if(item.HasAnyBits((int)0x10000000))
{
return 28;}
else
{
return 29;}
}
else
{
if(item.HasAnyBits((int)0x40000000))
{
return 30;}
else
{
return 31;}
}
}
}
}

			}
		}

		static public byte GetHighestBitIndex(this int item)
		{
			unchecked
			{
				if(item.HasAnyBits((int)0xFFFF0000))
{
if(item.HasAnyBits((int)0xFF000000))
{
if(item.HasAnyBits((int)0xF0000000))
{
if(item.HasAnyBits((int)0xC0000000))
{
if(item.HasAnyBits((int)0x80000000))
{
return 31;}
else
{
return 30;}
}
else
{
if(item.HasAnyBits((int)0x20000000))
{
return 29;}
else
{
return 28;}
}
}
else
{
if(item.HasAnyBits((int)0x0C000000))
{
if(item.HasAnyBits((int)0x08000000))
{
return 27;}
else
{
return 26;}
}
else
{
if(item.HasAnyBits((int)0x02000000))
{
return 25;}
else
{
return 24;}
}
}
}
else
{
if(item.HasAnyBits((int)0x00F00000))
{
if(item.HasAnyBits((int)0x00C00000))
{
if(item.HasAnyBits((int)0x00800000))
{
return 23;}
else
{
return 22;}
}
else
{
if(item.HasAnyBits((int)0x00200000))
{
return 21;}
else
{
return 20;}
}
}
else
{
if(item.HasAnyBits((int)0x000C0000))
{
if(item.HasAnyBits((int)0x00080000))
{
return 19;}
else
{
return 18;}
}
else
{
if(item.HasAnyBits((int)0x00020000))
{
return 17;}
else
{
return 16;}
}
}
}
}
else
{
if(item.HasAnyBits((int)0x0000FF00))
{
if(item.HasAnyBits((int)0x0000F000))
{
if(item.HasAnyBits((int)0x0000C000))
{
if(item.HasAnyBits((int)0x00008000))
{
return 15;}
else
{
return 14;}
}
else
{
if(item.HasAnyBits((int)0x00002000))
{
return 13;}
else
{
return 12;}
}
}
else
{
if(item.HasAnyBits((int)0x00000C00))
{
if(item.HasAnyBits((int)0x00000800))
{
return 11;}
else
{
return 10;}
}
else
{
if(item.HasAnyBits((int)0x00000200))
{
return 9;}
else
{
return 8;}
}
}
}
else
{
if(item.HasAnyBits((int)0x000000F0))
{
if(item.HasAnyBits((int)0x000000C0))
{
if(item.HasAnyBits((int)0x00000080))
{
return 7;}
else
{
return 6;}
}
else
{
if(item.HasAnyBits((int)0x00000020))
{
return 5;}
else
{
return 4;}
}
}
else
{
if(item.HasAnyBits((int)0x0000000C))
{
if(item.HasAnyBits((int)0x00000008))
{
return 3;}
else
{
return 2;}
}
else
{
if(item.HasAnyBits((int)0x00000002))
{
return 1;}
else
{
return 0;}
}
}
}
}

			}
		}

		static public byte GetNumberBits(this int item)
		{
			unchecked
			{
				byte count = 0;
if(item.HasAnyBits((int)0x0000FFFF))
{
if(item.HasAnyBits((int)0x000000FF))
{
if(item.HasAnyBits((int)0x0000000F))
{
if(item.HasAnyBits((int)0x00000003))
{
if(item.HasAnyBits((int)0x00000001))
{
count++;}
if(item.HasAnyBits((int)0x00000002))
{
count++;}
}
if(item.HasAnyBits((int)0x0000000C))
{
if(item.HasAnyBits((int)0x00000004))
{
count++;}
if(item.HasAnyBits((int)0x00000008))
{
count++;}
}
}
if(item.HasAnyBits((int)0x000000F0))
{
if(item.HasAnyBits((int)0x00000030))
{
if(item.HasAnyBits((int)0x00000010))
{
count++;}
if(item.HasAnyBits((int)0x00000020))
{
count++;}
}
if(item.HasAnyBits((int)0x000000C0))
{
if(item.HasAnyBits((int)0x00000040))
{
count++;}
if(item.HasAnyBits((int)0x00000080))
{
count++;}
}
}
}
if(item.HasAnyBits((int)0x0000FF00))
{
if(item.HasAnyBits((int)0x00000F00))
{
if(item.HasAnyBits((int)0x00000300))
{
if(item.HasAnyBits((int)0x00000100))
{
count++;}
if(item.HasAnyBits((int)0x00000200))
{
count++;}
}
if(item.HasAnyBits((int)0x00000C00))
{
if(item.HasAnyBits((int)0x00000400))
{
count++;}
if(item.HasAnyBits((int)0x00000800))
{
count++;}
}
}
if(item.HasAnyBits((int)0x0000F000))
{
if(item.HasAnyBits((int)0x00003000))
{
if(item.HasAnyBits((int)0x00001000))
{
count++;}
if(item.HasAnyBits((int)0x00002000))
{
count++;}
}
if(item.HasAnyBits((int)0x0000C000))
{
if(item.HasAnyBits((int)0x00004000))
{
count++;}
if(item.HasAnyBits((int)0x00008000))
{
count++;}
}
}
}
}
if(item.HasAnyBits((int)0xFFFF0000))
{
if(item.HasAnyBits((int)0x00FF0000))
{
if(item.HasAnyBits((int)0x000F0000))
{
if(item.HasAnyBits((int)0x00030000))
{
if(item.HasAnyBits((int)0x00010000))
{
count++;}
if(item.HasAnyBits((int)0x00020000))
{
count++;}
}
if(item.HasAnyBits((int)0x000C0000))
{
if(item.HasAnyBits((int)0x00040000))
{
count++;}
if(item.HasAnyBits((int)0x00080000))
{
count++;}
}
}
if(item.HasAnyBits((int)0x00F00000))
{
if(item.HasAnyBits((int)0x00300000))
{
if(item.HasAnyBits((int)0x00100000))
{
count++;}
if(item.HasAnyBits((int)0x00200000))
{
count++;}
}
if(item.HasAnyBits((int)0x00C00000))
{
if(item.HasAnyBits((int)0x00400000))
{
count++;}
if(item.HasAnyBits((int)0x00800000))
{
count++;}
}
}
}
if(item.HasAnyBits((int)0xFF000000))
{
if(item.HasAnyBits((int)0x0F000000))
{
if(item.HasAnyBits((int)0x03000000))
{
if(item.HasAnyBits((int)0x01000000))
{
count++;}
if(item.HasAnyBits((int)0x02000000))
{
count++;}
}
if(item.HasAnyBits((int)0x0C000000))
{
if(item.HasAnyBits((int)0x04000000))
{
count++;}
if(item.HasAnyBits((int)0x08000000))
{
count++;}
}
}
if(item.HasAnyBits((int)0xF0000000))
{
if(item.HasAnyBits((int)0x30000000))
{
if(item.HasAnyBits((int)0x10000000))
{
count++;}
if(item.HasAnyBits((int)0x20000000))
{
count++;}
}
if(item.HasAnyBits((int)0xC0000000))
{
if(item.HasAnyBits((int)0x40000000))
{
count++;}
if(item.HasAnyBits((int)0x80000000))
{
count++;}
}
}
}
}

return count;
			}
		}
	
		static public IEnumerable<byte> GetBitIndexs(this int item)
		{
			unchecked
			{
				if(item.HasAnyBits((int)0x0000FFFF))
{
if(item.HasAnyBits((int)0x000000FF))
{
if(item.HasAnyBits((int)0x0000000F))
{
if(item.HasAnyBits((int)0x00000003))
{
if(item.HasAnyBits((int)0x00000001))
{
yield return 0;}
if(item.HasAnyBits((int)0x00000002))
{
yield return 1;}
}
if(item.HasAnyBits((int)0x0000000C))
{
if(item.HasAnyBits((int)0x00000004))
{
yield return 2;}
if(item.HasAnyBits((int)0x00000008))
{
yield return 3;}
}
}
if(item.HasAnyBits((int)0x000000F0))
{
if(item.HasAnyBits((int)0x00000030))
{
if(item.HasAnyBits((int)0x00000010))
{
yield return 4;}
if(item.HasAnyBits((int)0x00000020))
{
yield return 5;}
}
if(item.HasAnyBits((int)0x000000C0))
{
if(item.HasAnyBits((int)0x00000040))
{
yield return 6;}
if(item.HasAnyBits((int)0x00000080))
{
yield return 7;}
}
}
}
if(item.HasAnyBits((int)0x0000FF00))
{
if(item.HasAnyBits((int)0x00000F00))
{
if(item.HasAnyBits((int)0x00000300))
{
if(item.HasAnyBits((int)0x00000100))
{
yield return 8;}
if(item.HasAnyBits((int)0x00000200))
{
yield return 9;}
}
if(item.HasAnyBits((int)0x00000C00))
{
if(item.HasAnyBits((int)0x00000400))
{
yield return 10;}
if(item.HasAnyBits((int)0x00000800))
{
yield return 11;}
}
}
if(item.HasAnyBits((int)0x0000F000))
{
if(item.HasAnyBits((int)0x00003000))
{
if(item.HasAnyBits((int)0x00001000))
{
yield return 12;}
if(item.HasAnyBits((int)0x00002000))
{
yield return 13;}
}
if(item.HasAnyBits((int)0x0000C000))
{
if(item.HasAnyBits((int)0x00004000))
{
yield return 14;}
if(item.HasAnyBits((int)0x00008000))
{
yield return 15;}
}
}
}
}
if(item.HasAnyBits((int)0xFFFF0000))
{
if(item.HasAnyBits((int)0x00FF0000))
{
if(item.HasAnyBits((int)0x000F0000))
{
if(item.HasAnyBits((int)0x00030000))
{
if(item.HasAnyBits((int)0x00010000))
{
yield return 16;}
if(item.HasAnyBits((int)0x00020000))
{
yield return 17;}
}
if(item.HasAnyBits((int)0x000C0000))
{
if(item.HasAnyBits((int)0x00040000))
{
yield return 18;}
if(item.HasAnyBits((int)0x00080000))
{
yield return 19;}
}
}
if(item.HasAnyBits((int)0x00F00000))
{
if(item.HasAnyBits((int)0x00300000))
{
if(item.HasAnyBits((int)0x00100000))
{
yield return 20;}
if(item.HasAnyBits((int)0x00200000))
{
yield return 21;}
}
if(item.HasAnyBits((int)0x00C00000))
{
if(item.HasAnyBits((int)0x00400000))
{
yield return 22;}
if(item.HasAnyBits((int)0x00800000))
{
yield return 23;}
}
}
}
if(item.HasAnyBits((int)0xFF000000))
{
if(item.HasAnyBits((int)0x0F000000))
{
if(item.HasAnyBits((int)0x03000000))
{
if(item.HasAnyBits((int)0x01000000))
{
yield return 24;}
if(item.HasAnyBits((int)0x02000000))
{
yield return 25;}
}
if(item.HasAnyBits((int)0x0C000000))
{
if(item.HasAnyBits((int)0x04000000))
{
yield return 26;}
if(item.HasAnyBits((int)0x08000000))
{
yield return 27;}
}
}
if(item.HasAnyBits((int)0xF0000000))
{
if(item.HasAnyBits((int)0x30000000))
{
if(item.HasAnyBits((int)0x10000000))
{
yield return 28;}
if(item.HasAnyBits((int)0x20000000))
{
yield return 29;}
}
if(item.HasAnyBits((int)0xC0000000))
{
if(item.HasAnyBits((int)0x40000000))
{
yield return 30;}
if(item.HasAnyBits((int)0x80000000))
{
yield return 31;}
}
}
}
}

			}
		}
	
		static public int GetLowestBitValue(this int item)
        {
            return IntBits.GetNthBitValue(item.GetLowestBitIndex());
        }

		static public int GetHighestBitValue(this int item)
        {
            return IntBits.GetNthBitValue(item.GetHighestBitIndex());
        }

			static public byte GetNthByte(this int item, int n)
		{
			return (byte)(item >> (n * 8));
		}
	
			static public int BitwiseOR(this IEnumerable<int> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (int)(v1 | v2));
		}
			static public int BitwiseAND(this IEnumerable<int> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (int)(v1 & v2));
		}
			static public int BitwiseXOR(this IEnumerable<int> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (int)(v1 ^ v2));
		}
		}
    static public class LongBits
	{
		public const int NUMBER_BITS = 64;
		public const int NUMBER_BYTES = 8;

			public const long BIT0 = 1L << 0;
			public const long BIT1 = 1L << 1;
			public const long BIT2 = 1L << 2;
			public const long BIT3 = 1L << 3;
			public const long BIT4 = 1L << 4;
			public const long BIT5 = 1L << 5;
			public const long BIT6 = 1L << 6;
			public const long BIT7 = 1L << 7;
			public const long BIT8 = 1L << 8;
			public const long BIT9 = 1L << 9;
			public const long BIT10 = 1L << 10;
			public const long BIT11 = 1L << 11;
			public const long BIT12 = 1L << 12;
			public const long BIT13 = 1L << 13;
			public const long BIT14 = 1L << 14;
			public const long BIT15 = 1L << 15;
			public const long BIT16 = 1L << 16;
			public const long BIT17 = 1L << 17;
			public const long BIT18 = 1L << 18;
			public const long BIT19 = 1L << 19;
			public const long BIT20 = 1L << 20;
			public const long BIT21 = 1L << 21;
			public const long BIT22 = 1L << 22;
			public const long BIT23 = 1L << 23;
			public const long BIT24 = 1L << 24;
			public const long BIT25 = 1L << 25;
			public const long BIT26 = 1L << 26;
			public const long BIT27 = 1L << 27;
			public const long BIT28 = 1L << 28;
			public const long BIT29 = 1L << 29;
			public const long BIT30 = 1L << 30;
			public const long BIT31 = 1L << 31;
			public const long BIT32 = 1L << 32;
			public const long BIT33 = 1L << 33;
			public const long BIT34 = 1L << 34;
			public const long BIT35 = 1L << 35;
			public const long BIT36 = 1L << 36;
			public const long BIT37 = 1L << 37;
			public const long BIT38 = 1L << 38;
			public const long BIT39 = 1L << 39;
			public const long BIT40 = 1L << 40;
			public const long BIT41 = 1L << 41;
			public const long BIT42 = 1L << 42;
			public const long BIT43 = 1L << 43;
			public const long BIT44 = 1L << 44;
			public const long BIT45 = 1L << 45;
			public const long BIT46 = 1L << 46;
			public const long BIT47 = 1L << 47;
			public const long BIT48 = 1L << 48;
			public const long BIT49 = 1L << 49;
			public const long BIT50 = 1L << 50;
			public const long BIT51 = 1L << 51;
			public const long BIT52 = 1L << 52;
			public const long BIT53 = 1L << 53;
			public const long BIT54 = 1L << 54;
			public const long BIT55 = 1L << 55;
			public const long BIT56 = 1L << 56;
			public const long BIT57 = 1L << 57;
			public const long BIT58 = 1L << 58;
			public const long BIT59 = 1L << 59;
			public const long BIT60 = 1L << 60;
			public const long BIT61 = 1L << 61;
			public const long BIT62 = 1L << 62;
			public const long BIT63 = 1L << 63;
	
			public const long BYTE0_NIBBLE0_HALF0 = BIT0 | BIT1;
        public const long BYTE0_NIBBLE0_HALF1 = BIT2 | BIT3;
        public const long BYTE0_NIBBLE0 = BYTE0_NIBBLE0_HALF0 | BYTE0_NIBBLE0_HALF1;

        public const long BYTE0_NIBBLE1_HALF0 = BIT4 | BIT5;
        public const long BYTE0_NIBBLE1_HALF1 = BIT6 | BIT7;
        public const long BYTE0_NIBBLE1 = BYTE0_NIBBLE1_HALF0 | BYTE0_NIBBLE1_HALF1;

        public const long BYTE0 = BYTE0_NIBBLE0 | BYTE0_NIBBLE1;
			public const long BYTE1_NIBBLE0_HALF0 = BIT8 | BIT9;
        public const long BYTE1_NIBBLE0_HALF1 = BIT10 | BIT11;
        public const long BYTE1_NIBBLE0 = BYTE1_NIBBLE0_HALF0 | BYTE1_NIBBLE0_HALF1;

        public const long BYTE1_NIBBLE1_HALF0 = BIT12 | BIT13;
        public const long BYTE1_NIBBLE1_HALF1 = BIT14 | BIT15;
        public const long BYTE1_NIBBLE1 = BYTE1_NIBBLE1_HALF0 | BYTE1_NIBBLE1_HALF1;

        public const long BYTE1 = BYTE1_NIBBLE0 | BYTE1_NIBBLE1;
			public const long BYTE2_NIBBLE0_HALF0 = BIT16 | BIT17;
        public const long BYTE2_NIBBLE0_HALF1 = BIT18 | BIT19;
        public const long BYTE2_NIBBLE0 = BYTE2_NIBBLE0_HALF0 | BYTE2_NIBBLE0_HALF1;

        public const long BYTE2_NIBBLE1_HALF0 = BIT20 | BIT21;
        public const long BYTE2_NIBBLE1_HALF1 = BIT22 | BIT23;
        public const long BYTE2_NIBBLE1 = BYTE2_NIBBLE1_HALF0 | BYTE2_NIBBLE1_HALF1;

        public const long BYTE2 = BYTE2_NIBBLE0 | BYTE2_NIBBLE1;
			public const long BYTE3_NIBBLE0_HALF0 = BIT24 | BIT25;
        public const long BYTE3_NIBBLE0_HALF1 = BIT26 | BIT27;
        public const long BYTE3_NIBBLE0 = BYTE3_NIBBLE0_HALF0 | BYTE3_NIBBLE0_HALF1;

        public const long BYTE3_NIBBLE1_HALF0 = BIT28 | BIT29;
        public const long BYTE3_NIBBLE1_HALF1 = BIT30 | BIT31;
        public const long BYTE3_NIBBLE1 = BYTE3_NIBBLE1_HALF0 | BYTE3_NIBBLE1_HALF1;

        public const long BYTE3 = BYTE3_NIBBLE0 | BYTE3_NIBBLE1;
			public const long BYTE4_NIBBLE0_HALF0 = BIT32 | BIT33;
        public const long BYTE4_NIBBLE0_HALF1 = BIT34 | BIT35;
        public const long BYTE4_NIBBLE0 = BYTE4_NIBBLE0_HALF0 | BYTE4_NIBBLE0_HALF1;

        public const long BYTE4_NIBBLE1_HALF0 = BIT36 | BIT37;
        public const long BYTE4_NIBBLE1_HALF1 = BIT38 | BIT39;
        public const long BYTE4_NIBBLE1 = BYTE4_NIBBLE1_HALF0 | BYTE4_NIBBLE1_HALF1;

        public const long BYTE4 = BYTE4_NIBBLE0 | BYTE4_NIBBLE1;
			public const long BYTE5_NIBBLE0_HALF0 = BIT40 | BIT41;
        public const long BYTE5_NIBBLE0_HALF1 = BIT42 | BIT43;
        public const long BYTE5_NIBBLE0 = BYTE5_NIBBLE0_HALF0 | BYTE5_NIBBLE0_HALF1;

        public const long BYTE5_NIBBLE1_HALF0 = BIT44 | BIT45;
        public const long BYTE5_NIBBLE1_HALF1 = BIT46 | BIT47;
        public const long BYTE5_NIBBLE1 = BYTE5_NIBBLE1_HALF0 | BYTE5_NIBBLE1_HALF1;

        public const long BYTE5 = BYTE5_NIBBLE0 | BYTE5_NIBBLE1;
			public const long BYTE6_NIBBLE0_HALF0 = BIT48 | BIT49;
        public const long BYTE6_NIBBLE0_HALF1 = BIT50 | BIT51;
        public const long BYTE6_NIBBLE0 = BYTE6_NIBBLE0_HALF0 | BYTE6_NIBBLE0_HALF1;

        public const long BYTE6_NIBBLE1_HALF0 = BIT52 | BIT53;
        public const long BYTE6_NIBBLE1_HALF1 = BIT54 | BIT55;
        public const long BYTE6_NIBBLE1 = BYTE6_NIBBLE1_HALF0 | BYTE6_NIBBLE1_HALF1;

        public const long BYTE6 = BYTE6_NIBBLE0 | BYTE6_NIBBLE1;
			public const long BYTE7_NIBBLE0_HALF0 = BIT56 | BIT57;
        public const long BYTE7_NIBBLE0_HALF1 = BIT58 | BIT59;
        public const long BYTE7_NIBBLE0 = BYTE7_NIBBLE0_HALF0 | BYTE7_NIBBLE0_HALF1;

        public const long BYTE7_NIBBLE1_HALF0 = BIT60 | BIT61;
        public const long BYTE7_NIBBLE1_HALF1 = BIT62 | BIT63;
        public const long BYTE7_NIBBLE1 = BYTE7_NIBBLE1_HALF0 | BYTE7_NIBBLE1_HALF1;

        public const long BYTE7 = BYTE7_NIBBLE0 | BYTE7_NIBBLE1;
	
			public const long BYTE0_BYTE1 = BYTE0 | BYTE1;
			public const long BYTE2_BYTE3 = BYTE2 | BYTE3;
			public const long BYTE4_BYTE5 = BYTE4 | BYTE5;
			public const long BYTE6_BYTE7 = BYTE6 | BYTE7;
	
			public const long BYTE0_BYTE1_BYTE2_BYTE3 = BYTE0 | BYTE1 | BYTE2 | BYTE3;
			public const long BYTE4_BYTE5_BYTE6_BYTE7 = BYTE4 | BYTE5 | BYTE6 | BYTE7;
	
		public const long NO_BITS = 0L;
		public const long ALL_BITS = BYTE0_BYTE1_BYTE2_BYTE3 | BYTE4_BYTE5_BYTE6_BYTE7;

		static public long Get(bool bit0, bool bit1, bool bit2, bool bit3, bool bit4, bool bit5, bool bit6, bool bit7, bool bit8, bool bit9, bool bit10, bool bit11, bool bit12, bool bit13, bool bit14, bool bit15, bool bit16, bool bit17, bool bit18, bool bit19, bool bit20, bool bit21, bool bit22, bool bit23, bool bit24, bool bit25, bool bit26, bool bit27, bool bit28, bool bit29, bool bit30, bool bit31, bool bit32, bool bit33, bool bit34, bool bit35, bool bit36, bool bit37, bool bit38, bool bit39, bool bit40, bool bit41, bool bit42, bool bit43, bool bit44, bool bit45, bool bit46, bool bit47, bool bit48, bool bit49, bool bit50, bool bit51, bool bit52, bool bit53, bool bit54, bool bit55, bool bit56, bool bit57, bool bit58, bool bit59, bool bit60, bool bit61, bool bit62, bool bit63)
		{
			long value = 0L;

				if(bit0)value |= BIT0;
				if(bit1)value |= BIT1;
				if(bit2)value |= BIT2;
				if(bit3)value |= BIT3;
				if(bit4)value |= BIT4;
				if(bit5)value |= BIT5;
				if(bit6)value |= BIT6;
				if(bit7)value |= BIT7;
				if(bit8)value |= BIT8;
				if(bit9)value |= BIT9;
				if(bit10)value |= BIT10;
				if(bit11)value |= BIT11;
				if(bit12)value |= BIT12;
				if(bit13)value |= BIT13;
				if(bit14)value |= BIT14;
				if(bit15)value |= BIT15;
				if(bit16)value |= BIT16;
				if(bit17)value |= BIT17;
				if(bit18)value |= BIT18;
				if(bit19)value |= BIT19;
				if(bit20)value |= BIT20;
				if(bit21)value |= BIT21;
				if(bit22)value |= BIT22;
				if(bit23)value |= BIT23;
				if(bit24)value |= BIT24;
				if(bit25)value |= BIT25;
				if(bit26)value |= BIT26;
				if(bit27)value |= BIT27;
				if(bit28)value |= BIT28;
				if(bit29)value |= BIT29;
				if(bit30)value |= BIT30;
				if(bit31)value |= BIT31;
				if(bit32)value |= BIT32;
				if(bit33)value |= BIT33;
				if(bit34)value |= BIT34;
				if(bit35)value |= BIT35;
				if(bit36)value |= BIT36;
				if(bit37)value |= BIT37;
				if(bit38)value |= BIT38;
				if(bit39)value |= BIT39;
				if(bit40)value |= BIT40;
				if(bit41)value |= BIT41;
				if(bit42)value |= BIT42;
				if(bit43)value |= BIT43;
				if(bit44)value |= BIT44;
				if(bit45)value |= BIT45;
				if(bit46)value |= BIT46;
				if(bit47)value |= BIT47;
				if(bit48)value |= BIT48;
				if(bit49)value |= BIT49;
				if(bit50)value |= BIT50;
				if(bit51)value |= BIT51;
				if(bit52)value |= BIT52;
				if(bit53)value |= BIT53;
				if(bit54)value |= BIT54;
				if(bit55)value |= BIT55;
				if(bit56)value |= BIT56;
				if(bit57)value |= BIT57;
				if(bit58)value |= BIT58;
				if(bit59)value |= BIT59;
				if(bit60)value |= BIT60;
				if(bit61)value |= BIT61;
				if(bit62)value |= BIT62;
				if(bit63)value |= BIT63;
	
			return value;
		}

        static public long GetNthBitValue(int n)
        {
            return (long)(1L << n);
        }
	}

	static public class LongBitsExtensions
	{
		static public long GetBitUnion(this long item, long other)
		{
			return (long)(item | other);
		}

		static public long GetBitIntersection(this long item, long other)
		{
			return (long)(item & other);
		}

		static public long GetBitExclusion(this long item, long other)
		{
			return (long)(item & (~other));
		}

		static public bool HasAnyBits(this long item, long bits)
        {
            if ((item & bits) != 0)
                return true;

            return false;
        }

        static public bool HasAllBits(this long item, long bits)
        {
            if ((item & bits) == bits)
                return true;

            return false;
        }

        static public bool HasNoBits(this long item, long bits)
        {
            if ((item & bits) == 0)
                return true;

            return false;
        }

		static public bool HasNoOtherBits(this long item, long bits)
		{
			if ((item & (~bits)) == 0)
				return true;

			return false;
		}

		static public bool HasNthBit(this long item, int n)
		{
			if(item.HasAllBits(LongBits.GetNthBitValue(n)))
				return true;

			return false;
		}

	
		static public byte GetLowestBitIndex(this long item)
		{
			unchecked
			{
				if(item.HasAnyBits((long)0x00000000FFFFFFFF))
{
if(item.HasAnyBits((long)0x000000000000FFFF))
{
if(item.HasAnyBits((long)0x00000000000000FF))
{
if(item.HasAnyBits((long)0x000000000000000F))
{
if(item.HasAnyBits((long)0x0000000000000003))
{
if(item.HasAnyBits((long)0x0000000000000001))
{
return 0;}
else
{
return 1;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000004))
{
return 2;}
else
{
return 3;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000000030))
{
if(item.HasAnyBits((long)0x0000000000000010))
{
return 4;}
else
{
return 5;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000040))
{
return 6;}
else
{
return 7;}
}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000000F00))
{
if(item.HasAnyBits((long)0x0000000000000300))
{
if(item.HasAnyBits((long)0x0000000000000100))
{
return 8;}
else
{
return 9;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000400))
{
return 10;}
else
{
return 11;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000003000))
{
if(item.HasAnyBits((long)0x0000000000001000))
{
return 12;}
else
{
return 13;}
}
else
{
if(item.HasAnyBits((long)0x0000000000004000))
{
return 14;}
else
{
return 15;}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000FF0000))
{
if(item.HasAnyBits((long)0x00000000000F0000))
{
if(item.HasAnyBits((long)0x0000000000030000))
{
if(item.HasAnyBits((long)0x0000000000010000))
{
return 16;}
else
{
return 17;}
}
else
{
if(item.HasAnyBits((long)0x0000000000040000))
{
return 18;}
else
{
return 19;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000300000))
{
if(item.HasAnyBits((long)0x0000000000100000))
{
return 20;}
else
{
return 21;}
}
else
{
if(item.HasAnyBits((long)0x0000000000400000))
{
return 22;}
else
{
return 23;}
}
}
}
else
{
if(item.HasAnyBits((long)0x000000000F000000))
{
if(item.HasAnyBits((long)0x0000000003000000))
{
if(item.HasAnyBits((long)0x0000000001000000))
{
return 24;}
else
{
return 25;}
}
else
{
if(item.HasAnyBits((long)0x0000000004000000))
{
return 26;}
else
{
return 27;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000030000000))
{
if(item.HasAnyBits((long)0x0000000010000000))
{
return 28;}
else
{
return 29;}
}
else
{
if(item.HasAnyBits((long)0x0000000040000000))
{
return 30;}
else
{
return 31;}
}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x0000FFFF00000000))
{
if(item.HasAnyBits((long)0x000000FF00000000))
{
if(item.HasAnyBits((long)0x0000000F00000000))
{
if(item.HasAnyBits((long)0x0000000300000000))
{
if(item.HasAnyBits((long)0x0000000100000000))
{
return 32;}
else
{
return 33;}
}
else
{
if(item.HasAnyBits((long)0x0000000400000000))
{
return 34;}
else
{
return 35;}
}
}
else
{
if(item.HasAnyBits((long)0x0000003000000000))
{
if(item.HasAnyBits((long)0x0000001000000000))
{
return 36;}
else
{
return 37;}
}
else
{
if(item.HasAnyBits((long)0x0000004000000000))
{
return 38;}
else
{
return 39;}
}
}
}
else
{
if(item.HasAnyBits((long)0x00000F0000000000))
{
if(item.HasAnyBits((long)0x0000030000000000))
{
if(item.HasAnyBits((long)0x0000010000000000))
{
return 40;}
else
{
return 41;}
}
else
{
if(item.HasAnyBits((long)0x0000040000000000))
{
return 42;}
else
{
return 43;}
}
}
else
{
if(item.HasAnyBits((long)0x0000300000000000))
{
if(item.HasAnyBits((long)0x0000100000000000))
{
return 44;}
else
{
return 45;}
}
else
{
if(item.HasAnyBits((long)0x0000400000000000))
{
return 46;}
else
{
return 47;}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x00FF000000000000))
{
if(item.HasAnyBits((long)0x000F000000000000))
{
if(item.HasAnyBits((long)0x0003000000000000))
{
if(item.HasAnyBits((long)0x0001000000000000))
{
return 48;}
else
{
return 49;}
}
else
{
if(item.HasAnyBits((long)0x0004000000000000))
{
return 50;}
else
{
return 51;}
}
}
else
{
if(item.HasAnyBits((long)0x0030000000000000))
{
if(item.HasAnyBits((long)0x0010000000000000))
{
return 52;}
else
{
return 53;}
}
else
{
if(item.HasAnyBits((long)0x0040000000000000))
{
return 54;}
else
{
return 55;}
}
}
}
else
{
if(item.HasAnyBits((long)0x0F00000000000000))
{
if(item.HasAnyBits((long)0x0300000000000000))
{
if(item.HasAnyBits((long)0x0100000000000000))
{
return 56;}
else
{
return 57;}
}
else
{
if(item.HasAnyBits((long)0x0400000000000000))
{
return 58;}
else
{
return 59;}
}
}
else
{
if(item.HasAnyBits((long)0x3000000000000000))
{
if(item.HasAnyBits((long)0x1000000000000000))
{
return 60;}
else
{
return 61;}
}
else
{
if(item.HasAnyBits((long)0x4000000000000000))
{
return 62;}
else
{
return 63;}
}
}
}
}
}

			}
		}

		static public byte GetHighestBitIndex(this long item)
		{
			unchecked
			{
				if(item.HasAnyBits((long)0xFFFFFFFF00000000))
{
if(item.HasAnyBits((long)0xFFFF000000000000))
{
if(item.HasAnyBits((long)0xFF00000000000000))
{
if(item.HasAnyBits((long)0xF000000000000000))
{
if(item.HasAnyBits((long)0xC000000000000000))
{
if(item.HasAnyBits((long)0x8000000000000000))
{
return 63;}
else
{
return 62;}
}
else
{
if(item.HasAnyBits((long)0x2000000000000000))
{
return 61;}
else
{
return 60;}
}
}
else
{
if(item.HasAnyBits((long)0x0C00000000000000))
{
if(item.HasAnyBits((long)0x0800000000000000))
{
return 59;}
else
{
return 58;}
}
else
{
if(item.HasAnyBits((long)0x0200000000000000))
{
return 57;}
else
{
return 56;}
}
}
}
else
{
if(item.HasAnyBits((long)0x00F0000000000000))
{
if(item.HasAnyBits((long)0x00C0000000000000))
{
if(item.HasAnyBits((long)0x0080000000000000))
{
return 55;}
else
{
return 54;}
}
else
{
if(item.HasAnyBits((long)0x0020000000000000))
{
return 53;}
else
{
return 52;}
}
}
else
{
if(item.HasAnyBits((long)0x000C000000000000))
{
if(item.HasAnyBits((long)0x0008000000000000))
{
return 51;}
else
{
return 50;}
}
else
{
if(item.HasAnyBits((long)0x0002000000000000))
{
return 49;}
else
{
return 48;}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x0000FF0000000000))
{
if(item.HasAnyBits((long)0x0000F00000000000))
{
if(item.HasAnyBits((long)0x0000C00000000000))
{
if(item.HasAnyBits((long)0x0000800000000000))
{
return 47;}
else
{
return 46;}
}
else
{
if(item.HasAnyBits((long)0x0000200000000000))
{
return 45;}
else
{
return 44;}
}
}
else
{
if(item.HasAnyBits((long)0x00000C0000000000))
{
if(item.HasAnyBits((long)0x0000080000000000))
{
return 43;}
else
{
return 42;}
}
else
{
if(item.HasAnyBits((long)0x0000020000000000))
{
return 41;}
else
{
return 40;}
}
}
}
else
{
if(item.HasAnyBits((long)0x000000F000000000))
{
if(item.HasAnyBits((long)0x000000C000000000))
{
if(item.HasAnyBits((long)0x0000008000000000))
{
return 39;}
else
{
return 38;}
}
else
{
if(item.HasAnyBits((long)0x0000002000000000))
{
return 37;}
else
{
return 36;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000C00000000))
{
if(item.HasAnyBits((long)0x0000000800000000))
{
return 35;}
else
{
return 34;}
}
else
{
if(item.HasAnyBits((long)0x0000000200000000))
{
return 33;}
else
{
return 32;}
}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x00000000FFFF0000))
{
if(item.HasAnyBits((long)0x00000000FF000000))
{
if(item.HasAnyBits((long)0x00000000F0000000))
{
if(item.HasAnyBits((long)0x00000000C0000000))
{
if(item.HasAnyBits((long)0x0000000080000000))
{
return 31;}
else
{
return 30;}
}
else
{
if(item.HasAnyBits((long)0x0000000020000000))
{
return 29;}
else
{
return 28;}
}
}
else
{
if(item.HasAnyBits((long)0x000000000C000000))
{
if(item.HasAnyBits((long)0x0000000008000000))
{
return 27;}
else
{
return 26;}
}
else
{
if(item.HasAnyBits((long)0x0000000002000000))
{
return 25;}
else
{
return 24;}
}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000F00000))
{
if(item.HasAnyBits((long)0x0000000000C00000))
{
if(item.HasAnyBits((long)0x0000000000800000))
{
return 23;}
else
{
return 22;}
}
else
{
if(item.HasAnyBits((long)0x0000000000200000))
{
return 21;}
else
{
return 20;}
}
}
else
{
if(item.HasAnyBits((long)0x00000000000C0000))
{
if(item.HasAnyBits((long)0x0000000000080000))
{
return 19;}
else
{
return 18;}
}
else
{
if(item.HasAnyBits((long)0x0000000000020000))
{
return 17;}
else
{
return 16;}
}
}
}
}
else
{
if(item.HasAnyBits((long)0x000000000000FF00))
{
if(item.HasAnyBits((long)0x000000000000F000))
{
if(item.HasAnyBits((long)0x000000000000C000))
{
if(item.HasAnyBits((long)0x0000000000008000))
{
return 15;}
else
{
return 14;}
}
else
{
if(item.HasAnyBits((long)0x0000000000002000))
{
return 13;}
else
{
return 12;}
}
}
else
{
if(item.HasAnyBits((long)0x0000000000000C00))
{
if(item.HasAnyBits((long)0x0000000000000800))
{
return 11;}
else
{
return 10;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000200))
{
return 9;}
else
{
return 8;}
}
}
}
else
{
if(item.HasAnyBits((long)0x00000000000000F0))
{
if(item.HasAnyBits((long)0x00000000000000C0))
{
if(item.HasAnyBits((long)0x0000000000000080))
{
return 7;}
else
{
return 6;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000020))
{
return 5;}
else
{
return 4;}
}
}
else
{
if(item.HasAnyBits((long)0x000000000000000C))
{
if(item.HasAnyBits((long)0x0000000000000008))
{
return 3;}
else
{
return 2;}
}
else
{
if(item.HasAnyBits((long)0x0000000000000002))
{
return 1;}
else
{
return 0;}
}
}
}
}
}

			}
		}

		static public byte GetNumberBits(this long item)
		{
			unchecked
			{
				byte count = 0;
if(item.HasAnyBits((long)0x00000000FFFFFFFF))
{
if(item.HasAnyBits((long)0x000000000000FFFF))
{
if(item.HasAnyBits((long)0x00000000000000FF))
{
if(item.HasAnyBits((long)0x000000000000000F))
{
if(item.HasAnyBits((long)0x0000000000000003))
{
if(item.HasAnyBits((long)0x0000000000000001))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000002))
{
count++;}
}
if(item.HasAnyBits((long)0x000000000000000C))
{
if(item.HasAnyBits((long)0x0000000000000004))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000008))
{
count++;}
}
}
if(item.HasAnyBits((long)0x00000000000000F0))
{
if(item.HasAnyBits((long)0x0000000000000030))
{
if(item.HasAnyBits((long)0x0000000000000010))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000020))
{
count++;}
}
if(item.HasAnyBits((long)0x00000000000000C0))
{
if(item.HasAnyBits((long)0x0000000000000040))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000080))
{
count++;}
}
}
}
if(item.HasAnyBits((long)0x000000000000FF00))
{
if(item.HasAnyBits((long)0x0000000000000F00))
{
if(item.HasAnyBits((long)0x0000000000000300))
{
if(item.HasAnyBits((long)0x0000000000000100))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000200))
{
count++;}
}
if(item.HasAnyBits((long)0x0000000000000C00))
{
if(item.HasAnyBits((long)0x0000000000000400))
{
count++;}
if(item.HasAnyBits((long)0x0000000000000800))
{
count++;}
}
}
if(item.HasAnyBits((long)0x000000000000F000))
{
if(item.HasAnyBits((long)0x0000000000003000))
{
if(item.HasAnyBits((long)0x0000000000001000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000002000))
{
count++;}
}
if(item.HasAnyBits((long)0x000000000000C000))
{
if(item.HasAnyBits((long)0x0000000000004000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000008000))
{
count++;}
}
}
}
}
if(item.HasAnyBits((long)0x00000000FFFF0000))
{
if(item.HasAnyBits((long)0x0000000000FF0000))
{
if(item.HasAnyBits((long)0x00000000000F0000))
{
if(item.HasAnyBits((long)0x0000000000030000))
{
if(item.HasAnyBits((long)0x0000000000010000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000020000))
{
count++;}
}
if(item.HasAnyBits((long)0x00000000000C0000))
{
if(item.HasAnyBits((long)0x0000000000040000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000080000))
{
count++;}
}
}
if(item.HasAnyBits((long)0x0000000000F00000))
{
if(item.HasAnyBits((long)0x0000000000300000))
{
if(item.HasAnyBits((long)0x0000000000100000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000200000))
{
count++;}
}
if(item.HasAnyBits((long)0x0000000000C00000))
{
if(item.HasAnyBits((long)0x0000000000400000))
{
count++;}
if(item.HasAnyBits((long)0x0000000000800000))
{
count++;}
}
}
}
if(item.HasAnyBits((long)0x00000000FF000000))
{
if(item.HasAnyBits((long)0x000000000F000000))
{
if(item.HasAnyBits((long)0x0000000003000000))
{
if(item.HasAnyBits((long)0x0000000001000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000002000000))
{
count++;}
}
if(item.HasAnyBits((long)0x000000000C000000))
{
if(item.HasAnyBits((long)0x0000000004000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000008000000))
{
count++;}
}
}
if(item.HasAnyBits((long)0x00000000F0000000))
{
if(item.HasAnyBits((long)0x0000000030000000))
{
if(item.HasAnyBits((long)0x0000000010000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000020000000))
{
count++;}
}
if(item.HasAnyBits((long)0x00000000C0000000))
{
if(item.HasAnyBits((long)0x0000000040000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000080000000))
{
count++;}
}
}
}
}
}
if(item.HasAnyBits((long)0xFFFFFFFF00000000))
{
if(item.HasAnyBits((long)0x0000FFFF00000000))
{
if(item.HasAnyBits((long)0x000000FF00000000))
{
if(item.HasAnyBits((long)0x0000000F00000000))
{
if(item.HasAnyBits((long)0x0000000300000000))
{
if(item.HasAnyBits((long)0x0000000100000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000200000000))
{
count++;}
}
if(item.HasAnyBits((long)0x0000000C00000000))
{
if(item.HasAnyBits((long)0x0000000400000000))
{
count++;}
if(item.HasAnyBits((long)0x0000000800000000))
{
count++;}
}
}
if(item.HasAnyBits((long)0x000000F000000000))
{
if(item.HasAnyBits((long)0x0000003000000000))
{
if(item.HasAnyBits((long)0x0000001000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000002000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x000000C000000000))
{
if(item.HasAnyBits((long)0x0000004000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000008000000000))
{
count++;}
}
}
}
if(item.HasAnyBits((long)0x0000FF0000000000))
{
if(item.HasAnyBits((long)0x00000F0000000000))
{
if(item.HasAnyBits((long)0x0000030000000000))
{
if(item.HasAnyBits((long)0x0000010000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000020000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x00000C0000000000))
{
if(item.HasAnyBits((long)0x0000040000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000080000000000))
{
count++;}
}
}
if(item.HasAnyBits((long)0x0000F00000000000))
{
if(item.HasAnyBits((long)0x0000300000000000))
{
if(item.HasAnyBits((long)0x0000100000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000200000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x0000C00000000000))
{
if(item.HasAnyBits((long)0x0000400000000000))
{
count++;}
if(item.HasAnyBits((long)0x0000800000000000))
{
count++;}
}
}
}
}
if(item.HasAnyBits((long)0xFFFF000000000000))
{
if(item.HasAnyBits((long)0x00FF000000000000))
{
if(item.HasAnyBits((long)0x000F000000000000))
{
if(item.HasAnyBits((long)0x0003000000000000))
{
if(item.HasAnyBits((long)0x0001000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0002000000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x000C000000000000))
{
if(item.HasAnyBits((long)0x0004000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0008000000000000))
{
count++;}
}
}
if(item.HasAnyBits((long)0x00F0000000000000))
{
if(item.HasAnyBits((long)0x0030000000000000))
{
if(item.HasAnyBits((long)0x0010000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0020000000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x00C0000000000000))
{
if(item.HasAnyBits((long)0x0040000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0080000000000000))
{
count++;}
}
}
}
if(item.HasAnyBits((long)0xFF00000000000000))
{
if(item.HasAnyBits((long)0x0F00000000000000))
{
if(item.HasAnyBits((long)0x0300000000000000))
{
if(item.HasAnyBits((long)0x0100000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0200000000000000))
{
count++;}
}
if(item.HasAnyBits((long)0x0C00000000000000))
{
if(item.HasAnyBits((long)0x0400000000000000))
{
count++;}
if(item.HasAnyBits((long)0x0800000000000000))
{
count++;}
}
}
if(item.HasAnyBits((long)0xF000000000000000))
{
if(item.HasAnyBits((long)0x3000000000000000))
{
if(item.HasAnyBits((long)0x1000000000000000))
{
count++;}
if(item.HasAnyBits((long)0x2000000000000000))
{
count++;}
}
if(item.HasAnyBits((long)0xC000000000000000))
{
if(item.HasAnyBits((long)0x4000000000000000))
{
count++;}
if(item.HasAnyBits((long)0x8000000000000000))
{
count++;}
}
}
}
}
}

return count;
			}
		}
	
		static public IEnumerable<byte> GetBitIndexs(this long item)
		{
			unchecked
			{
				if(item.HasAnyBits((long)0x00000000FFFFFFFF))
{
if(item.HasAnyBits((long)0x000000000000FFFF))
{
if(item.HasAnyBits((long)0x00000000000000FF))
{
if(item.HasAnyBits((long)0x000000000000000F))
{
if(item.HasAnyBits((long)0x0000000000000003))
{
if(item.HasAnyBits((long)0x0000000000000001))
{
yield return 0;}
if(item.HasAnyBits((long)0x0000000000000002))
{
yield return 1;}
}
if(item.HasAnyBits((long)0x000000000000000C))
{
if(item.HasAnyBits((long)0x0000000000000004))
{
yield return 2;}
if(item.HasAnyBits((long)0x0000000000000008))
{
yield return 3;}
}
}
if(item.HasAnyBits((long)0x00000000000000F0))
{
if(item.HasAnyBits((long)0x0000000000000030))
{
if(item.HasAnyBits((long)0x0000000000000010))
{
yield return 4;}
if(item.HasAnyBits((long)0x0000000000000020))
{
yield return 5;}
}
if(item.HasAnyBits((long)0x00000000000000C0))
{
if(item.HasAnyBits((long)0x0000000000000040))
{
yield return 6;}
if(item.HasAnyBits((long)0x0000000000000080))
{
yield return 7;}
}
}
}
if(item.HasAnyBits((long)0x000000000000FF00))
{
if(item.HasAnyBits((long)0x0000000000000F00))
{
if(item.HasAnyBits((long)0x0000000000000300))
{
if(item.HasAnyBits((long)0x0000000000000100))
{
yield return 8;}
if(item.HasAnyBits((long)0x0000000000000200))
{
yield return 9;}
}
if(item.HasAnyBits((long)0x0000000000000C00))
{
if(item.HasAnyBits((long)0x0000000000000400))
{
yield return 10;}
if(item.HasAnyBits((long)0x0000000000000800))
{
yield return 11;}
}
}
if(item.HasAnyBits((long)0x000000000000F000))
{
if(item.HasAnyBits((long)0x0000000000003000))
{
if(item.HasAnyBits((long)0x0000000000001000))
{
yield return 12;}
if(item.HasAnyBits((long)0x0000000000002000))
{
yield return 13;}
}
if(item.HasAnyBits((long)0x000000000000C000))
{
if(item.HasAnyBits((long)0x0000000000004000))
{
yield return 14;}
if(item.HasAnyBits((long)0x0000000000008000))
{
yield return 15;}
}
}
}
}
if(item.HasAnyBits((long)0x00000000FFFF0000))
{
if(item.HasAnyBits((long)0x0000000000FF0000))
{
if(item.HasAnyBits((long)0x00000000000F0000))
{
if(item.HasAnyBits((long)0x0000000000030000))
{
if(item.HasAnyBits((long)0x0000000000010000))
{
yield return 16;}
if(item.HasAnyBits((long)0x0000000000020000))
{
yield return 17;}
}
if(item.HasAnyBits((long)0x00000000000C0000))
{
if(item.HasAnyBits((long)0x0000000000040000))
{
yield return 18;}
if(item.HasAnyBits((long)0x0000000000080000))
{
yield return 19;}
}
}
if(item.HasAnyBits((long)0x0000000000F00000))
{
if(item.HasAnyBits((long)0x0000000000300000))
{
if(item.HasAnyBits((long)0x0000000000100000))
{
yield return 20;}
if(item.HasAnyBits((long)0x0000000000200000))
{
yield return 21;}
}
if(item.HasAnyBits((long)0x0000000000C00000))
{
if(item.HasAnyBits((long)0x0000000000400000))
{
yield return 22;}
if(item.HasAnyBits((long)0x0000000000800000))
{
yield return 23;}
}
}
}
if(item.HasAnyBits((long)0x00000000FF000000))
{
if(item.HasAnyBits((long)0x000000000F000000))
{
if(item.HasAnyBits((long)0x0000000003000000))
{
if(item.HasAnyBits((long)0x0000000001000000))
{
yield return 24;}
if(item.HasAnyBits((long)0x0000000002000000))
{
yield return 25;}
}
if(item.HasAnyBits((long)0x000000000C000000))
{
if(item.HasAnyBits((long)0x0000000004000000))
{
yield return 26;}
if(item.HasAnyBits((long)0x0000000008000000))
{
yield return 27;}
}
}
if(item.HasAnyBits((long)0x00000000F0000000))
{
if(item.HasAnyBits((long)0x0000000030000000))
{
if(item.HasAnyBits((long)0x0000000010000000))
{
yield return 28;}
if(item.HasAnyBits((long)0x0000000020000000))
{
yield return 29;}
}
if(item.HasAnyBits((long)0x00000000C0000000))
{
if(item.HasAnyBits((long)0x0000000040000000))
{
yield return 30;}
if(item.HasAnyBits((long)0x0000000080000000))
{
yield return 31;}
}
}
}
}
}
if(item.HasAnyBits((long)0xFFFFFFFF00000000))
{
if(item.HasAnyBits((long)0x0000FFFF00000000))
{
if(item.HasAnyBits((long)0x000000FF00000000))
{
if(item.HasAnyBits((long)0x0000000F00000000))
{
if(item.HasAnyBits((long)0x0000000300000000))
{
if(item.HasAnyBits((long)0x0000000100000000))
{
yield return 32;}
if(item.HasAnyBits((long)0x0000000200000000))
{
yield return 33;}
}
if(item.HasAnyBits((long)0x0000000C00000000))
{
if(item.HasAnyBits((long)0x0000000400000000))
{
yield return 34;}
if(item.HasAnyBits((long)0x0000000800000000))
{
yield return 35;}
}
}
if(item.HasAnyBits((long)0x000000F000000000))
{
if(item.HasAnyBits((long)0x0000003000000000))
{
if(item.HasAnyBits((long)0x0000001000000000))
{
yield return 36;}
if(item.HasAnyBits((long)0x0000002000000000))
{
yield return 37;}
}
if(item.HasAnyBits((long)0x000000C000000000))
{
if(item.HasAnyBits((long)0x0000004000000000))
{
yield return 38;}
if(item.HasAnyBits((long)0x0000008000000000))
{
yield return 39;}
}
}
}
if(item.HasAnyBits((long)0x0000FF0000000000))
{
if(item.HasAnyBits((long)0x00000F0000000000))
{
if(item.HasAnyBits((long)0x0000030000000000))
{
if(item.HasAnyBits((long)0x0000010000000000))
{
yield return 40;}
if(item.HasAnyBits((long)0x0000020000000000))
{
yield return 41;}
}
if(item.HasAnyBits((long)0x00000C0000000000))
{
if(item.HasAnyBits((long)0x0000040000000000))
{
yield return 42;}
if(item.HasAnyBits((long)0x0000080000000000))
{
yield return 43;}
}
}
if(item.HasAnyBits((long)0x0000F00000000000))
{
if(item.HasAnyBits((long)0x0000300000000000))
{
if(item.HasAnyBits((long)0x0000100000000000))
{
yield return 44;}
if(item.HasAnyBits((long)0x0000200000000000))
{
yield return 45;}
}
if(item.HasAnyBits((long)0x0000C00000000000))
{
if(item.HasAnyBits((long)0x0000400000000000))
{
yield return 46;}
if(item.HasAnyBits((long)0x0000800000000000))
{
yield return 47;}
}
}
}
}
if(item.HasAnyBits((long)0xFFFF000000000000))
{
if(item.HasAnyBits((long)0x00FF000000000000))
{
if(item.HasAnyBits((long)0x000F000000000000))
{
if(item.HasAnyBits((long)0x0003000000000000))
{
if(item.HasAnyBits((long)0x0001000000000000))
{
yield return 48;}
if(item.HasAnyBits((long)0x0002000000000000))
{
yield return 49;}
}
if(item.HasAnyBits((long)0x000C000000000000))
{
if(item.HasAnyBits((long)0x0004000000000000))
{
yield return 50;}
if(item.HasAnyBits((long)0x0008000000000000))
{
yield return 51;}
}
}
if(item.HasAnyBits((long)0x00F0000000000000))
{
if(item.HasAnyBits((long)0x0030000000000000))
{
if(item.HasAnyBits((long)0x0010000000000000))
{
yield return 52;}
if(item.HasAnyBits((long)0x0020000000000000))
{
yield return 53;}
}
if(item.HasAnyBits((long)0x00C0000000000000))
{
if(item.HasAnyBits((long)0x0040000000000000))
{
yield return 54;}
if(item.HasAnyBits((long)0x0080000000000000))
{
yield return 55;}
}
}
}
if(item.HasAnyBits((long)0xFF00000000000000))
{
if(item.HasAnyBits((long)0x0F00000000000000))
{
if(item.HasAnyBits((long)0x0300000000000000))
{
if(item.HasAnyBits((long)0x0100000000000000))
{
yield return 56;}
if(item.HasAnyBits((long)0x0200000000000000))
{
yield return 57;}
}
if(item.HasAnyBits((long)0x0C00000000000000))
{
if(item.HasAnyBits((long)0x0400000000000000))
{
yield return 58;}
if(item.HasAnyBits((long)0x0800000000000000))
{
yield return 59;}
}
}
if(item.HasAnyBits((long)0xF000000000000000))
{
if(item.HasAnyBits((long)0x3000000000000000))
{
if(item.HasAnyBits((long)0x1000000000000000))
{
yield return 60;}
if(item.HasAnyBits((long)0x2000000000000000))
{
yield return 61;}
}
if(item.HasAnyBits((long)0xC000000000000000))
{
if(item.HasAnyBits((long)0x4000000000000000))
{
yield return 62;}
if(item.HasAnyBits((long)0x8000000000000000))
{
yield return 63;}
}
}
}
}
}

			}
		}
	
		static public long GetLowestBitValue(this long item)
        {
            return LongBits.GetNthBitValue(item.GetLowestBitIndex());
        }

		static public long GetHighestBitValue(this long item)
        {
            return LongBits.GetNthBitValue(item.GetHighestBitIndex());
        }

			static public byte GetNthByte(this long item, int n)
		{
			return (byte)(item >> (n * 8));
		}
	
			static public long BitwiseOR(this IEnumerable<long> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (long)(v1 | v2));
		}
			static public long BitwiseAND(this IEnumerable<long> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (long)(v1 & v2));
		}
			static public long BitwiseXOR(this IEnumerable<long> item)
		{
			return item.PerformIteratedBinaryOperation((v1, v2) => (long)(v1 ^ v2));
		}
		}
}

