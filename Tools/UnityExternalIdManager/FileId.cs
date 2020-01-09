using System;
using System.Security.Cryptography;

using Crunchy.Dough;

static public class FileId
{
    static public int Calculate(string type_namespace, string type_name)
    {
        int basic_type = 115; //MonoScript
        string type_string = type_namespace + type_name;

        return HashType_MD4.INSTANCE.Calculate(
            basic_type.GetCompositeBytes().Append(type_string.ToUTF8Bytes())
        )
        .GetBytes()
        .GetCompositeInt();
    }
}