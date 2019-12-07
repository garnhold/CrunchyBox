using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public delegate void BasicEventRegister(object obj, object evt);
    public delegate void EventRegister<T>(object obj, T evt);

    static public class EventRegisterExtensions
    {
        static public EventRegister<T> GetTypeSafe<T>(this BasicEventRegister item)
        {
            return delegate(object obj, T value) {
                item(obj, value);
            };
        }
    }
}