using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class BoolExtensions_IEnumerable_Bits
    {
        static public bool TryPackBitsToLong(this IEnumerable<bool> item, out long value)
        {
            value = 0;

            byte index = 0;
            foreach (bool bit in item)
            {
                if (bit)
                    value |= (1L << index);

                index++;
                if (index >= LongBits.NUMBER_BITS)
                    return false;
            }

            return true;
        }
        static public long PackBitsToLong(this IEnumerable<bool> item)
        {
            long value;

            item.TryPackBitsToLong(out value);
            return value;
        }

        static public bool TryPackBitsToInt(this IEnumerable<bool> item, out int value)
        {
            long long_value;
            bool long_result = item.TryPackBitsToLong(out long_value);

            value = (int)long_value;

            if (long_result && long_value.CanFitInInt())
                return true;

            return false;
        }
        static public int PackBitsToInt(this IEnumerable<bool> item)
        {
            int value;

            item.TryPackBitsToInt(out value);
            return value;
        }

        static public bool TryPackBitsToShort(this IEnumerable<bool> item, out short value)
        {
            long long_value;
            bool long_result = item.TryPackBitsToLong(out long_value);

            value = (short)long_value;

            if (long_result && long_value.CanFitInShort())
                return true;

            return false;
        }
        static public short PackBitsToShort(this IEnumerable<bool> item)
        {
            short value;

            item.TryPackBitsToShort(out value);
            return value;
        }

        static public bool TryPackBitsToByte(this IEnumerable<bool> item, out byte value)
        {
            long long_value;
            bool long_result = item.TryPackBitsToLong(out long_value);

            value = (byte)long_value;

            if (long_result && long_value.CanFitInByte())
                return true;

            return false;
        }
        static public byte PackBitsToByte(this IEnumerable<bool> item)
        {
            byte value;

            item.TryPackBitsToByte(out value);
            return value;
        }
    }
}