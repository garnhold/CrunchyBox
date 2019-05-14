using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldInfoExtensions_EX
    {
        static public FieldInfoEX GetFieldInfoEX(this FieldInfo item)
        {
            return FieldInfoEX.GetFieldInfoEX(item);
        }

        static public BasicValueSetter GetBasicValueSetter(this FieldInfo item)
        {
            return item.GetFieldInfoEX().GetBasicValueSetter();
        }
        static public ValueSetter<T> GetValueSetter<T>(this FieldInfo item)
        {
            return item.GetFieldInfoEX().GetValueSetter<T>();
        }

        static public BasicValueGetter GetBasicValueGetter(this FieldInfo item)
        {
            return item.GetFieldInfoEX().GetBasicValueGetter();
        }
        static public ValueGetter<T> GetValueGetter<T>(this FieldInfo item)
        {
            return item.GetFieldInfoEX().GetValueGetter<T>();
        }
    }
}