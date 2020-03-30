using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public delegate object BasicConstructorInvoker(params object[] parameters);
    public delegate T ConstructorInvoker<T>(params object[] parameters);

    static public class ConstructorInvokerExtensions
    {
        static public ConstructorInvoker<T> GetTypeSafe<T>(this BasicConstructorInvoker item)
        {
            return delegate(object[] parameters) {
                return (T)item(parameters);
            };
        }

        static public BasicConversionInvoker GetBasicConversionInvoker(this BasicConstructorInvoker item)
        {
            return delegate (object obj) {
                return item(obj);
            };
        }

        static public BasicMethodInvoker GetBasicMethodInvoker(this BasicConstructorInvoker item)
        {
            return delegate (object obj, object[] parameters) {
                return item(parameters);
            };
        }
    }
}