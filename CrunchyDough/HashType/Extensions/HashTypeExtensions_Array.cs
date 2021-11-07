using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Crunchy.Dough
{
    static public class HashTypeExtensions_Array
    {
        static public ByteSequence Calculate(this HashType item, byte[] bytes, string salt)
        {
            return item.Calculate(bytes.Append(salt.ToUnicodeBytes()));
        }
    }
}