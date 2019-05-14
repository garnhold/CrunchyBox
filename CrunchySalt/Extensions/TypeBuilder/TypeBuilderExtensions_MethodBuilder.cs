using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeBuilderExtensions_MethodBuilder
    {
        static public MethodBuilder CreateMethodBuilder(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, IEnumerable<Type> parameter_types)
        {
            MethodBuilder method_builder = item.DefineMethod(name, method_attributes, CallingConventions.Standard, return_type, parameter_types.ToArray());

            if (method_attributes.HasTheFlag(MethodAttributes.Virtual))
            {
                MethodInfo base_method = item.BaseType.GetMethod(name, parameter_types.ToArray());

                if (base_method != null)
                    item.DefineMethodOverride(method_builder, base_method);
            }

            return method_builder;
        }
        static public MethodBuilder CreateMethodBuilder(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, params Type[] parameter_types)
        {
            return item.CreateMethodBuilder(name, method_attributes, return_type, (IEnumerable<Type>)parameter_types);
        }
    }
}