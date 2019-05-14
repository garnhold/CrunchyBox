using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using System.Security;
using System.Security.Cryptography;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class AssemblyExtensions_Info
    {
        static private OperationCache<DateTime, Assembly> GET_ASSEMBLY_TIMESTAMP = ReflectionCache.Get().NewOperationCache(delegate(Assembly item) {
            return Files.GetFileTimestamp(item.GetAssemblyFilename());
        });
        static public DateTime GetAssemblyTimestamp(this Assembly item)
        {
            return GET_ASSEMBLY_TIMESTAMP.Fetch(item);
        }

        static private OperationCache<ByteSequence, Assembly> GET_ASSEMBLY_HASH = ReflectionCache.Get().NewOperationCache(delegate(Assembly item) {
            return Files.GetStreamSystem().GetStreamHash(item.GetAssemblyFilename());
        });
        static public ByteSequence GetAssemblyHash(this Assembly item)
        {
            return GET_ASSEMBLY_HASH.Fetch(item);
        }
    }
}