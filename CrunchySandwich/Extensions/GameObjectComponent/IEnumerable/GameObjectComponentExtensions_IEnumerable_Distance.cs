using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_IEnumerable_Distance
    {
		static public GameObject GetSpacarClosest(this IEnumerable<GameObject> item, Vector3 position)
		{
			return item.FindLowestRated(i => position.GetSquaredDistanceTo(i.GetSpacarPosition()));
		}
		static public GameObject GetPlanarClosest(this IEnumerable<GameObject> item, Vector2 position)
		{
			return item.FindLowestRated(i => position.GetSquaredDistanceTo(i.GetPlanarPosition()));
		}

		static public T GetSpacarClosest<T>(this IEnumerable<T> item, Vector3 position) where T : Component
		{
			return item.FindLowestRated(i => position.GetSquaredDistanceTo(i.GetSpacarPosition()));
		}
		static public T GetPlanarClosest<T>(this IEnumerable<T> item, Vector2 position) where T : Component
		{
			return item.FindLowestRated(i => position.GetSquaredDistanceTo(i.GetPlanarPosition()));
		}

		static public GameObject GetSpacarClosest(this IEnumerable<GameObject> item, GameObject target)
		{
			return item.GetSpacarClosest(target.GetSpacarPosition());
		}
		static public GameObject GetPlanarClosest(this IEnumerable<GameObject> item, GameObject target)
		{
			return item.GetPlanarClosest(target.GetPlanarPosition());
		}

		static public T GetSpacarClosest<T>(this IEnumerable<T> item, GameObject target) where T : Component
		{
			return item.GetSpacarClosest<T>(target.GetSpacarPosition());
		}
		static public T GetPlanarClosest<T>(this IEnumerable<T> item, GameObject target) where T : Component
		{
			return item.GetPlanarClosest<T>(target.GetPlanarPosition());
		}

		static public GameObject GetSpacarClosest(this IEnumerable<GameObject> item, Component target)
		{
			return item.GetSpacarClosest(target.GetSpacarPosition());
		}
		static public GameObject GetPlanarClosest(this IEnumerable<GameObject> item, Component target)
		{
			return item.GetPlanarClosest(target.GetPlanarPosition());
		}

		static public T GetSpacarClosest<T>(this IEnumerable<T> item, Component target) where T : Component
		{
			return item.GetSpacarClosest<T>(target.GetSpacarPosition());
		}
		static public T GetPlanarClosest<T>(this IEnumerable<T> item, Component target) where T : Component
		{
			return item.GetPlanarClosest<T>(target.GetPlanarPosition());
		}

	}
}