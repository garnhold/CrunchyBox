using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_GetComponent
    {
		static public Component GetComponentUpward(this GameObject item, Type type)
		{
			return item.GetComponentInParent(type);
		}
		static public T GetComponentUpward<T>(this GameObject item)
		{
			return item.GetComponentUpward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentUpwardFromParent(this GameObject item, Type type)
		{
			return item.GetParent().IfNotNull(p => p.GetComponentUpward(type));
		}
		static public T GetComponentUpwardFromParent<T>(this GameObject item)
		{
			return item.GetComponentUpwardFromParent(typeof(T)).Convert<T>();
		}

		static public Component GetComponentDownward(this GameObject item, Type type)
		{
			return item.GetComponentInChildren(type);
		}
		static public T GetComponentDownward<T>(this GameObject item)
		{
			return item.GetComponentDownward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentDownwardFromChildren(this GameObject item, Type type)
		{
			return item.GetChildren()
                .Convert(c => c.GetComponentDownward(type))
                .GetFirstNonNull();
		}
		static public T GetComponentDownwardFromChildren<T>(this GameObject item)
		{
			return item.GetComponentDownwardFromChildren(typeof(T)).Convert<T>();
		}

		static public Component GetComponentUpwardOrDownward(this GameObject item, Type type)
		{
			return item.GetComponentUpward(type) ?? item.GetComponentDownward(type);
		}
		static public T GetComponentUpwardOrDownward<T>(this GameObject item)
		{
			return item.GetComponentUpwardOrDownward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentWithinEntity(this GameObject item, Type type)
		{
			return item.GetRoot().GetComponentDownward(type);
		}
		static public T GetComponentWithinEntity<T>(this GameObject item)
		{
			return item.GetComponentWithinEntity(typeof(T)).Convert<T>();
		}

		static public Component GetComponentEX(this GameObject item, Type type)
		{
			return item.IfNotNull(i => i.GetComponent(type));
		}
		static public T GetComponentEX<T>(this GameObject item)
		{
			return item.GetComponentEX(typeof(T)).Convert<T>();
		}

		static public Component GetComponentUpward(this Component item, Type type)
		{
			return item.GetComponentInParent(type);
		}
		static public T GetComponentUpward<T>(this Component item)
		{
			return item.GetComponentUpward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentUpwardFromParent(this Component item, Type type)
		{
			return item.GetParent().IfNotNull(p => p.GetComponentUpward(type));
		}
		static public T GetComponentUpwardFromParent<T>(this Component item)
		{
			return item.GetComponentUpwardFromParent(typeof(T)).Convert<T>();
		}

		static public Component GetComponentDownward(this Component item, Type type)
		{
			return item.GetComponentInChildren(type);
		}
		static public T GetComponentDownward<T>(this Component item)
		{
			return item.GetComponentDownward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentDownwardFromChildren(this Component item, Type type)
		{
			return item.GetChildren()
                .Convert(c => c.GetComponentDownward(type))
                .GetFirstNonNull();
		}
		static public T GetComponentDownwardFromChildren<T>(this Component item)
		{
			return item.GetComponentDownwardFromChildren(typeof(T)).Convert<T>();
		}

		static public Component GetComponentUpwardOrDownward(this Component item, Type type)
		{
			return item.GetComponentUpward(type) ?? item.GetComponentDownward(type);
		}
		static public T GetComponentUpwardOrDownward<T>(this Component item)
		{
			return item.GetComponentUpwardOrDownward(typeof(T)).Convert<T>();
		}

		static public Component GetComponentWithinEntity(this Component item, Type type)
		{
			return item.GetRoot().GetComponentDownward(type);
		}
		static public T GetComponentWithinEntity<T>(this Component item)
		{
			return item.GetComponentWithinEntity(typeof(T)).Convert<T>();
		}

		static public Component GetComponentEX(this Component item, Type type)
		{
			return item.IfNotNull(i => i.GetComponent(type));
		}
		static public T GetComponentEX<T>(this Component item)
		{
			return item.GetComponentEX(typeof(T)).Convert<T>();
		}

	}
}