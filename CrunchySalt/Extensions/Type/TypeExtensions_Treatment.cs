using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeExtensions_Treatment
    {
        static public bool CanILTreatAs(this Type item, Type type)
        {
            if (item.CanBeTreatedAs(type))
            {
                if (item.IsValueType == type.IsValueType)
                    return true;
            }

            return false;
        }
        static public bool CanILTreatAs<T>(this Type item)
        {
            return item.CanILTreatAs(typeof(T));
        }
    }
}