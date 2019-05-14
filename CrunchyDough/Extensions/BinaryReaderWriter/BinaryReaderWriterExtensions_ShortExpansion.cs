using System;
using System.IO;

namespace CrunchyDough
{
    static public class BinaryReaderWriterExtensions_ShortExpansion
    {
        public const int FLAG = IntBits.BIT15;
        public const int MASK = IntBits.BYTE0_BYTE1 ^ FLAG;
        public const int MASK2 = MASK << 15;

        static public void WriteShortExpansion(this BinaryWriter item, int value)
        {
            if (value < IntBits.BIT15)
            {
                short one = (short)value;
                item.Write(one);
            }
            else
            {
                short one = (short)((value & MASK) | FLAG);
                item.Write(one);

                short two = (short)((value & MASK2) >> 15);
                item.Write(two);
            }
        }

        static public int ReadShortExpansion(this BinaryReader item)
        {
            int one = item.ReadInt16();

            if ((one & FLAG) != 0)
            {
                one &= MASK;
                int two = item.ReadInt16();

                return one | (two << 15);
            }

            return one;
        }
    }
}