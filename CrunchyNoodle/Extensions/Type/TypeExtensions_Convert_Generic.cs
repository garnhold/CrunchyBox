using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Convert_Generic
    {
        static public BasicConversionInvoker GetConversionInvoker<T>(this Type item)
        {
            return TypeExtensions_Convert_Generic_Internal<T>.GetConversionInvoker(item);
        }
    }
}