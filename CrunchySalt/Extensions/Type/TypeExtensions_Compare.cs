using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_Compare
    {
        static private OperationCache<bool, Type> IS_REFERENCE_FREE_TYPE = ReflectionCache.Get().NewOperationCache("IS_REFERENCE_FREE_TYPE", delegate (Type type) {
            if (type.GetInstanceFields().AreAll(f => f.FieldType.IsReferenceFreeType()))
                return true;

            return false;
        });
        static public bool IsReferenceFreeType(this Type item)
        {
            if (item.IsPrimitive())
                return true;

            if (item.IsValueType())
                return IS_REFERENCE_FREE_TYPE.Fetch(item);

            return false;
        }
    }
}