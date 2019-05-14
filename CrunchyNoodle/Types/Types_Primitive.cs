using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public partial class Types
    {
        static private OperationCache<Type[]> GET_ALL_PRIMITIVE_TYPES = ReflectionCache.Get().NewOperationCache(delegate() {
            return new Type[] {
                typeof(bool),
                typeof(byte),
                typeof(short),
                typeof(int),
                typeof(long),
                typeof(float),
                typeof(double),
                typeof(decimal),
                typeof(string),
                typeof(object)
            };
        });
        static public IEnumerable<Type> GetAllPrimitiveTypes()
        {
            return GET_ALL_PRIMITIVE_TYPES.Fetch();
        }
    }
}