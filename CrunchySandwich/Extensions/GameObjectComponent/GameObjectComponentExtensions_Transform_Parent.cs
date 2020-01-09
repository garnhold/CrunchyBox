using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Parent
    {
		static public Vector2 GetParentPlanarPosition(this GameObject item)
        {
            return item.transform.GetParentPlanarPosition();
        }
        static public Vector2 GetParentLocalPlanarPosition(this GameObject item)
        {
            return item.transform.GetParentLocalPlanarPosition();
        }

        static public float GetParentPlanarRotation(this GameObject item)
        {
            return item.transform.GetParentPlanarRotation();
        }
        static public float GetParentLocalPlanarRotation(this GameObject item)
        {
            return item.transform.GetParentLocalPlanarRotation();
        }

        static public Vector2 GetParentPlanarScale(this GameObject item)
        {
            return item.transform.GetParentPlanarScale();
        }
        static public Vector2 GetParentLocalPlanarScale(this GameObject item)
        {
            return item.transform.GetParentLocalPlanarScale();
        }
		static public Vector2 GetParentPlanarPosition(this Component item)
        {
            return item.transform.GetParentPlanarPosition();
        }
        static public Vector2 GetParentLocalPlanarPosition(this Component item)
        {
            return item.transform.GetParentLocalPlanarPosition();
        }

        static public float GetParentPlanarRotation(this Component item)
        {
            return item.transform.GetParentPlanarRotation();
        }
        static public float GetParentLocalPlanarRotation(this Component item)
        {
            return item.transform.GetParentLocalPlanarRotation();
        }

        static public Vector2 GetParentPlanarScale(this Component item)
        {
            return item.transform.GetParentPlanarScale();
        }
        static public Vector2 GetParentLocalPlanarScale(this Component item)
        {
            return item.transform.GetParentLocalPlanarScale();
        }
	}
}