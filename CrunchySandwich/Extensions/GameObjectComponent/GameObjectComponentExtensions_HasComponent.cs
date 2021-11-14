using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_HasComponent
    {
		static public bool HasComponent(this GameObject item, Type type)
        {
            if (item.GetComponent(type).IsNotNull())
                return true;

            return false;
        }
        static public bool HasComponent<T>(this GameObject item)
        {
            return item.HasComponent(typeof(T));
        }

		static public bool HasComponentUpward(this GameObject item, Type type)
		{
			if (item.GetComponentUpward(type).IsNotNull())
				return true;

			return false;
		}
		static public bool HasComponentUpward<T>(this GameObject item)
		{
			return item.HasComponentUpward(typeof(T));
		}

		static public bool HasComponent(this Component item, Type type)
        {
            if (item.GetComponent(type).IsNotNull())
                return true;

            return false;
        }
        static public bool HasComponent<T>(this Component item)
        {
            return item.HasComponent(typeof(T));
        }

		static public bool HasComponentUpward(this Component item, Type type)
		{
			if (item.GetComponentUpward(type).IsNotNull())
				return true;

			return false;
		}
		static public bool HasComponentUpward<T>(this Component item)
		{
			return item.HasComponentUpward(typeof(T));
		}

	}
}