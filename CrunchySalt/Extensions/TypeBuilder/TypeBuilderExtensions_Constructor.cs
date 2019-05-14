using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeBuilderExtensions_Constructor
    {
        static public ConstructorBuilder CreateConstructor(this TypeBuilder item, MethodAttributes attributes, Operation<ILStatement, ConstructorBuilder> operation, IEnumerable<Type> parameter_types)
        {
            ConstructorBuilder constructor_builder = item.CreateConstructorBuilder(attributes, parameter_types);

            ILBody.Write(constructor_builder, operation(constructor_builder));
            return constructor_builder;
        }
        static public ConstructorBuilder CreateConstructor(this TypeBuilder item, MethodAttributes attributes, Operation<ILStatement, ConstructorBuilder> operation, params Type[] parameter_types)
        {
            return item.CreateConstructor(attributes, operation, (IEnumerable<Type>)parameter_types);
        }

        static public ConstructorBuilder CreateConstructor(this TypeBuilder item, MethodAttributes attributes, ILStatement statement, IEnumerable<Type> parameter_types)
        {
            return item.CreateConstructor(attributes, m => statement, parameter_types);
        }
        static public ConstructorBuilder CreateConstructor(this TypeBuilder item, MethodAttributes attributes, ILStatement statement, params Type[] parameter_types)
        {
            return item.CreateConstructor(attributes, statement, (IEnumerable<Type>)parameter_types);
        }
    }
}