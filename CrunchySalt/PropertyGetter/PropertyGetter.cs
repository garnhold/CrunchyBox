using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate object BasicPropertyGetter(object obj, object[] index);
    public delegate T PropertyGetter<T>(object obj, object[] index);

    static public class PropertyGetterExtensions
    {
        static public PropertyGetter<T> GetTypeSafe<T>(this BasicPropertyGetter item)
        {
            return delegate(object obj, object[] index) {
                return (T)item(obj, index);
            };
        }

        static public IEnumerable<T> ConvertToPropertys<T>(this IEnumerable<PropertyGetter<T>> item, object obj, object[] index)
        {
            return item.Convert<PropertyGetter<T>, T>(f => f(obj, index));
        }
    }
}