using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace CrunchyDough
{
    static public class ByteSequenceExtensions_String
    {
        static public string ToHexString(this ByteSequence item)
        {
            return item.GetBytes().ToHexString();
        }

        static public string ToBase64String(this ByteSequence item)
        {
            return item.GetBytes().ToBase64String();
        }

        static public string ToBinaryRepresentationString(this ByteSequence item, BinaryRepresentationType type)
        {
            return item.GetBytes().ToBinaryRepresentationString(type);
        }
    }
}