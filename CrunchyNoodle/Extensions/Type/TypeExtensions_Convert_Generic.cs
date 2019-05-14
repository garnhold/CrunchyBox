using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Convert_Generic
    {
        static public BasicMethodInvoker GetConversionInvoker<T>(this Type item)
        {
            return TypeExtensions_Convert_Generic_Internal<T>.GetConversionInvoker(item);
        }
    }
}