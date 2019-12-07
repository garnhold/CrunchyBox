using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeBuilderExtensions_ConstructorBuilder
    {
        static public ConstructorBuilderEX CreateConstructorBuilder(this TypeBuilder item, MethodAttributes attributes, IEnumerable<Type> parameter_types)
        {
            ConstructorBuilder builder = item.DefineConstructor(attributes, CallingConventions.Standard, parameter_types.ToArray());

            return new ConstructorBuilderEX(builder, parameter_types);
        }
        static public ConstructorBuilderEX CreateConstructorBuilder(this TypeBuilder item, MethodAttributes attributes, params Type[] parameter_types)
        {
            return item.CreateConstructorBuilder(attributes, (IEnumerable<Type>)parameter_types);
        }
    }
}