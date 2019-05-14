using System;

namespace CrunchyDough
{
    static public class ByteExtensions_String
    {
        static public string ToHex(this byte item)
        {
            return BYTE_TO_HEX[item];
        }

        static private string[] BYTE_TO_HEX = GetHex();
        static private string[] GetHex()
        {
            int number_values = byte.MaxValue + 1;
            string[] strings = new string[number_values];

            for (int i = 0; i < number_values; i++)
                strings[i] = ((byte)i).ToString("x2");

            return strings;
        }
    }
}