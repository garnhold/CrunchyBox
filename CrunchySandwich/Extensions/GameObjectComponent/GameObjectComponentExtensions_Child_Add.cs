using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Child_Add
    {
			static public GameObject AddChild(this GameObject item, GameObject child)
        {
            item.transform.AddChild(child.transform);
            return child;
        }

        static public T AddChild<T>(this GameObject item, T child) where T : Component
        {
            item.AddChild(child.gameObject);
            return child;
        }

		static public void AddChildren(this GameObject item, IEnumerable<GameObject> children)
		{
			children.Process(c => item.AddChild(c));
		}

		static public void AddChildren<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			children.Process(c => item.AddChild(c));
		}
			static public GameObject AddChildAtSelf(this GameObject item, GameObject child)
        {
            item.transform.AddChildAtSelf(child.transform);
            return child;
        }

        static public T AddChildAtSelf<T>(this GameObject item, T child) where T : Component
        {
            item.AddChildAtSelf(child.gameObject);
            return child;
        }

		static public void AddChildrenAtSelf(this GameObject item, IEnumerable<GameObject> children)
		{
			children.Process(c => item.AddChildAtSelf(c));
		}

		static public void AddChildrenAtSelf<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			children.Process(c => item.AddChildAtSelf(c));
		}
				static public GameObject AddChild(this Component item, GameObject child)
        {
            item.transform.AddChild(child.transform);
            return child;
        }

        static public T AddChild<T>(this Component item, T child) where T : Component
        {
            item.AddChild(child.gameObject);
            return child;
        }

		static public void AddChildren(this Component item, IEnumerable<GameObject> children)
		{
			children.Process(c => item.AddChild(c));
		}

		static public void AddChildren<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			children.Process(c => item.AddChild(c));
		}
			static public GameObject AddChildAtSelf(this Component item, GameObject child)
        {
            item.transform.AddChildAtSelf(child.transform);
            return child;
        }

        static public T AddChildAtSelf<T>(this Component item, T child) where T : Component
        {
            item.AddChildAtSelf(child.gameObject);
            return child;
        }

		static public void AddChildrenAtSelf(this Component item, IEnumerable<GameObject> children)
		{
			children.Process(c => item.AddChildAtSelf(c));
		}

		static public void AddChildrenAtSelf<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			children.Process(c => item.AddChildAtSelf(c));
		}
		}
}