﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_GetComponents
    {
		static public IEnumerable<Component> GetComponentsUpward(this GameObject item, Type type)
		{
			return item.GetComponentsInParent(type);
		}
		static public IEnumerable<T> GetComponentsUpward<T>(this GameObject item)
		{
			return item.GetComponentsUpward(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsUpwardFromParent(this GameObject item, Type type)
		{
			return item.GetParent().IfNotNull(p => p.GetComponentsUpward(type));
		}
		static public IEnumerable<T> GetComponentsUpwardFromParent<T>(this GameObject item)
		{
			return item.GetComponentsUpwardFromParent(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsDownward(this GameObject item, Type type)
		{
			return item.GetComponentsInChildren(type);
		}
		static public IEnumerable<T> GetComponentsDownward<T>(this GameObject item)
		{
			return item.GetComponentsDownward(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsDownwardFromChildren(this GameObject item, Type type)
		{
			return item.GetChildren()
                .Convert(c => c.GetComponentsDownward(type));
		}
		static public IEnumerable<T> GetComponentsDownwardFromChildren<T>(this GameObject item)
		{
			return item.GetComponentsDownwardFromChildren(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsUpward(this Component item, Type type)
		{
			return item.GetComponentsInParent(type);
		}
		static public IEnumerable<T> GetComponentsUpward<T>(this Component item)
		{
			return item.GetComponentsUpward(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsUpwardFromParent(this Component item, Type type)
		{
			return item.GetParent().IfNotNull(p => p.GetComponentsUpward(type));
		}
		static public IEnumerable<T> GetComponentsUpwardFromParent<T>(this Component item)
		{
			return item.GetComponentsUpwardFromParent(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsDownward(this Component item, Type type)
		{
			return item.GetComponentsInChildren(type);
		}
		static public IEnumerable<T> GetComponentsDownward<T>(this Component item)
		{
			return item.GetComponentsDownward(typeof(T)).Convert<Component, T>();
		}

		static public IEnumerable<Component> GetComponentsDownwardFromChildren(this Component item, Type type)
		{
			return item.GetChildren()
                .Convert(c => c.GetComponentsDownward(type));
		}
		static public IEnumerable<T> GetComponentsDownwardFromChildren<T>(this Component item)
		{
			return item.GetComponentsDownwardFromChildren(typeof(T)).Convert<Component, T>();
		}

	}
}