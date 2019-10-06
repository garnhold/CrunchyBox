using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    static public class PropertyInfoExtensions_Value
    {
        static public T CreateDynamicPropertyGetterDelegate<T>(this PropertyInfo item)
        {
            MethodInfo get_method = item.GetGetMethod(true);

            return item.CreateDynamicMethodDelegate<T>("Getter", delegate(MethodBase method) {
                ILParameter target = method.GetTechnicalILParameter(0);
                ILParameter index = method.GetTechnicalILParameter(1);

                return new ILReturn(
                    new ILMethodInvokation(
                        target.GetILThinCast(get_method.GetILMethodInvokationType()),
                        get_method,
                        index.GetILExpandedParams(item.GetIndexParameters().Convert(p => p.ParameterType))
                    )
                );
            });
        }

        static public T CreateDynamicPropertySetterDelegate<T>(this PropertyInfo item)
        {
            MethodInfo set_method = item.GetSetMethod(true);

            return item.CreateDynamicMethodDelegate<T>("Setter", delegate(MethodBase method) {
                ILParameter target = method.GetTechnicalILParameter(0);
                ILParameter index = method.GetTechnicalILParameter(1);
                ILParameter value = method.GetTechnicalILParameter(2);
                
                return new ILReturn(
                    new ILMethodInvokation(
                        target.GetILThinCast(set_method.GetILMethodInvokationType()),
                        set_method,
                        index.GetILExpandedParams(item.GetIndexParameters().Convert(p => p.ParameterType))
                            .Prepend(value)
                    )
                );
            });
        }
    }
}