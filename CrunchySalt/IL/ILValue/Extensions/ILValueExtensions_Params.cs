using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_Params
    {
        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, int start_index, IEnumerable<Type> types)
        {
            int i = start_index;

            foreach(Type type in types)
                yield return item.GetILIndexed(i++).GetILImplicitCast(type);
        }
        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, int start_index, params Type[] types)
        {
            return item.GetILExpandedParams(start_index, (IEnumerable<Type>)types);
        }

        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, IEnumerable<Type> types)
        {
            return item.GetILExpandedParams(0, types);
        }
        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, params Type[] types)
        {
            return item.GetILExpandedParams((IEnumerable<Type>)types);
        }

        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, MethodBase method)
        {
            return item.GetILExpandedParams(method.GetEffectiveParameterTypes());
        }
    }
}