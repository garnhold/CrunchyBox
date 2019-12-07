using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Instancing_Array
    {
        static public Array CreateArrayInstance(this Type item, int size)
        {
            if (item != null)
                return (Array)item.MakeArrayType().CreateInstance(size);

            return null;
        }
    }
}