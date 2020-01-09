using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Children
    {
		static public bool HasChildren(this GameObject item)
		{
			return item.GetChildren().IsNotEmpty();
		}

		static public bool HasNoChildren(this GameObject item)
		{
			return item.GetChildren().IsEmpty();
		}

		static public IEnumerable<GameObject> GetChildren(this GameObject item)
        {
            return item.transform.GetChildren().Convert(c => c.gameObject);
        }

		static public IEnumerable<GameObject> GetSelfAndChildren(this GameObject item)
        {
            return item.GetChildren().Prepend(item.gameObject);
        }

		static public bool HasChildren(this Component item)
		{
			return item.GetChildren().IsNotEmpty();
		}

		static public bool HasNoChildren(this Component item)
		{
			return item.GetChildren().IsEmpty();
		}

		static public IEnumerable<GameObject> GetChildren(this Component item)
        {
            return item.transform.GetChildren().Convert(c => c.gameObject);
        }

		static public IEnumerable<GameObject> GetSelfAndChildren(this Component item)
        {
            return item.GetChildren().Prepend(item.gameObject);
        }

	}
}