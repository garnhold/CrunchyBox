using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TypeExtensions_GenericParameter
    {
        static public IEnumerable<Type> GetGenericParameterTypes(this Type item)
        {
            if (item.IsGenericTypelessClass())
                return item.GetGenericArguments();

            return Empty.IEnumerable<Type>();
        }

        static public bool CanGenericParametersHold(this Type item, IEnumerable<Type> parameter_types)
        {
            if (item.GetGenericParameterTypes().AreElements(parameter_types, (p1, p2) => p1.CanHold(p2)))
                return true;

            return false;
        }
        static public bool CanGenericParametersHold(this Type item, params Type[] parameter_types)
        {
            return item.CanGenericParametersHold((IEnumerable<Type>)parameter_types);
        }
    }
}