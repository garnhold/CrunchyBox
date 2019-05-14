using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace CrunchyDough
{
    static public class HashTypeExtensions_String
    {
        static public ByteSequence CalculateAsUnicode(this HashType item, string input)
        {
            return item.Calculate(input.ToUnicodeBytes());
        }
    }
}