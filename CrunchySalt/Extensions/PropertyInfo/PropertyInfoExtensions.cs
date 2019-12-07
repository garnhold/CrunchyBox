using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class PropertyInfoExtensions
    {
        static public T CreateDynamicMethodDelegate<T>(this PropertyInfo item, string name, Operation<ILStatement, MethodBase> operation)
        {
            return item.DeclaringType.CreateDynamicMethodDelegate<T>(item.DeclaringType.Name + "." + item.Name + "." + name, operation);
        }
    }
}