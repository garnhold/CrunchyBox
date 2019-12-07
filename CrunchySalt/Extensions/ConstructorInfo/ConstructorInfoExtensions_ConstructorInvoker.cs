using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ConstructorInfoExtensions_ConstructorInvoker
    {
        static public T CreateDynamicConstructorInvokerDelegate<T>(this ConstructorInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Invoker", delegate(MethodBase method) {
                ILParameter arguments = method.GetTechnicalILParameter(0);

                return new ILReturn(
                    new ILNew(
                        item,
                        arguments.GetILExpandedParams(item)
                    )
                );
            });
        }
    }
}