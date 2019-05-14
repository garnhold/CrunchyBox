using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
	static public class TypeExtensions_FieldInfo
	{
	
		static private OperationCache<List<FieldInfoEX>, Type> GET_IMMEDIATE_Member_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetImmediateMemberFields(this Type item)
		{
			return GET_IMMEDIATE_Member_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfoEX>, Type> GET_Member_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateMemberFields())
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
	
		static private OperationCache<List<FieldInfoEX>, Type> GET_IMMEDIATE_Instance_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetImmediateInstanceFields(this Type item)
		{
			return GET_IMMEDIATE_Instance_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfoEX>, Type> GET_Instance_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateInstanceFields())
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
	
		static private OperationCache<List<FieldInfoEX>, Type> GET_IMMEDIATE_Static_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.Convert(f => f.GetFieldInfoEX())
				.ToList();
		});
		static public IEnumerable<FieldInfoEX> GetImmediateStaticFields(this Type item)
		{
			return GET_IMMEDIATE_Static_FIELDS.Fetch(item);
		}

		static private OperationCache<List<FieldInfoEX>, Type> GET_Static_FIELDS = ReflectionCache.Get().NewOperationCache(delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(f => f.GetImmediateStaticFields())
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
