using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_IEnumerable_Type
    {
        static public IEnumerable<Type> GetValueTypes<T>(this IEnumerable<T> item) where T : ILValue
        {
            return item.Convert(i => i.GetValueType());
        }
    }
}