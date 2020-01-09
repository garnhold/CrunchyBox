using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_DynamicMethod
    {
        static public string GenerateDynamicMethodName(string name)
        {
            if (name.IsBlank())
                name = ProgrammingEntityName.GenerateFunctionName();

            return "Crunchy.Salt.DynamicMethod[" + name + "]";
        }

        static public DynamicMethod CreateDynamicMethod(this Type item, string name, Type return_type, params Type[] parameter_types)
        {
            item.PrepareForDynamicUse();

            return new DynamicMethod(GenerateDynamicMethodName(name), return_type, parameter_types, typeof(ThisAssembly).Module, true);
        }
        static public DynamicMethod CreateDynamicMethod(this Type item, string name, Type return_type, IEnumerable<Type> parameter_types)
        {
            return item.CreateDynamicMethod(name, return_type, parameter_types.ToArray());
        }

        static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, MethodBase> operation)
        {
            Type delegate_type = typeof(T);
            MethodInfo delegate_method = delegate_type.GetDelegateMethod();

            DynamicMethod dynamic_method = item.CreateDynamicMethod(name, delegate_method.ReturnType, delegate_method.GetTechnicalParameterTypes());
            ILBody body = ILBody.Write(dynamic_method, operation(dynamic_method));

            T to_return = dynamic_method.CreateDelegate<T>();

            DYNAMIC_IL_BODY.Add(to_return, body);
            return to_return;
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, string name, ILStatement statement)
        {
            return item.CreateDynamicMethodDelegate<T>(name, delegate(MethodBase method) {
                return statement;
            });
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, ILStatement statement)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, statement);
        }

        static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Delegate operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, delegate(MethodBase method) {
                return operation.DynamicInvoke(method.GetAllTechnicalILParameters().ToArray()).Convert<ILStatement>();
            });
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Delegate operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }

        static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Delegate operation, IEnumerable<Type> parameter_types)
        {
            return item.CreateDynamicMethodDelegate<T>(name, delegate(MethodBase method) {
                ILBlock block = new ILBlock();

                ILValue[] arguments = method.GetAllTechnicalILParameters()
                    .GetILImplicitCasts(parameter_types)
                    .Convert(v => block.CreateTrivial(v))
                    .ToArray();

                block.AddStatement(operation.DynamicInvoke(arguments).Convert<ILStatement>());
                return block;
            });
        }
        static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Delegate operation, params Type[] parameter_types)
        {
            return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, operation, (IEnumerable<Type>)parameter_types);
        }

        static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Delegate operation, IEnumerable<Type> parameter_types)
        {
            return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(typeof(T).Name, operation, parameter_types);
        }
        static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Delegate operation, params Type[] parameter_types)
        {
            return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(operation, (IEnumerable<Type>)parameter_types);
        }

        static private readonly Dictionary<object, ILBody> DYNAMIC_IL_BODY = new Dictionary<object, ILBody>();
        static public ILBody GetDynamicMethodILBody(this Delegate item)
        {
            return DYNAMIC_IL_BODY.GetValue(item);
        }
    }
}