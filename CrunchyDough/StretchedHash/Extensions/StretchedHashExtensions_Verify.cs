using System;
using System.IO;
using System.Security.Cryptography;

namespace CrunchyDough
{
    static public class StretchedHashExtensions_Verify
    {
        static public bool Verify(this StretchedHash item, byte[] b)
        {
            if (item.Equals(new StretchedHash(b, item)))
                return true;

            return false;
        }

        static public bool Verify(this StretchedHash item, string b)
        {
            if (item.Equals(new StretchedHash(b, item)))
                return true;

            return false;
        }
    }
}