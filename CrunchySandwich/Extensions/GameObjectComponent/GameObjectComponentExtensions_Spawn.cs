using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Spawn
    {
			static public GameObject SpawnChild(this GameObject item, GameObject prefab)
        {
            return item.AddChild(prefab.SpawnInstance());
        }

		static public T SpawnChild<T>(this GameObject item, T prefab) where T : Component
		{
			return item.AddChild(prefab.SpawnInstance());
		}

		static public GameObject SpawnEmptyChild(this GameObject item)
		{
			return item.AddChild(new GameObject());
		}

		static public T SpawnSingleComponentChild<T>(this GameObject item) where T : Component
		{
			return item.SpawnEmptyChild().AddComponent<T>();
		}
			static public GameObject SpawnChildAtSelf(this GameObject item, GameObject prefab)
        {
            return item.AddChildAtSelf(prefab.SpawnInstance());
        }

		static public T SpawnChildAtSelf<T>(this GameObject item, T prefab) where T : Component
		{
			return item.AddChildAtSelf(prefab.SpawnInstance());
		}

		static public GameObject SpawnEmptyChildAtSelf(this GameObject item)
		{
			return item.AddChildAtSelf(new GameObject());
		}

		static public T SpawnSingleComponentChildAtSelf<T>(this GameObject item) where T : Component
		{
			return item.SpawnEmptyChildAtSelf().AddComponent<T>();
		}
				static public GameObject SpawnChild(this Component item, GameObject prefab)
        {
            return item.AddChild(prefab.SpawnInstance());
        }

		static public T SpawnChild<T>(this Component item, T prefab) where T : Component
		{
			return item.AddChild(prefab.SpawnInstance());
		}

		static public GameObject SpawnEmptyChild(this Component item)
		{
			return item.AddChild(new GameObject());
		}

		static public T SpawnSingleComponentChild<T>(this Component item) where T : Component
		{
			return item.SpawnEmptyChild().AddComponent<T>();
		}
			static public GameObject SpawnChildAtSelf(this Component item, GameObject prefab)
        {
            return item.AddChildAtSelf(prefab.SpawnInstance());
        }

		static public T SpawnChildAtSelf<T>(this Component item, T prefab) where T : Component
		{
			return item.AddChildAtSelf(prefab.SpawnInstance());
		}

		static public GameObject SpawnEmptyChildAtSelf(this Component item)
		{
			return item.AddChildAtSelf(new GameObject());
		}

		static public T SpawnSingleComponentChildAtSelf<T>(this Component item) where T : Component
		{
			return item.SpawnEmptyChildAtSelf().AddComponent<T>();
		}
		}
}