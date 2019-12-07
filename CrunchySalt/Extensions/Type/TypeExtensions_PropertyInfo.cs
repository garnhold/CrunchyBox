using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_PropertyInfo
	{
	
		static private OperationCache<List<PropertyInfo>, Type> GET_IMMEDIATE_NATIVE_Member_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Member_PROPERTYS", delegate(Type item){
			return item.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetImmediateNativeMemberPropertys(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Member_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfo>, Type> GET_NATIVE_Member_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Member_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeMemberPropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetNativeMemberPropertys(this Type item)
		{
			return GET_NATIVE_Member_PROPERTYS.Fetch(item);
		}
		
		static private OperationCache<List<PropertyInfoEX>, Type> GET_IMMEDIATE_Member_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Member_PROPERTYS", delegate(Type item){
			return item.GetImmediateNativeMemberPropertys()
				.Convert(f => f.GetPropertyInfoEX())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetImmediateMemberPropertys(this Type item)
		{
			return GET_IMMEDIATE_Member_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfoEX>, Type> GET_Member_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_Member_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateMemberPropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetMemberPropertys(this Type item)
		{
			return GET_Member_PROPERTYS.Fetch(item);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_IMMEDIATE_Member_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Member_PROPERTY", delegate(Type item, string name){
			return item.GetProperty(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetPropertyInfoEX();
		});
		static public PropertyInfoEX GetImmediateMemberProperty(this Type item, string name)
		{
			return GET_IMMEDIATE_Member_PROPERTY.Fetch(item, name);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_Member_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_Member_PROPERTY", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateMemberProperty(name))
				.GetFirstNonNull();
		});
		static public PropertyInfoEX GetMemberProperty(this Type item, string name)
		{
			return GET_Member_PROPERTY.Fetch(item, name);
		}
	
		static private OperationCache<List<PropertyInfo>, Type> GET_IMMEDIATE_NATIVE_Instance_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Instance_PROPERTYS", delegate(Type item){
			return item.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetImmediateNativeInstancePropertys(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Instance_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfo>, Type> GET_NATIVE_Instance_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Instance_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeInstancePropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetNativeInstancePropertys(this Type item)
		{
			return GET_NATIVE_Instance_PROPERTYS.Fetch(item);
		}
		
		static private OperationCache<List<PropertyInfoEX>, Type> GET_IMMEDIATE_Instance_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Instance_PROPERTYS", delegate(Type item){
			return item.GetImmediateNativeInstancePropertys()
				.Convert(f => f.GetPropertyInfoEX())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetImmediateInstancePropertys(this Type item)
		{
			return GET_IMMEDIATE_Instance_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfoEX>, Type> GET_Instance_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_Instance_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateInstancePropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetInstancePropertys(this Type item)
		{
			return GET_Instance_PROPERTYS.Fetch(item);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_IMMEDIATE_Instance_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Instance_PROPERTY", delegate(Type item, string name){
			return item.GetProperty(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetPropertyInfoEX();
		});
		static public PropertyInfoEX GetImmediateInstanceProperty(this Type item, string name)
		{
			return GET_IMMEDIATE_Instance_PROPERTY.Fetch(item, name);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_Instance_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_Instance_PROPERTY", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateInstanceProperty(name))
				.GetFirstNonNull();
		});
		static public PropertyInfoEX GetInstanceProperty(this Type item, string name)
		{
			return GET_Instance_PROPERTY.Fetch(item, name);
		}
	
		static private OperationCache<List<PropertyInfo>, Type> GET_IMMEDIATE_NATIVE_Static_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Static_PROPERTYS", delegate(Type item){
			return item.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetImmediateNativeStaticPropertys(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Static_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfo>, Type> GET_NATIVE_Static_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Static_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeStaticPropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfo> GetNativeStaticPropertys(this Type item)
		{
			return GET_NATIVE_Static_PROPERTYS.Fetch(item);
		}
		
		static private OperationCache<List<PropertyInfoEX>, Type> GET_IMMEDIATE_Static_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_PROPERTYS", delegate(Type item){
			return item.GetImmediateNativeStaticPropertys()
				.Convert(f => f.GetPropertyInfoEX())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetImmediateStaticPropertys(this Type item)
		{
			return GET_IMMEDIATE_Static_PROPERTYS.Fetch(item);
		}

		static private OperationCache<List<PropertyInfoEX>, Type> GET_Static_PROPERTYS = ReflectionCache.Get().NewOperationCache("GET_Static_PROPERTYS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticPropertys())
				.ToList();
		});
		static public IEnumerable<PropertyInfoEX> GetStaticPropertys(this Type item)
		{
			return GET_Static_PROPERTYS.Fetch(item);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_IMMEDIATE_Static_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_PROPERTY", delegate(Type item, string name){
			return item.GetProperty(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.GetPropertyInfoEX();
		});
		static public PropertyInfoEX GetImmediateStaticProperty(this Type item, string name)
		{
			return GET_IMMEDIATE_Static_PROPERTY.Fetch(item, name);
		}

		static private OperationCache<PropertyInfoEX, Type, string> GET_Static_PROPERTY = ReflectionCache.Get().NewOperationCache("GET_Static_PROPERTY", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticProperty(name))
				.GetFirstNonNull();
		});
		static public PropertyInfoEX GetStaticProperty(this Type item, string name)
		{
			return GET_Static_PROPERTY.Fetch(item, name);
		}
		}
}
