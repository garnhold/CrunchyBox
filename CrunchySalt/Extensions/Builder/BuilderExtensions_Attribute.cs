using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class BuilderExtensions_Attribute
	{
			static public void AddCustomAttribute(this AssemblyBuilder item, ConstructorInfo constructor_info, params object[] arguments)
        {
            item.SetCustomAttribute(new CustomAttributeBuilder(constructor_info.GetNativeConstructorInfo(), arguments));
        }

		
			static public void AddCustomAttribute<T>(this AssemblyBuilder item)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor());
			}
		
			static public void AddCustomAttribute<T, P1>(this AssemblyBuilder item, P1 p1)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1>(), p1);
			}
		
			static public void AddCustomAttribute<T, P1, P2>(this AssemblyBuilder item, P1 p1, P2 p2)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2>(), p1, p2);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3>(), p1, p2, p3);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4>(), p1, p2, p3, p4);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5>(), p1, p2, p3, p4, p5);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6>(), p1, p2, p3, p4, p5, p6);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7>(), p1, p2, p3, p4, p5, p6, p7);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8>(), p1, p2, p3, p4, p5, p6, p7, p8);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this AssemblyBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8, P9>(), p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
					static public void AddCustomAttribute(this ModuleBuilder item, ConstructorInfo constructor_info, params object[] arguments)
        {
            item.SetCustomAttribute(new CustomAttributeBuilder(constructor_info.GetNativeConstructorInfo(), arguments));
        }

		
			static public void AddCustomAttribute<T>(this ModuleBuilder item)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor());
			}
		
			static public void AddCustomAttribute<T, P1>(this ModuleBuilder item, P1 p1)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1>(), p1);
			}
		
			static public void AddCustomAttribute<T, P1, P2>(this ModuleBuilder item, P1 p1, P2 p2)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2>(), p1, p2);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3>(), p1, p2, p3);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4>(), p1, p2, p3, p4);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5>(), p1, p2, p3, p4, p5);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6>(), p1, p2, p3, p4, p5, p6);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7>(), p1, p2, p3, p4, p5, p6, p7);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8>(), p1, p2, p3, p4, p5, p6, p7, p8);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this ModuleBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8, P9>(), p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
					static public void AddCustomAttribute(this MethodBuilder item, ConstructorInfo constructor_info, params object[] arguments)
        {
            item.SetCustomAttribute(new CustomAttributeBuilder(constructor_info.GetNativeConstructorInfo(), arguments));
        }

		
			static public void AddCustomAttribute<T>(this MethodBuilder item)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor());
			}
		
			static public void AddCustomAttribute<T, P1>(this MethodBuilder item, P1 p1)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1>(), p1);
			}
		
			static public void AddCustomAttribute<T, P1, P2>(this MethodBuilder item, P1 p1, P2 p2)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2>(), p1, p2);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3>(this MethodBuilder item, P1 p1, P2 p2, P3 p3)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3>(), p1, p2, p3);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4>(), p1, p2, p3, p4);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5>(), p1, p2, p3, p4, p5);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6>(), p1, p2, p3, p4, p5, p6);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7>(), p1, p2, p3, p4, p5, p6, p7);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8>(), p1, p2, p3, p4, p5, p6, p7, p8);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this MethodBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8, P9>(), p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
					static public void AddCustomAttribute(this TypeBuilder item, ConstructorInfo constructor_info, params object[] arguments)
        {
            item.SetCustomAttribute(new CustomAttributeBuilder(constructor_info.GetNativeConstructorInfo(), arguments));
        }

		
			static public void AddCustomAttribute<T>(this TypeBuilder item)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor());
			}
		
			static public void AddCustomAttribute<T, P1>(this TypeBuilder item, P1 p1)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1>(), p1);
			}
		
			static public void AddCustomAttribute<T, P1, P2>(this TypeBuilder item, P1 p1, P2 p2)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2>(), p1, p2);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3>(this TypeBuilder item, P1 p1, P2 p2, P3 p3)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3>(), p1, p2, p3);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4>(), p1, p2, p3, p4);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5>(), p1, p2, p3, p4, p5);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6>(), p1, p2, p3, p4, p5, p6);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7>(), p1, p2, p3, p4, p5, p6, p7);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8>(), p1, p2, p3, p4, p5, p6, p7, p8);
			}
		
			static public void AddCustomAttribute<T, P1, P2, P3, P4, P5, P6, P7, P8, P9>(this TypeBuilder item, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9)
			{
				item.AddCustomAttribute(typeof(T).GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8, P9>(), p1, p2, p3, p4, p5, p6, p7, p8, p9);
			}
				}
}