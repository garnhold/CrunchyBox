using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeExtensions_EventInfo
	{
	
		static private OperationCache<List<EventInfo>, Type> GET_IMMEDIATE_NATIVE_Member_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Member_EVENTS", delegate(Type item){
			return item.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<EventInfo> GetImmediateNativeMemberEvents(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Member_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfo>, Type> GET_NATIVE_Member_EVENTS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Member_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeMemberEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfo> GetNativeMemberEvents(this Type item)
		{
			return GET_NATIVE_Member_EVENTS.Fetch(item);
		}
		
		static private OperationCache<List<EventInfoEX>, Type> GET_IMMEDIATE_Member_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Member_EVENTS", delegate(Type item){
			return item.GetImmediateNativeMemberEvents()
				.Convert(f => f.GetEventInfoEX())
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetImmediateMemberEvents(this Type item)
		{
			return GET_IMMEDIATE_Member_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfoEX>, Type> GET_Member_EVENTS = ReflectionCache.Get().NewOperationCache("GET_Member_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateMemberEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetMemberEvents(this Type item)
		{
			return GET_Member_EVENTS.Fetch(item);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_IMMEDIATE_Member_EVENT = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Member_EVENT", delegate(Type item, string name){
			return item.GetEvent(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetEventInfoEX();
		});
		static public EventInfoEX GetImmediateMemberEvent(this Type item, string name)
		{
			return GET_IMMEDIATE_Member_EVENT.Fetch(item, name);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_Member_EVENT = ReflectionCache.Get().NewOperationCache("GET_Member_EVENT", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateMemberEvent(name))
				.GetFirstNonNull();
		});
		static public EventInfoEX GetMemberEvent(this Type item, string name)
		{
			return GET_Member_EVENT.Fetch(item, name);
		}
	
		static private OperationCache<List<EventInfo>, Type> GET_IMMEDIATE_NATIVE_Instance_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Instance_EVENTS", delegate(Type item){
			return item.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<EventInfo> GetImmediateNativeInstanceEvents(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Instance_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfo>, Type> GET_NATIVE_Instance_EVENTS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Instance_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeInstanceEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfo> GetNativeInstanceEvents(this Type item)
		{
			return GET_NATIVE_Instance_EVENTS.Fetch(item);
		}
		
		static private OperationCache<List<EventInfoEX>, Type> GET_IMMEDIATE_Instance_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Instance_EVENTS", delegate(Type item){
			return item.GetImmediateNativeInstanceEvents()
				.Convert(f => f.GetEventInfoEX())
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetImmediateInstanceEvents(this Type item)
		{
			return GET_IMMEDIATE_Instance_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfoEX>, Type> GET_Instance_EVENTS = ReflectionCache.Get().NewOperationCache("GET_Instance_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateInstanceEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetInstanceEvents(this Type item)
		{
			return GET_Instance_EVENTS.Fetch(item);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_IMMEDIATE_Instance_EVENT = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Instance_EVENT", delegate(Type item, string name){
			return item.GetEvent(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.GetEventInfoEX();
		});
		static public EventInfoEX GetImmediateInstanceEvent(this Type item, string name)
		{
			return GET_IMMEDIATE_Instance_EVENT.Fetch(item, name);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_Instance_EVENT = ReflectionCache.Get().NewOperationCache("GET_Instance_EVENT", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateInstanceEvent(name))
				.GetFirstNonNull();
		});
		static public EventInfoEX GetInstanceEvent(this Type item, string name)
		{
			return GET_Instance_EVENT.Fetch(item, name);
		}
	
		static private OperationCache<List<EventInfo>, Type> GET_IMMEDIATE_NATIVE_Static_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_NATIVE_Static_EVENTS", delegate(Type item){
			return item.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.ToList();
		});
		static public IEnumerable<EventInfo> GetImmediateNativeStaticEvents(this Type item)
		{
			return GET_IMMEDIATE_NATIVE_Static_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfo>, Type> GET_NATIVE_Static_EVENTS = ReflectionCache.Get().NewOperationCache("GET_NATIVE_Static_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateNativeStaticEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfo> GetNativeStaticEvents(this Type item)
		{
			return GET_NATIVE_Static_EVENTS.Fetch(item);
		}
		
		static private OperationCache<List<EventInfoEX>, Type> GET_IMMEDIATE_Static_EVENTS = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_EVENTS", delegate(Type item){
			return item.GetImmediateNativeStaticEvents()
				.Convert(f => f.GetEventInfoEX())
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetImmediateStaticEvents(this Type item)
		{
			return GET_IMMEDIATE_Static_EVENTS.Fetch(item);
		}

		static private OperationCache<List<EventInfoEX>, Type> GET_Static_EVENTS = ReflectionCache.Get().NewOperationCache("GET_Static_EVENTS", delegate(Type item){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticEvents())
                .Flatten()
				.ToList();
		});
		static public IEnumerable<EventInfoEX> GetStaticEvents(this Type item)
		{
			return GET_Static_EVENTS.Fetch(item);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_IMMEDIATE_Static_EVENT = ReflectionCache.Get().NewOperationCache("GET_IMMEDIATE_Static_EVENT", delegate(Type item, string name){
			return item.GetEvent(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly)
				.GetEventInfoEX();
		});
		static public EventInfoEX GetImmediateStaticEvent(this Type item, string name)
		{
			return GET_IMMEDIATE_Static_EVENT.Fetch(item, name);
		}

		static private OperationCache<EventInfoEX, Type, string> GET_Static_EVENT = ReflectionCache.Get().NewOperationCache("GET_Static_EVENT", delegate(Type item, string name){
			return item.GetTypeAndAllBaseTypes()
				.Convert(t => t.GetImmediateStaticEvent(name))
				.GetFirstNonNull();
		});
		static public EventInfoEX GetStaticEvent(this Type item, string name)
		{
			return GET_Static_EVENT.Fetch(item, name);
		}
		}
}
