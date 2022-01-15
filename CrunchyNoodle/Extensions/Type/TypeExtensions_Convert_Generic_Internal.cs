using System;
using System.Reflection;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Convert_Generic_Internal<T>
    {
        static private OperationCache<BasicConversionInvoker, Type> GET_CONVERSION_INVOKER = ReflectionCache.Get().NewOperationCache("GET_CONVERSION_INVOKER_" + typeof(T), delegate(Type item) {
            return item.GetConversionInvoker(typeof(T));
        });
        static public BasicConversionInvoker GetConversionInvoker(Type item)
        {
            return GET_CONVERSION_INVOKER.Fetch(item);
        }
    }
}