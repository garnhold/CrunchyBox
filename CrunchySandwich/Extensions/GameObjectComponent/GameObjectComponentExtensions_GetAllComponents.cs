using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_GetAllComponents
    {
		static public IEnumerable<Component> GetAllComponents(this GameObject item)
		{
			return item.GetComponents<Component>();
		}

		static public IEnumerable<Component> GetAllComponents(this Component item)
		{
			return item.GetComponents<Component>();
		}

	}
}