using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_DynamicMethod_Convience
	{
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>((Delegate)operation);
        }

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>(name, (Delegate)operation, parameter_types);
		}

		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, IEnumerable<Type> parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		static public T CreateDynamicMethodDelegateWithForcedParameterTypes<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation, params Type[] parameter_types)
		{
			return item.CreateDynamicMethodDelegateWithForcedParameterTypes<T>((Delegate)operation, parameter_types);
		}
		}
}