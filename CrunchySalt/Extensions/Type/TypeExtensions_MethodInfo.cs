using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_MethodInfo
	{
	
		static private OperationCache<List<MethodInfo>, Type> GET_IMMEDIATE_NATIVE_TechnicalMember_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_TechnicalMember_METHODS", delegate(Type item){
			return item.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetImmediateNativeTechnicalMemberMethods(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_TechnicalMember_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfo>, Type> GET_NATIVE_TechnicalMember_METHODS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_TechnicalMember_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeTechnicalMemberMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetNativeTechnicalMemberMethods(this Type item)
		{
			//return GET_NATIVE_TechnicalMember_METHODS.Fetch(item);

			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeTechnicalMemberMethods());
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_IMMEDIATE_TechnicalMember_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_TechnicalMember_METHODS", delegate(Type item){
			return item.GetImmediateNativeTechnicalMemberMethods()
				.Convert(m => m.GetMethodInfoEX())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetImmediateTechnicalMemberMethods(this Type item)
		{
			return GET_IMMEDIATE_TechnicalMember_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_TechnicalMember_METHODS = ReflectionCache.Get().NewOperationCache("GET_TechnicalMember_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateTechnicalMemberMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetTechnicalMemberMethods(this Type item)
		{
			return GET_TechnicalMember_METHODS.Fetch(item);
		}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_IMMEDIATE_TechnicalMember_METHOD = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_TechnicalMember_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly, null, parameter_types.ToArray(), null)
				.GetMethodInfoEX();
		});
		static public MethodInfoEX GetImmediateTechnicalMemberMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_IMMEDIATE_TechnicalMember_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetImmediateTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_TechnicalMember_METHOD = ReflectionCache.Get().NewOperationCache("GET_TechnicalMember_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateTechnicalMemberMethod(name, parameter_types))
				.GetFirstNonNull();
		});
		static public MethodInfoEX GetTechnicalMemberMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_TechnicalMember_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetTechnicalMemberMethod(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetTechnicalMemberMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetTechnicalMemberMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
			
		static private OperationCache<List<MethodInfo>, Type> GET_IMMEDIATE_NATIVE_TechnicalInstance_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_TechnicalInstance_METHODS", delegate(Type item){
			return item.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetImmediateNativeTechnicalInstanceMethods(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_TechnicalInstance_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfo>, Type> GET_NATIVE_TechnicalInstance_METHODS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_TechnicalInstance_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeTechnicalInstanceMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetNativeTechnicalInstanceMethods(this Type item)
		{
			//return GET_NATIVE_TechnicalInstance_METHODS.Fetch(item);

			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeTechnicalInstanceMethods());
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_IMMEDIATE_TechnicalInstance_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_TechnicalInstance_METHODS", delegate(Type item){
			return item.GetImmediateNativeTechnicalInstanceMethods()
				.Convert(m => m.GetMethodInfoEX())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetImmediateTechnicalInstanceMethods(this Type item)
		{
			return GET_IMMEDIATE_TechnicalInstance_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_TechnicalInstance_METHODS = ReflectionCache.Get().NewOperationCache("GET_TechnicalInstance_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateTechnicalInstanceMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetTechnicalInstanceMethods(this Type item)
		{
			return GET_TechnicalInstance_METHODS.Fetch(item);
		}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_IMMEDIATE_TechnicalInstance_METHOD = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_TechnicalInstance_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly, null, parameter_types.ToArray(), null)
				.GetMethodInfoEX();
		});
		static public MethodInfoEX GetImmediateTechnicalInstanceMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_IMMEDIATE_TechnicalInstance_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetImmediateTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetImmediateTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_TechnicalInstance_METHOD = ReflectionCache.Get().NewOperationCache("GET_TechnicalInstance_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateTechnicalInstanceMethod(name, parameter_types))
				.GetFirstNonNull();
		});
		static public MethodInfoEX GetTechnicalInstanceMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_TechnicalInstance_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetTechnicalInstanceMethod(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetTechnicalInstanceMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetTechnicalInstanceMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
			
		static private OperationCache<List<MethodInfo>, Type> GET_IMMEDIATE_NATIVE_Static_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Static_METHODS", delegate(Type item){
			return item.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetImmediateNativeStaticMethods(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Static_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfo>, Type> GET_NATIVE_Static_METHODS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Static_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeStaticMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfo> GetNativeStaticMethods(this Type item)
		{
			//return GET_NATIVE_Static_METHODS.Fetch(item);

			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeStaticMethods());
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_IMMEDIATE_Static_METHODS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_METHODS", delegate(Type item){
			return item.GetImmediateNativeStaticMethods()
				.Convert(m => m.GetMethodInfoEX())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetImmediateStaticMethods(this Type item)
		{
			return GET_IMMEDIATE_Static_METHODS.Fetch(item);
		}

		static private OperationCache<List<MethodInfoEX>, Type> GET_Static_METHODS = ReflectionCache.Get().NewOperationCache("GET_Static_METHODS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticMethods())
				.ToList();
		});
		static public IEnumerable<MethodInfoEX> GetStaticMethods(this Type item)
		{
			return GET_Static_METHODS.Fetch(item);
		}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_IMMEDIATE_Static_METHOD = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly, null, parameter_types.ToArray(), null)
				.GetMethodInfoEX();
		});
		static public MethodInfoEX GetImmediateStaticMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_IMMEDIATE_Static_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetImmediateStaticMethod(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetImmediateStaticMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetImmediateStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
		
		static private OperationCache<MethodInfoEX, Type, string, ContentsEnumerable<Type>> GET_Static_METHOD = ReflectionCache.Get().NewOperationCache("GET_Static_METHOD", delegate(Type item, string name, ContentsEnumerable<Type> parameter_types){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticMethod(name, parameter_types))
				.GetFirstNonNull();
		});
		static public MethodInfoEX GetStaticMethod(this Type item, string name, IEnumerable<Type> parameter_types)
		{
			return GET_Static_METHOD.Fetch(item, name, new ContentsEnumerable<Type>(parameter_types));
		}

		
			static public MethodInfoEX GetStaticMethod(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{});
			}
		
			static public MethodInfoEX GetStaticMethod<P1>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4, P5>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4, P5, P6>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4, P5, P6, P7>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4, P5, P6, P7, P8>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8)});
			}
		
			static public MethodInfoEX GetStaticMethod<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this Type item, string name)
			{
				return item.GetStaticMethod(name, new Type[]{typeof(P1), typeof(P2), typeof(P3), typeof(P4), typeof(P5), typeof(P6), typeof(P7), typeof(P8), typeof(P9)});
			}
				}
}
