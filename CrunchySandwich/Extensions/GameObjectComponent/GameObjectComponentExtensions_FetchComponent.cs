using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_FetchComponent
    {
        static public Component FetchComponent(this GameObject item, Type type)
        {
            Component component = item.GetComponent(type);

			if(component.IsNull())
				component = item.AddComponent(type);

            return component;
        }
		static public T FetchComponent<T>(this GameObject item)
		{
			return item.FetchComponent(typeof(T)).Convert<T>();
		}

        static public Component FetchComponent(this Component item, Type type)
        {
            Component component = item.GetComponent(type);

			if(component.IsNull())
				component = item.AddComponent(type);

            return component;
        }
		static public T FetchComponent<T>(this Component item)
		{
			return item.FetchComponent(typeof(T)).Convert<T>();
		}

	}
}