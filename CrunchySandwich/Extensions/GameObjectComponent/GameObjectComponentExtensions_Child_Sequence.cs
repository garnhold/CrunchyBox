using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Child_Sequence
    {
		static public IEnumerable<GameObject> GetChildSequence(this GameObject item, GameObject child)
        {
            return child.GetSelfAndParents().EndBefore(item.gameObject).Reverse();
        }

        static public IEnumerable<string> GetChildNameSequence(this GameObject item, GameObject child)
        {
            return item.GetChildSequence(child).Convert(c => c.name);
        }

        static public string GetChildPath(this GameObject item, GameObject child)
        {
            return item.GetChildNameSequence(child).Join("->");
        }

		static public IEnumerable<GameObject> GetChildSequence(this Component item, GameObject child)
        {
            return child.GetSelfAndParents().EndBefore(item.gameObject).Reverse();
        }

        static public IEnumerable<string> GetChildNameSequence(this Component item, GameObject child)
        {
            return item.GetChildSequence(child).Convert(c => c.name);
        }

        static public string GetChildPath(this Component item, GameObject child)
        {
            return item.GetChildNameSequence(child).Join("->");
        }

	}
}