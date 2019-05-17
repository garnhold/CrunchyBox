using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_IEnumerable_Cast
    {
        static public IEnumerable<ILValue> GetILThinCasts(this IEnumerable<ILValue> item, IEnumerable<Type> types)
        {
            return item.PairStrict(types, (i, t) => i.GetILThinCast(t));
        }

        static public IEnumerable<ILValue> GetILImplicitCasts(this IEnumerable<ILValue> item, IEnumerable<Type> types)
        {
            return item.PairStrict(types, (i, t) => i.GetILImplicitCast(t));
        }

        static public IEnumerable<ILValue> GetILExplicitCasts(this IEnumerable<ILValue> item, IEnumerable<Type> types)
        {
            return item.PairStrict(types, (i, t) => i.GetILExplicitCast(t));
        }
    }
}