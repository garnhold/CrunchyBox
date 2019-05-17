using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_IEnumerable_Type
    {
        static public IEnumerable<Type> GetValueTypes(this IEnumerable<ILValue> item)
        {
            return item.Convert(i => i.GetValueType());
        }
    }
}