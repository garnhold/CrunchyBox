using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ConstructorInfoExtensions
    {
        static public T CreateDynamicMethodDelegate<T>(this ConstructorInfo item, string name, Operation<ILStatement, MethodBase> operation)
        {
            return item.DeclaringType.CreateDynamicMethodDelegate<T>(item.DeclaringType.Name + "." + item.Name + "." + name, operation);
        }
    }
}