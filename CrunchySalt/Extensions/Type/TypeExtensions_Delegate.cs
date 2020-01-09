using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_Delegate
    {
        static public MethodInfo GetDelegateMethod(this Type item)
        {
            return item.GetTechnicalInstanceMethods()
                .Narrow(m => m.IsNamed("Invoke"))
                .GetFirst();
        }
    }
}