using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_Foreign
    {
        static public Type GetNativeType(this Type item)
        {
            ForeignType foreign_type;

            if (item.Convert<ForeignType>(out foreign_type))
                return foreign_type.GetNativeType();

            return item;
        }
    }
}