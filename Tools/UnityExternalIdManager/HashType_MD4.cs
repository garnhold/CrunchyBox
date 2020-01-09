using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

using Crunchy.Dough;

public class HashType_MD4 : HashType
{
    static public readonly HashType_MD4 INSTANCE = new HashType_MD4();

    private HashType_MD4() { }

    public override HashAlgorithm CreateAlgorithm()
    {
        return new MD4();
    }
}
static public partial class HashTypes
{
    static public readonly HashType MD4 = HashType_MD4.INSTANCE;
}