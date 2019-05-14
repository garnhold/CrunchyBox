using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeBuilderExtensions_ConstructorBuilder
    {
        static public ConstructorBuilder CreateConstructorBuilder(this TypeBuilder item, MethodAttributes attributes, IEnumerable<Type> parameter_types)
        {
            return item.DefineConstructor(attributes, CallingConventions.Standard, parameter_types.ToArray());
        }
        static public ConstructorBuilder CreateConstructorBuilder(this TypeBuilder item, MethodAttributes attributes, params Type[] parameter_types)
        {
            return item.CreateConstructorBuilder(attributes, (IEnumerable<Type>)parameter_types);
        }
    }
}