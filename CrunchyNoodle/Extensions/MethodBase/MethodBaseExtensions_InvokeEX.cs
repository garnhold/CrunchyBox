using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class MethodBaseExtensions_InvokeEX
    {
        static public object InvokeEX(this MethodBase item, object target, object[] arguments)
        {
            return item.Invoke(
                target,
                arguments.PairStrict(item.GetTechnicalParameterTypes(), (v, t) => v.ConvertEX(t))
                    .ToArray()
            );
        }
    }
}