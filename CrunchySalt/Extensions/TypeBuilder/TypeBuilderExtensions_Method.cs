using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeBuilderExtensions_Method
    {
        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, Operation<ILStatement, MethodBuilderEX> operation, IEnumerable<Type> parameter_types)
        {
            MethodBuilderEX method_builder = item.CreateMethodBuilder(name, method_attributes, return_type, parameter_types);

            ILBody.Write(method_builder, operation(method_builder));
            return method_builder;
        }
        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, Operation<ILStatement, MethodBuilderEX> operation, params Type[] parameter_types)
        {
            return item.CreateMethod(name, method_attributes, return_type, operation, (IEnumerable<Type>)parameter_types);
        }

        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Operation<ILStatement, MethodBuilderEX> operation, IEnumerable<Type> parameter_types)
        {
            return item.CreateMethod(name, method_attributes, typeof(void), operation, parameter_types);
        }
        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Operation<ILStatement, MethodBuilderEX> operation, params Type[] parameter_types)
        {
            return item.CreateMethod(name, method_attributes, operation, (IEnumerable<Type>)parameter_types);
        }

        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, ILStatement statement, IEnumerable<Type> parameter_types)
        {
            return item.CreateMethod(name, method_attributes, return_type, m => statement, parameter_types);
        }
        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, Type return_type, ILStatement statement, params Type[] parameter_types)
        {
            return item.CreateMethod(name, method_attributes, return_type, statement, (IEnumerable<Type>)parameter_types);
        }

        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, ILStatement statement, IEnumerable<Type> parameter_types)
        {
            return item.CreateMethod(name, method_attributes, typeof(void), statement, parameter_types);
        }
        static public MethodBuilderEX CreateMethod(this TypeBuilder item, string name, MethodAttributes method_attributes, ILStatement statement, params Type[] parameter_types)
        {
            return item.CreateMethod(name, method_attributes, statement, (IEnumerable<Type>)parameter_types);
        }
    }
}