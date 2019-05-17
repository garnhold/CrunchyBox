using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
	static public class TypeExtensions_DynamicMethod_Convience
	{
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
			
		static public T CreateDynamicMethodDelegate<T>(this Type item, string name, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(name, (Delegate)operation);
        }
        static public T CreateDynamicMethodDelegate<T>(this Type item, Operation<ILStatement, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue, ILValue> operation)
        {
            return item.CreateDynamicMethodDelegate<T>(typeof(T).Name, operation);
        }
		}
}