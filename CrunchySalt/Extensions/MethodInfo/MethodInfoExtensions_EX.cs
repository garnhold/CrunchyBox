using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoExtensions_EX
    {
        static public MethodInfoEX GetMethodInfoEX(this MethodInfo item)
        {
            return MethodInfoEX.GetMethodInfoEX(item);
        }

        static public BasicMethodInvoker GetBasicMethodInvoker(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetBasicMethodInvoker();
        }
        static public MethodInvoker GetMethodInvoker(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetMethodInvoker();
        }
        static public MethodInvoker<T> GetMethodInvoker<T>(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetMethodInvoker<T>();
        }

        static public BasicValueGetter GetSimulatedBasicValueGetter(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetSimulatedBasicValueGetter();
        }

        static public BasicValueSetter GetSimulatedBasicValueSetter(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetSimulatedBasicValueSetter();
        }

        static public ValueGetter<T> GetSimulatedValueGetter<T>(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetSimulatedValueGetter<T>();
        }

        static public ValueSetter<T> GetSimulatedValueSetter<T>(this MethodInfo item)
        {
            return item.GetMethodInfoEX().GetSimulatedValueSetter<T>();
        }
    }
}