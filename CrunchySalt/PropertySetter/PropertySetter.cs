using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate void BasicPropertySetter(object obj, object[] index, object value);
    public delegate void PropertySetter<T>(object obj, object[] index, T value);

    static public class PropertySetterExtensions
    {
        static public PropertySetter<T> GetTypeSafe<T>(this BasicPropertySetter item)
        {
            return delegate(object obj, object[] index, T value) {
                item(obj, index, value);
            };
        }
    }
}