using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
	static public class TypeExtensions_ConstructorInfo
	{
		static private OperationCache<List<ConstructorInfo>, Type> GET_NATIVE_INSTANCE_CONSTRUCTORS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
				.ToList();
		});
		static public IEnumerable<ConstructorInfo> GetNativeInstanceConstructors(this Type item)
		{
			return GET_NATIVE_INSTANCE_CONSTRUCTORS.Fetch(item);
		}

		static private OperationCache<List<ConstructorInfoEX>, Type> GET_INSTANCE_CONSTRUCTORS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetNativeInstanceConstructors()
				.Convert(c => c.GetConstructorInfoEX())
				.ToList();
		});
		static public IEnumerable<ConstructorInfoEX> GetInstanceConstructors(this Type item)
		{
			return GET_INSTANCE_CONSTRUCTORS.Fetch(item);
		}

		static private OperationCache<ConstructorInfoEX, Type, ContentsEnumerable<Type>> GET_INSTANCE_CONSTRUCTOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, ContentsEnumerable<Type> parameter_types){
			return item.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, parameter_types.ToArray(), null)
				.GetConstructorInfoEX();
		});
		static public ConstructorInfoEX GetInstanceConstructor(this Type item, IEnumerable<Type> parameter_types)
		{
			return GET_INSTANCE_CONSTRUCTOR.Fetch(item, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public ConstructorInfoEX GetInstanceConstructor(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4, P5>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4, P5, P6>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public ConstructorInfoEX GetInstanceConstructor<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item)
			{
				return item.GetInstanceConstructor(new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
			}
}