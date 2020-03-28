using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ProgramInfo
    {
        static private string CalculateIdByAttribute()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Narrow(a => a.HasCustomAttributeOfType<ProgramInfoAttribute>(true))
                .GetOnly()
                .IfNotNull(a => a.GetCustomAttributeOfType<ProgramInfoAttribute>(true).GetName());
        }
        static private string CalculateIdByEntry()
        {
            return Assembly.GetEntryAssembly()
                .IfNotNull(a => a.GetAssemblyId());
        }
        static private string CalculateIdByCollective()
        {
            return "Crunchy" + HashTypes.SHA1.CalculateAsUnicode(
                AppDomain.CurrentDomain.GetAssemblies()
                    .Convert(a => a.GetAssemblyId())
                    .Join(":")
            )
            .ToHexString()
            .Surround("{", "}");
        }

        static private OperationCache<string> GET_ID = ReflectionCache.Get().NewOperationCache("GET_ID", delegate() {
            return CalculateIdByAttribute() ??
                CalculateIdByEntry() ??
                CalculateIdByCollective();
        });
        static public string GetId()
        {
            return GET_ID.Fetch();
        }
    }
}