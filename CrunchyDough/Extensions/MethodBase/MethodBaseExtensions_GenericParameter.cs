using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class MethodBaseExtensions_GenericParameter
    {
        static public Type[] GetGenericParameterTypes(this MethodBase item)
        {
            if(item.IsGenericTypelessMethod())
                return item.GetGenericArguments();

            return Empty.Array<Type>();
        }

        static public int GetNumberGenericParameters(this MethodBase item)
        {
            return item.GetGenericParameterTypes().Count();
        }

        static public bool TryGetGenericParameterType(this MethodBase item, int index, out Type parameter_type)
        {
            return item.GetGenericParameterTypes().TryGet(index, out parameter_type);
        }
        static public Type GetGenericParameterType(this MethodBase item, int index)
        {
            return item.GetGenericParameterTypes().Get(index);
        }

        static public bool CanGenericParameterHold(this MethodBase item, int index, Type type)
        {
            Type parameter_type;

            if (item.TryGetGenericParameterType(index, out parameter_type))
                return parameter_type.CanHold(type);

            return false;
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