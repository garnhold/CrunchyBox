using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Params
    {
        static public IEnumerable<ILValue> GetILExpandedParams(this ILValue item, int start_index, IEnumerable<Type> types)
        {
            return types.ConvertWithIndex((i, t) => item.GetILIndexed(i + start_index).GetILImplicitCast(t));
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