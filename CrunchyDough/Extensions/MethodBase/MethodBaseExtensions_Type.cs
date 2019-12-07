using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class MethodBaseExtensions_Type
    {
        static public Type GetMethodEffectiveType(this MethodBase item)
        {
            if (item.IsExtensionMethod())
                return item.GetTechnicalParameterType(0);

            return item.DeclaringType;
        }

        static public Type GetMethodTechnicalType(this MethodBase item)
        {
            return item.DeclaringType;
        }
    }
}