using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class FieldInfoExtensions_Value
    {
        static public T CreateDynamicValueGetterDelegate<T>(this FieldInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Getter", delegate(MethodBase method) {
                return new ILReturn(
                    method.GetTechnicalILParameter(0)
                        .GetILThinCast(item.GetILFieldInvokationType())
                        .GetILField(item)
                );
            });
        }

        static public T CreateDynamicValueSetterDelegate<T>(this FieldInfo item)
        {
            return item.CreateDynamicMethodDelegate<T>("Setter", delegate(MethodBase method) {
                return new ILAssign(
                    method.GetTechnicalILParameter(0)
                        .GetILThinCast(item.GetILFieldInvokationType())
                        .GetILField(item),
                    method.GetTechnicalILParameter(1)
                );
            });
        }
    }
}