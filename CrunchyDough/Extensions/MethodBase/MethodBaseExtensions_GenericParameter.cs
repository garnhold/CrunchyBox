using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_GenericParameter
    {
        static public IEnumerable<Type> GetGenericParameterTypes(this MethodBase item)
        {
            if(item.IsGenericTypelessMethod())
                return item.GetGenericArguments();

            return Empty.IEnumerable<Type>();
        }

        static public bool CanGenericParametersHold(this MethodBase item, IEnumerable<Type> parameter_types)
        {
            if (item.GetGenericParameterTypes().AreElements(parameter_types, (p1, p2) => p1.CanHold(p2)))
                return true;

            return false;
        }
        static public bool CanGenericParametersHold(this MethodBase item, params Type[] parameter_types)
        {
            return item.CanGenericParametersHold((IEnumerable<Type>)parameter_types);
        }
    }
}