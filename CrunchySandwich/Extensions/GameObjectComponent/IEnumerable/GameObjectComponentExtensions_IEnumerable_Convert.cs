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
		static public IEnumerable<T> ConvertComponent<J, T>(this IEnumerable<J> item) where J : Component where T : Component
        {
            return item.Convert(c => c.GetComponent<T>()).SkipNull();
        }

		static public IEnumerable<T> ConvertComponentUpward<J, T>(this IEnumerable<J> item) where J : Component where T : Component
		{
			return item.Convert(c => c.GetComponentUpward<T>()).SkipNull();
		}

		static public IEnumerable<T> ConvertComponent<T>(this IEnumerable<GameObject> item)
        {
            return item.Convert(c => c.GetComponent<T>()).SkipNull();
        }

		static public IEnumerable<T> ConvertComponentUpward<T>(this IEnumerable<GameObject> item)
		{
			return item.Convert(c => c.GetComponentUpward<T>()).SkipNull();
		}

		static public T GetFirstComponent<T>(this IEnumerable<GameObject> item)
        {
            return item.ConvertComponent<T>().GetFirst();
        }

		static public IEnumerable<T> ConvertComponent<T>(this IEnumerable<Component> item)
        {
            return item.Convert(c => c.GetComponent<T>()).SkipNull();
        }

		static public IEnumerable<T> ConvertComponentUpward<T>(this IEnumerable<Component> item)
		{
			return item.Convert(c => c.GetComponentUpward<T>()).SkipNull();
		}

		static public T GetFirstComponent<T>(this IEnumerable<Component> item)
        {
            return item.ConvertComponent<T>().GetFirst();
        }

	}
}