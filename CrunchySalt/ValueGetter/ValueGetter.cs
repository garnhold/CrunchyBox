using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate object BasicValueGetter(object obj);
    public delegate T ValueGetter<T>(object obj);

    static public class ValueGetterExtensions
    {
        static public ValueGetter<T> GetTypeSafe<T>(this BasicValueGetter item)
        {
            return delegate(object obj) {
                return (T)item(obj);
            };
        }

        static public IEnumerable<T> ConvertToValues<T>(this IEnumerable<ValueGetter<T>> item, object obj)
        {
            return item.Convert<ValueGetter<T>, T>(f => f(obj));
        }
    }
}