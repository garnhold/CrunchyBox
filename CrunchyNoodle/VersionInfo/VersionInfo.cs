using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VersionInfo
    {
        static private OperationCache<ByteSequence> GET_ID = ReflectionCache.Get().NewOperationCache("GET_ID", delegate() {
            return HashTypes.SHA1.CalculateAsUnicode(
                Assemblys.GetAllInspectedAssemblys()
                    .Convert(a => a.GetAssemblyId() + a.GetAssemblyTimestamp())
                    .Join(":")
            );
        });
        static public ByteSequence GetId()
        {
            return GET_ID.Fetch();
        }

        static private OperationCache<string> GET_ID_STRING = ReflectionCache.Get().NewOperationCache("GET_ID_STRING", delegate() {
            return GetId().ToHexString();
        });
        static public string GetIdString()
        {
            return GET_ID_STRING.Fetch();
        }
    }
}