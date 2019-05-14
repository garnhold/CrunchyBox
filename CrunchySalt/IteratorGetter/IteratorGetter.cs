using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate IEnumerable IteratorGetter(object obj);
    public delegate IEnumerable<T> IteratorGetter<T>(object obj);

    static public class IteratorGetterExtensions
    {
        static public IteratorGetter<T> GetTypeSafe<T>(this IteratorGetter item)
        {
            return delegate(object obj) {
                return item(obj).Bridge<T>();
            };
        }
    }
}