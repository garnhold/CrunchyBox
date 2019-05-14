using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class MethodInfoExtensions
    {
        static public T CreateDynamicMethodDelegate<T>(this MethodInfo item, string name, Operation<ILStatement, MethodBase> operation)
        {
            return item.GetMethodTechnicalType().CreateDynamicMethodDelegate<T>(item.DeclaringType.Name + "." + item.Name + "." + name, operation);
        }
    }
}