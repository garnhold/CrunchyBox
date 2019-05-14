using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ConstructorInfoExtensions_Caller
    {
        static public T CreateDynamicConstructorCallerDelegate<T>(this ConstructorInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Caller", delegate(MethodBase method) {
                return new ILReturn(
                    new ILNew(
                        item,
                        item.GetAllTechnicalILParameters()
                            .Convert<ILParameter, ILValue>()
                    )
                );
            });
        }
    }
}