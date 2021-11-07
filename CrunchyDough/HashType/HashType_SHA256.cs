using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace Crunchy.Dough
{
    public class HashType_SHA256 : HashType
    {
        static public readonly HashType_SHA256 INSTANCE = new HashType_SHA256();

        private HashType_SHA256() { }

        public override HashAlgorithm CreateAlgorithm()
        {
            return SHA256.Create();
        }
    }
    static public partial class HashTypes
    {
        static public readonly HashType SHA256 = HashType_SHA256.INSTANCE;
    }
}