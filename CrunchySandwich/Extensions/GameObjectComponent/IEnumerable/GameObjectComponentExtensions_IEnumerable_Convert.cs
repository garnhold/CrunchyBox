using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_IEnumerable_Convert
    {
		static public IEnumerable<Component> ConvertComponent<T>(this IEnumerable<T> item, Type component_type) where T : Component
		{
			return item.Convert(c => c.GetComponent(component_type)).SkipNull();
		}
		static public IEnumerable<J> ConvertComponent<T, J>(this IEnumerable<T> item) where T : Component
        {
            return item.ConvertComponent(typeof(J)).Convert<Component, J>();
        }

		static public IEnumerable<Component> ConvertComponentUpward<T>(this IEnumerable<T> item, Type component_type) where T : Component
		{
			return item.Convert(c => c.GetComponentUpward(component_type)).SkipNull();
		}
		static public IEnumerable<J> ConvertComponentUpward<T, J>(this IEnumerable<T> item) where T : Component
		{
			return item.ConvertComponentUpward(typeof(J)).Convert<Component, J>();
		}

		static public IEnumerable<Component> ConvertComponent(this IEnumerable<GameObject> item, Type component_type)
        {
            return item.Convert(c => c.GetComponent(component_type)).SkipNull();
        }
		static public IEnumerable<T> ConvertComponent<T>(this IEnumerable<GameObject> item)
        {
            return item.ConvertComponent(typeof(T)).Convert<Component, T>();
        }

		static public IEnumerable<Component> ConvertComponentUpward(this IEnumerable<GameObject> item, Type component_type)
		{
			return item.Convert(c => c.GetComponentUpward(component_type)).SkipNull();
		}
		static public IEnumerable<T> ConvertComponentUpward<T>(this IEnumerable<GameObject> item)
		{
			return item.ConvertComponentUpward(typeof(T)).Convert<Component, T>();
		}

		static public Component GetFirstComponent(this IEnumerable<GameObject> item, Type component_type)
        {
            return item.ConvertComponent(component_type).GetFirst();
        }
		static public T GetFirstComponent<T>(this IEnumerable<GameObject> item)
        {
            return item.GetFirstComponent(typeof(T)).Convert<T>();
        }

		static public IEnumerable<Component> ConvertComponent(this IEnumerable<Component> item, Type component_type)
        {
            return item.Convert(c => c.GetComponent(component_type)).SkipNull();
        }
		static public IEnumerable<T> ConvertComponent<T>(this IEnumerable<Component> item)
        {
            return item.ConvertComponent(typeof(T)).Convert<Component, T>();
        }

		static public IEnumerable<Component> ConvertComponentUpward(this IEnumerable<Component> item, Type component_type)
		{
			return item.Convert(c => c.GetComponentUpward(component_type)).SkipNull();
		}
		static public IEnumerable<T> ConvertComponentUpward<T>(this IEnumerable<Component> item)
		{
			return item.ConvertComponentUpward(typeof(T)).Convert<Component, T>();
		}

		static public Component GetFirstComponent(this IEnumerable<Component> item, Type component_type)
        {
            return item.ConvertComponent(component_type).GetFirst();
        }
		static public T GetFirstComponent<T>(this IEnumerable<Component> item)
        {
            return item.GetFirstComponent(typeof(T)).Convert<T>();
        }

	}
}