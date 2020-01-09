using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class MethodInfoExtensions_MethodInvoker
    {
        static public T CreateDynamicMethodInvokerDelegate<T>(this MethodInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Invoker", delegate(MethodBase method) {
                ILParameter target = method.GetTechnicalILParameter(0);
                ILParameter arguments = method.GetTechnicalILParameter(1);

                return new ILReturn(
                    new ILMethodInvokation(
                        target.GetILThinCast(item.GetILMethodInvokationType()),
                        item,
                        arguments.GetILExpandedParams(item)
                    )
                );
            });
        }
    }
}