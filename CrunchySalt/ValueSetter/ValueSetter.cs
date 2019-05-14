using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate void BasicValueSetter(object obj, object value);
    public delegate void ValueSetter<T>(object obj, T value);

    static public class ValueSetterExtensions
    {
        static public ValueSetter<T> GetTypeSafe<T>(this BasicValueSetter item)
        {
            return delegate(object obj, T value) {
                item(obj, value);
            };
        }
    }
}