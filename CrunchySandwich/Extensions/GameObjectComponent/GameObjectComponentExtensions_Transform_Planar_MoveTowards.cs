using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Transform_Planar_MoveTowards
    {
		static public bool MoveTowardsPlanarPosition(this GameObject item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsPlanarPosition(target, amount);
        }
        static public bool MoveTowardsLocalPlanarPosition(this GameObject item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsLocalPlanarPosition(target, amount);
        }

        static public bool MoveTowardsPlanarRotation(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsPlanarRotation(target, amount);
        }
        static public bool MoveTowardsLocalPlanarRotation(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalPlanarRotation(target, amount);
        }

        static public bool MoveTowardsPlanarScale(this GameObject item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsPlanarScale(target, amount);
        }
        static public bool MoveTowardsLocalPlanarScale(this GameObject item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsLocalPlanarScale(target, amount);
        }

		static public bool MoveTowardsPlanarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsPlanarScale(target, amount);
        }
        static public bool MoveTowardsLocalPlanarScale(this GameObject item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalPlanarScale(target, amount);
        }

		static public bool MoveTowardsPlanarPosition(this Component item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsPlanarPosition(target, amount);
        }
        static public bool MoveTowardsLocalPlanarPosition(this Component item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsLocalPlanarPosition(target, amount);
        }

        static public bool MoveTowardsPlanarRotation(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsPlanarRotation(target, amount);
        }
        static public bool MoveTowardsLocalPlanarRotation(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalPlanarRotation(target, amount);
        }

        static public bool MoveTowardsPlanarScale(this Component item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsPlanarScale(target, amount);
        }
        static public bool MoveTowardsLocalPlanarScale(this Component item, Vector2 target, Vector2 amount)
        {
            return item.transform.MoveTowardsLocalPlanarScale(target, amount);
        }

		static public bool MoveTowardsPlanarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsPlanarScale(target, amount);
        }
        static public bool MoveTowardsLocalPlanarScale(this Component item, float target, float amount)
        {
            return item.transform.MoveTowardsLocalPlanarScale(target, amount);
        }

	}
}