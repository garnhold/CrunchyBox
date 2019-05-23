using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
	static public class TypeExtensions_FieldInfo
	{
	
		static private OperationCache<List<FieldInfo>, Type> GET_IMMEDIATE_NATIVE_Member_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetImmediateNativeMemberFields(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Member_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfo>, Type> GET_NATIVE_Member_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateNativeMemberFields())
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetNativeMemberFields(this Type item)
		{
			return GET_NATIVE_Member_FIELDS.Fetch(item);
		}
		
		static private OperationCache<List<FieldInfoEX>, Type> GET_Member_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetNativeMemberFields()
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetMemberFields(this Type item)
		{
			return GET_Member_FIELDS.Fetch(item);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_IMMEDIATE_Member_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetFieldInfoEX();
		});
		static public FieldInfoEX GetImmediateMemberField(this Type item, string name)
		{
			return GET_IMMEDIATE_Member_FIELD.Fetch(item, name);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_Member_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateMemberField(name))
				.GetFirstNonNull();
		});
		static public FieldInfoEX GetMemberField(this Type item, string name)
		{
			return GET_Member_FIELD.Fetch(item, name);
		}
	
		static private OperationCache<List<FieldInfo>, Type> GET_IMMEDIATE_NATIVE_Instance_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetImmediateNativeInstanceFields(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Instance_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfo>, Type> GET_NATIVE_Instance_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateNativeInstanceFields())
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetNativeInstanceFields(this Type item)
		{
			return GET_NATIVE_Instance_FIELDS.Fetch(item);
		}
		
		static private OperationCache<List<FieldInfoEX>, Type> GET_Instance_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetNativeInstanceFields()
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetInstanceFields(this Type item)
		{
			return GET_Instance_FIELDS.Fetch(item);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_IMMEDIATE_Instance_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetFieldInfoEX();
		});
		static public FieldInfoEX GetImmediateInstanceField(this Type item, string name)
		{
			return GET_IMMEDIATE_Instance_FIELD.Fetch(item, name);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_Instance_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateInstanceField(name))
				.GetFirstNonNull();
		});
		static public FieldInfoEX GetInstanceField(this Type item, string name)
		{
			return GET_Instance_FIELD.Fetch(item, name);
		}
	
		static private OperationCache<List<FieldInfo>, Type> GET_IMMEDIATE_NATIVE_Static_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetImmediateNativeStaticFields(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Static_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfo>, Type> GET_NATIVE_Static_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateNativeStaticFields())
				.ToList();
		});
		static public IEnumerable<FieldInfo> GetNativeStaticFields(this Type item)
		{
			return GET_NATIVE_Static_FIELDS.Fetch(item);
		}
		
		static private OperationCache<List<FieldInfoEX>, Type> GET_Static_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetNativeStaticFields()
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetStaticFields(this Type item)
		{
			return GET_Static_FIELDS.Fetch(item);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_IMMEDIATE_Static_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.GetFieldInfoEX();
		});
		static public FieldInfoEX GetImmediateStaticField(this Type item, string name)
		{
			return GET_IMMEDIATE_Static_FIELD.Fetch(item, name);
		}

		static private OperationCache<FieldInfoEX, Type, string> GET_Static_FIELD = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticField(name))
				.GetFirstNonNull();
		});
		static public FieldInfoEX GetStaticField(this Type item, string name)
		{
			return GET_Static_FIELD.Fetch(item, name);
		}
		}
}
