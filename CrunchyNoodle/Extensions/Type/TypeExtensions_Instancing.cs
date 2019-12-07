using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class TypeExtensions_Instancing
    {
        static public object CreateBestInstance(this Type item, params object[] arguments)
        {
            return item.GetFilteredConstructors(Filterer_ConstructorInfo.CanEffectiveParametersHold(arguments))
                .GetFirst()
                .IfNotNull(c => c.Invoke(null, arguments));
        }
        static public T CreateBestInstance<T>(this Type item, params object[] arguments)
        {
            return item.CreateBestInstance(arguments).Convert<T>();
        }
    }
}