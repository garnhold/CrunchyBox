using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class MethodInfoExtensions_MethodCaller
    {
        static public T CreateDynamicMethodCallerDelegate<T>(this MethodInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Caller", delegate(MethodBase method) {
                ILParameter target = method.GetTechnicalILParameter(0);

                return new ILReturn(
                    new ILMethodInvokation(
                        target.GetILThinCast(item.GetILMethodInvokationType()),
                        item,
                        method.GetTechnicalILParameterRange(1, item.GetNumberTechnicalParameters())
                            .Convert<ILParameter, ILValue>()
                    )
                );
            });
        }
    }
}