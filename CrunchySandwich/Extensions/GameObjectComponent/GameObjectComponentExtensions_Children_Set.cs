using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Children_Set
    {
	
		static public void SetChildren(this GameObject item, IEnumerable<GameObject> children)
		{
			item.DestroyChildren();
			item.AddChildren(children);
		}
		static public void SetChildren(this GameObject item, params GameObject[] children)
		{
			item.SetChildren((IEnumerable<GameObject>)children);
		}

		static public void SetChildren<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			item.DestroyChildren();
			item.AddChildren(children);
		}
		static public void SetChildren<T>(this GameObject item, params T[] children) where T : Component
		{
			item.SetChildren((IEnumerable<T>)children);
		}

	
		static public void SetChildrenAtSelf(this GameObject item, IEnumerable<GameObject> children)
		{
			item.DestroyChildren();
			item.AddChildrenAtSelf(children);
		}
		static public void SetChildrenAtSelf(this GameObject item, params GameObject[] children)
		{
			item.SetChildrenAtSelf((IEnumerable<GameObject>)children);
		}

		static public void SetChildrenAtSelf<T>(this GameObject item, IEnumerable<T> children) where T : Component
		{
			item.DestroyChildren();
			item.AddChildrenAtSelf(children);
		}
		static public void SetChildrenAtSelf<T>(this GameObject item, params T[] children) where T : Component
		{
			item.SetChildrenAtSelf((IEnumerable<T>)children);
		}

		
		static public void SetChildren(this Component item, IEnumerable<GameObject> children)
		{
			item.DestroyChildren();
			item.AddChildren(children);
		}
		static public void SetChildren(this Component item, params GameObject[] children)
		{
			item.SetChildren((IEnumerable<GameObject>)children);
		}

		static public void SetChildren<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			item.DestroyChildren();
			item.AddChildren(children);
		}
		static public void SetChildren<T>(this Component item, params T[] children) where T : Component
		{
			item.SetChildren((IEnumerable<T>)children);
		}

	
		static public void SetChildrenAtSelf(this Component item, IEnumerable<GameObject> children)
		{
			item.DestroyChildren();
			item.AddChildrenAtSelf(children);
		}
		static public void SetChildrenAtSelf(this Component item, params GameObject[] children)
		{
			item.SetChildrenAtSelf((IEnumerable<GameObject>)children);
		}

		static public void SetChildrenAtSelf<T>(this Component item, IEnumerable<T> children) where T : Component
		{
			item.DestroyChildren();
			item.AddChildrenAtSelf(children);
		}
		static public void SetChildrenAtSelf<T>(this Component item, params T[] children) where T : Component
		{
			item.SetChildrenAtSelf((IEnumerable<T>)children);
		}

		}
}