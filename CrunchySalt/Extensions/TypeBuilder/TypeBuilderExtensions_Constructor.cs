using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeBuilderExtensions_Constructor
    {
        static public ConstructorBuilderEX CreateConstructor(this TypeBuilder item, MethodAttributes attributes, Operation<ILStatement, ConstructorBuilderEX> operation, IEnumerable<Type> parameter_types)
        {
            ConstructorBuilderEX constructor_builder = item.CreateConstructorBuilder(attributes, parameter_types);

            ILBody.Write(constructor_builder, operation(constructor_builder));
            return constructor_builder;
        }
        static public ConstructorBuilderEX CreateConstructor(this TypeBuilder item, MethodAttributes attributes, Operation<ILStatement, ConstructorBuilderEX> operation, params Type[] parameter_types)
        {
            return item.CreateConstructor(attributes, operation, (IEnumerable<Type>)parameter_types);
        }

        static public ConstructorBuilderEX CreateConstructor(this TypeBuilder item, MethodAttributes attributes, ILStatement statement, IEnumerable<Type> parameter_types)
        {
            return item.CreateConstructor(attributes, m => statement, parameter_types);
        }
        static public ConstructorBuilderEX CreateConstructor(this TypeBuilder item, MethodAttributes attributes, ILStatement statement, params Type[] parameter_types)
        {
            return item.CreateConstructor(attributes, statement, (IEnumerable<Type>)parameter_types);
        }
    }
}