using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate void BasicEventDeregister(object obj, object evt);
    public delegate void EventDeregister<T>(object obj, T evt);

    static public class EventDeregisterExtensions
    {
        static public EventDeregister<T> GetTypeSafe<T>(this BasicEventDeregister item)
        {
            return delegate(object obj, T value) {
                item(obj, value);
            };
        }
    }
}