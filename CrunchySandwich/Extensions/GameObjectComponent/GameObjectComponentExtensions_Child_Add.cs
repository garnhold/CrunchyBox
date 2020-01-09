using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Child_Add
    {
			static public GameObject AddChild(this GameObject item, GameObject child)
        {
            item.transform.AddChild(child.IfNotNull(c => c.transform));
            return child;
        }

        static public T AddChild<T>(this GameObject item, T child) where T : Component
        {
            item.AddChild(child.IfNotNull(c => c.gameObject));
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
            item.transform.AddChildAtSelf(child.IfNotNull(c => c.transform));
            return child;
        }

        static public T AddChildAtSelf<T>(this GameObject item, T child) where T : Component
        {
            item.AddChildAtSelf(child.IfNotNull(c => c.gameObject));
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
            item.transform.AddChild(child.IfNotNull(c => c.transform));
            return child;
        }

        static public T AddChild<T>(this Component item, T child) where T : Component
        {
            item.AddChild(child.IfNotNull(c => c.gameObject));
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
            item.transform.AddChildAtSelf(child.IfNotNull(c => c.transform));
            return child;
        }

        static public T AddChildAtSelf<T>(this Component item, T child) where T : Component
        {
            item.AddChildAtSelf(child.IfNotNull(c => c.gameObject));
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