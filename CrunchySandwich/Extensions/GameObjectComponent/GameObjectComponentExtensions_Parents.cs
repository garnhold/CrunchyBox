using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Parents
    {
		static public void ClearParent(this GameObject item)
		{
			item.SetParent((GameObject)null);
		}

		static public bool HasParent(this GameObject item)
        {
            if (item.GetParent().IsNotNull())
                return true;

            return false;
        }

		static public void SetParent(this GameObject item, GameObject parent)
		{
			item.transform.parent = parent.IfNotNull(p => p.transform);
		}
		static public void SetParent(this GameObject item, Component parent)
		{
			item.SetParent(parent.gameObject);
		}

        static public GameObject GetParent(this GameObject item)
        {
            Transform parent = item.transform.parent;

            if (parent.IsNotNull())
                return parent.gameObject;

            return null;
        }

		static public GameObject GetRoot(this GameObject item)
		{
			return item.GetSelfAndParents().GetLast();
		}

		static public IEnumerable<GameObject> GetParents(this GameObject item)
        {
            return item.gameObject.Traverse(i => i.GetParent());
        }

		static public IEnumerable<GameObject> GetSelfAndParents(this GameObject item)
		{
			return item.GetParents().Prepend(item.gameObject);
		}

		static public void ClearParent(this Component item)
		{
			item.SetParent((GameObject)null);
		}

		static public bool HasParent(this Component item)
        {
            if (item.GetParent().IsNotNull())
                return true;

            return false;
        }

		static public void SetParent(this Component item, GameObject parent)
		{
			item.transform.parent = parent.IfNotNull(p => p.transform);
		}
		static public void SetParent(this Component item, Component parent)
		{
			item.SetParent(parent.gameObject);
		}

        static public GameObject GetParent(this Component item)
        {
            Transform parent = item.transform.parent;

            if (parent.IsNotNull())
                return parent.gameObject;

            return null;
        }

		static public GameObject GetRoot(this Component item)
		{
			return item.GetSelfAndParents().GetLast();
		}

		static public IEnumerable<GameObject> GetParents(this Component item)
        {
            return item.gameObject.Traverse(i => i.GetParent());
        }

		static public IEnumerable<GameObject> GetSelfAndParents(this Component item)
		{
			return item.GetParents().Prepend(item.gameObject);
		}

	}
}