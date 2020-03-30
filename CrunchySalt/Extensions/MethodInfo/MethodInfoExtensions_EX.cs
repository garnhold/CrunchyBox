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
            return item.GetBasicMethodInvoker().GetTypeSafeNoReturn();
        }
        static public MethodInvoker<T> GetMethodInvoker<T>(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetTypeSafe<T>();
        }

        static public BasicConversionInvoker GetBasicConversionInvoker(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetBasicConversionInvoker();
        }

        static public BasicValueGetter GetSimulatedBasicValueGetter(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetSimulatedBasicValueGetter();
        }

        static public BasicValueSetter GetSimulatedBasicValueSetter(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetSimulatedBasicValueSetter();
        }

        static public ValueGetter<T> GetSimulatedValueGetter<T>(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetSimulatedValueGetter<T>();
        }

        static public ValueSetter<T> GetSimulatedValueSetter<T>(this MethodInfo item)
        {
            return item.GetBasicMethodInvoker().GetSimulatedValueSetter<T>();
        }
    }
}