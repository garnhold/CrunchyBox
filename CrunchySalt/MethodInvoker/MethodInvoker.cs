using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public delegate object BasicMethodInvoker(object obj, object[] parameters);

    public delegate void MethodInvoker(object obj, object[] parameters);
    public delegate T MethodInvoker<T>(object obj, object[] parameters);

    static public class MethodInvokerExtensions
    {
        static public MethodInvoker GetTypeSafeNoReturn(this BasicMethodInvoker item)
        {
            return delegate(object obj, object[] parameters) {
                item(obj, parameters);
            };
        }

        static public MethodInvoker<T> GetTypeSafe<T>(this BasicMethodInvoker item)
        {
            return delegate(object obj, object[] parameters) {
                return (T)item(obj, parameters);
            };
        }

        static public BasicValueGetter GetSimulatedBasicValueGetter(this BasicMethodInvoker item)
        {
            return delegate(object obj) {
                return item(obj, new object[]{});
            };
        }

        static public BasicValueSetter GetSimulatedBasicValueSetter(this BasicMethodInvoker item)
        {
            return delegate(object obj, object value) {
                item(obj, new object[]{value});
            };
        }

        static public ValueGetter<T> GetSimulatedValueGetter<T>(this BasicMethodInvoker item)
        {
            return delegate(object obj) {
                return (T)item(obj, new object[]{});
            };
        }

        static public ValueSetter<T> GetSimulatedValueSetter<T>(this BasicMethodInvoker item)
        {
            return delegate(object obj, T value) {
                item(obj, new object[]{value});
            };
        }
    }
}