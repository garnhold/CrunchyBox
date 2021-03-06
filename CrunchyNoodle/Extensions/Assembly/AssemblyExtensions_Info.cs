using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Security;
using System.Security.Cryptography;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class AssemblyExtensions_Info
    {
        static private OperationCache<DateTime, Assembly> GET_ASSEMBLY_TIMESTAMP = ReflectionCache.Get().NewOperationCache("GET_ASSEMBLY_TIMESTAMP", delegate(Assembly item) {
            return Files.GetFileTimestamp(item.GetAssemblyFilename());
        });
        static public DateTime GetAssemblyTimestamp(this Assembly item)
        {
            return GET_ASSEMBLY_TIMESTAMP.Fetch(item);
        }

        static private OperationCache<ByteSequence, Assembly> GET_ASSEMBLY_HASH = ReflectionCache.Get().NewOperationCache("GET_ASSEMBLY_HASH", delegate(Assembly item) {
            return Files.GetStreamSystem().GetStreamHash(item.GetAssemblyFilename());
        });
        static public ByteSequence GetAssemblyHash(this Assembly item)
        {
            return GET_ASSEMBLY_HASH.Fetch(item);
        }
    }
}