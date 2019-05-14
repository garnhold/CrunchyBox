using System;
using System.IO;

namespace CrunchyDough
{
    static public class BinaryReaderWriterExtensions_ByteExpansion
    {
        public const int FLAG = ByteBits.BIT7;
        public const int MASK = ByteBits.BYTE0 ^ FLAG;
        public const int MASK2 = MASK << 7;
        public const int MASK3 = MASK << 14;
        public const int MASK4 = MASK << 21;

        static public void WriteByteExpansion(this BinaryWriter item, int value)
        {
            if (value < IntBits.BIT7)
            {
                byte one = (byte)value;
                item.Write(one);
            }
            else if (value < IntBits.BIT14)
            {
                byte one = (byte)((value & MASK) | FLAG);
                item.Write(one);

                byte two = (byte)((value & MASK2) >> 7);
                item.Write(two);
            }
            else if (value < IntBits.BIT21)
            {
                byte one = (byte)((value & MASK) | FLAG);
                item.Write(one);

                byte two = (byte)(((value & MASK2) >> 7) | FLAG);
                item.Write(two);

                byte three = (byte)((value & MASK3) >> 14);
                item.Write(three);
            }
            else
            {
                byte one = (byte)((value & MASK) | FLAG);
                item.Write(one);

                byte two = (byte)(((value & MASK2) >> 7) | FLAG);
                item.Write(two);

                byte three = (byte)(((value & MASK3) >> 14) | FLAG);
                item.Write(three);

                byte four = (byte)((value & MASK4) >> 21);
                item.Write(four);
            }
        }

        static public int ReadByteExpansion(this BinaryReader item)
        {
            int one = item.ReadByte();

            if ((one & FLAG) != 0)
            {
                one &= MASK;
                int two = item.ReadByte();

                if ((two & FLAG) != 0)
                {
                    two &= MASK;
                    int three = item.ReadByte();

                    if ((three & FLAG) != 0)
                    {
                        three &= MASK;
                        int four = item.ReadByte();

                        return one | (two << 7) | (three << 14) | (four << 21);
                    }

                    return one | (two << 7) | (three << 14);
                }

                return one | (two << 7);
            }

            return one;
        }
    }
}