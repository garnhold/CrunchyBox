using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Child_Remove
    {
			static public bool RemoveChild(this GameObject item, GameObject child)
        {
            return item.transform.RemoveChild(child.transform);
        }

        static public bool RemoveChild<T>(this GameObject item, T child) where T : Component
        {
            return item.RemoveChild(child.gameObject);
        }

		static public int RemoveChildren(this GameObject item, IEnumerable<GameObject> children)
		{
			return children.Count(c => item.RemoveChild(c));
		}

		static public int RemoveChildren<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			return children.Count(c => item.RemoveChild(c));
		}
			static public bool RemoveChildAtSelf(this GameObject item, GameObject child)
        {
            return item.transform.RemoveChildAtSelf(child.transform);
        }

        static public bool RemoveChildAtSelf<T>(this GameObject item, T child) where T : Component
        {
            return item.RemoveChildAtSelf(child.gameObject);
        }

		static public int RemoveChildrenAtSelf(this GameObject item, IEnumerable<GameObject> children)
		{
			return children.Count(c => item.RemoveChildAtSelf(c));
		}

		static public int RemoveChildrenAtSelf<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			return children.Count(c => item.RemoveChildAtSelf(c));
		}
				static public bool RemoveChild(this Component item, GameObject child)
        {
            return item.transform.RemoveChild(child.transform);
        }

        static public bool RemoveChild<T>(this Component item, T child) where T : Component
        {
            return item.RemoveChild(child.gameObject);
        }

		static public int RemoveChildren(this Component item, IEnumerable<GameObject> children)
		{
			return children.Count(c => item.RemoveChild(c));
		}

		static public int RemoveChildren<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			return children.Count(c => item.RemoveChild(c));
		}
			static public bool RemoveChildAtSelf(this Component item, GameObject child)
        {
            return item.transform.RemoveChildAtSelf(child.transform);
        }

        static public bool RemoveChildAtSelf<T>(this Component item, T child) where T : Component
        {
            return item.RemoveChildAtSelf(child.gameObject);
        }

		static public int RemoveChildrenAtSelf(this Component item, IEnumerable<GameObject> children)
		{
			return children.Count(c => item.RemoveChildAtSelf(c));
		}

		static public int RemoveChildrenAtSelf<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			return children.Count(c => item.RemoveChildAtSelf(c));
		}
		}
}