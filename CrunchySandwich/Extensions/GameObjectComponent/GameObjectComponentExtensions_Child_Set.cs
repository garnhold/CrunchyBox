using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Child_Set
    {
		static public T SetChild<T>(this GameObject item, T child) where T : Component
		{
			item.SetChildren(child);
			
			return child;
		}

		static public T SetChild<T>(this Component item, T child) where T : Component
		{
			item.SetChildren(child);
			
			return child;
		}

	}
}