using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Crunchy.Dough
{
    public class HashType_SHA1 : HashType
    {
        static public readonly HashType_SHA1 INSTANCE = new HashType_SHA1();

        private HashType_SHA1() { }

        public override HashAlgorithm CreateAlgorithm()
        {
            return SHA1.Create();
        }
    }
    static public partial class HashTypes
    {
        static public readonly HashType SHA1 = HashType_SHA1.INSTANCE;
    }
}