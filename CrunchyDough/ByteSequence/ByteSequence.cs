using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Crunchy.Dough
{
    public class ByteSequence
    {
        private byte[] bytes;
        private int hash_code;

        static public ByteSequence GenerateCryptographic(int size)
        {
            byte[] bytes = new byte[size];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            rng.GetBytes(bytes);
            return new ByteSequence(bytes);
        }

        public ByteSequence(byte[] b)
        {
            bytes = b;
            hash_code = bytes.GetElementsHashCode();
        }

        public byte[] GetBytes()
        {
            return bytes;
        }

        public int GetSize()
        {
            return bytes.Length;
        }

        public override bool Equals(object obj)
        {
            ByteSequence cast;

            if (obj.Convert<ByteSequence>(out cast))
            {
                if (cast.bytes.AreElementsEqual(bytes))
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return hash_code;
        }

        public override string ToString()
        {
            return this.ToHexString();
        }
    }
}