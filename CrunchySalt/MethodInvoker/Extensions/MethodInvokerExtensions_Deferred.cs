using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public delegate void DeferredMethodInvoker(params object[] parameters);
    public delegate T DeferredMethodInvoker<T>(params object[] parameters);

    static public class MethodInvokerExtensions_Deferred
    {
        static public DeferredMethodInvoker GetDeferred(this MethodInvoker item, object obj)
        {
            return delegate(object[] parameters) {
                item(obj, parameters);
            };
        }
        static public IEnumerable<DeferredMethodInvoker> ConvertToDeferred(this IEnumerable<MethodInvoker> item, object obj)
        {
            return item.Convert<MethodInvoker, DeferredMethodInvoker>(i => i.GetDeferred(obj));
        }

        static public DeferredMethodInvoker<T> GetDeferred<T>(this MethodInvoker<T> item, object obj)
        {
            return delegate(object[] parameters) {
                return item(obj, parameters);
            };
        }
        static public IEnumerable<DeferredMethodInvoker<T>> ConvertToDeferred<T>(this IEnumerable<MethodInvoker<T>> item, object obj)
        {
            return item.Convert<MethodInvoker<T>, DeferredMethodInvoker<T>>(i => i.GetDeferred<T>(obj));
        }
    }
}