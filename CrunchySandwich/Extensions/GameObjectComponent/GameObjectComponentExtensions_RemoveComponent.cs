using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_RemoveComponent
    {
        static public bool RemoveComponent(this GameObject item, Type type)
        {
            Component component = item.GetComponent(type);

			if(component.IsNotNull())
			{
				component.RemoveSelf();
				return true;
			}

            return false;
        }
		static public bool RemoveComponent<T>(this GameObject item)
		{
			return item.RemoveComponent(typeof(T));
		}

        static public bool RemoveComponent(this Component item, Type type)
        {
            Component component = item.GetComponent(type);

			if(component.IsNotNull())
			{
				component.RemoveSelf();
				return true;
			}

            return false;
        }
		static public bool RemoveComponent<T>(this Component item)
		{
			return item.RemoveComponent(typeof(T));
		}

	}
}