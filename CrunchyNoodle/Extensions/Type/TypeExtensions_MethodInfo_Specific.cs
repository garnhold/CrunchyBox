using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
	static public class TypeExtensions_MethodInfo_Specific
	{
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_INSTANCE_METHOD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetFilteredInstanceMethods(
                Filterer_MethodInfo.IsNamed(name),
                Filterer_MethodInfo.CanEffectiveParametersHold(parameter_types)
            ).GetFirst();
		});
		static public MethodInfoEX GetInstanceMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_INSTANCE_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetInstanceMethod(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
			}
}