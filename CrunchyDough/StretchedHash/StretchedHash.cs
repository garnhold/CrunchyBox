using System;
using System.IO;
using System.Security.Cryptography;

namespace Crunchy.Dough
{
    public class StretchedHash
    {
        private ByteSequence hash;

        private ByteSequence salt;
        private int iterations;

        static public int CalculateDecentNumberIterations()
        {
            TimeSpan time = DateTime.UtcNow - new DateTime(2019, 1, 1);

            return (int)(8192 * Math.Pow(2, time.TotalDays / 730.0));
        }

        public StretchedHash(ByteSequence h, ByteSequence s, int i)
        {
            hash = h;

            salt = s;
            iterations = i;
        }

        public StretchedHash(byte[] b, int hs, ByteSequence s, int i)
        {
            salt = s;
            iterations = i;

            hash = new ByteSequence(
                new Rfc2898DeriveBytes(b, salt.GetBytes(), iterations).GetBytes(hs)
            );
        }

        public StretchedHash(byte[] b, int hs, int ss, int i) : this(b, hs, ByteSequence.GenerateCryptographic(ss), i) { }
        public StretchedHash(byte[] b, StretchedHash s) : this(b, s.GetSize(), s.GetSalt(), s.GetIterations()) { }

        public StretchedHash(byte[] b, int hs, int i) : this(b, hs, hs.BindAbove(16), i) { }
        public StretchedHash(byte[] b, int i) : this(b, 64, i) { }
        public StretchedHash(byte[] b) : this(b, CalculateDecentNumberIterations()) { }

        public StretchedHash(string b, int hs, int ss, int i) : this(b.ToUnicodeBytes(), hs, ss, i) { }
        public StretchedHash(string b, int hs, int i) : this(b.ToUnicodeBytes(), hs, i) { }
        public StretchedHash(string b, int i) : this(b.ToUnicodeBytes(), i) { }
        public StretchedHash(string b) : this(b.ToUnicodeBytes()) { }

        public StretchedHash(string b, StretchedHash s) : this(b.ToUnicodeBytes(), s) { }

        public int GetSize()
        {
            return hash.GetSize();
        }

        public ByteSequence GetSalt()
        {
            return salt;
        }

        public ByteSequence GetHash()
        {
            return hash;
        }

        public int GetIterations()
        {
            return iterations;
        }

        public override bool Equals(object obj)
        {
            StretchedHash cast;

            if (obj.Convert<StretchedHash>(out cast))
            {
                if (cast.hash.EqualsEX(hash))
                {
                    if (cast.salt.EqualsEX(salt))
                    {
                        if (cast.iterations == iterations)
                            return true;
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int code = 17;

                code = code * 23 + hash.GetHashCodeEX();
                code = code * 23 + salt.GetHashCodeEX();
                code = code * 23 + iterations.GetHashCodeEX();
                return code;
            }
        }
    }
}