using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace CrunchyDough
{
    public class HashType_MD5 : HashType
    {
        static public readonly HashType_MD5 INSTANCE = new HashType_MD5();

        private HashType_MD5() { }

        public override HashAlgorithm CreateAlgorithm()
        {
            return MD5.Create();
        }
    }
    static public partial class HashTypes
    {
        static public readonly HashType MD5 = HashType_MD5.INSTANCE;
    }
}