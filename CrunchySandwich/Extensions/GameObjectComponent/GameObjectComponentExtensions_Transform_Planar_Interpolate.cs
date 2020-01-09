using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Planar_Interpolate
    {
		static public void InterpolatePlanarPosition(this GameObject item, Vector2 target, float amount)
        {
            item.transform.InterpolatePlanarPosition(target, amount);
        }
        static public void InterpolateLocalPlanarPosition(this GameObject item, Vector2 target, float amount)
        {
            item.transform.InterpolateLocalPlanarPosition(target, amount);
        }

        static public void InterpolatePlanarRotation(this GameObject item, float target, float amount)
        {
            item.transform.InterpolatePlanarRotation(target, amount);
        }
        static public void InterpolateLocalPlanarRotation(this GameObject item, float target, float amount)
        {
            item.transform.InterpolateLocalPlanarRotation(target, amount);
        }

        static public void InterpolatePlanarScale(this GameObject item, Vector2 target, float amount)
        {
            item.transform.InterpolatePlanarScale(target, amount);
        }
        static public void InterpolateLocalPlanarScale(this GameObject item, Vector2 target, float amount)
        {
            item.transform.InterpolateLocalPlanarScale(target, amount);
        }

		static public void InterpolatePlanarScale(this GameObject item, float target, float amount)
        {
            item.transform.InterpolatePlanarScale(target, amount);
        }
        static public void InterpolateLocalPlanarScale(this GameObject item, float target, float amount)
        {
            item.transform.InterpolateLocalPlanarScale(target, amount);
        }

		static public void InterpolatePlanarPosition(this Component item, Vector2 target, float amount)
        {
            item.transform.InterpolatePlanarPosition(target, amount);
        }
        static public void InterpolateLocalPlanarPosition(this Component item, Vector2 target, float amount)
        {
            item.transform.InterpolateLocalPlanarPosition(target, amount);
        }

        static public void InterpolatePlanarRotation(this Component item, float target, float amount)
        {
            item.transform.InterpolatePlanarRotation(target, amount);
        }
        static public void InterpolateLocalPlanarRotation(this Component item, float target, float amount)
        {
            item.transform.InterpolateLocalPlanarRotation(target, amount);
        }

        static public void InterpolatePlanarScale(this Component item, Vector2 target, float amount)
        {
            item.transform.InterpolatePlanarScale(target, amount);
        }
        static public void InterpolateLocalPlanarScale(this Component item, Vector2 target, float amount)
        {
            item.transform.InterpolateLocalPlanarScale(target, amount);
        }

		static public void InterpolatePlanarScale(this Component item, float target, float amount)
        {
            item.transform.InterpolatePlanarScale(target, amount);
        }
        static public void InterpolateLocalPlanarScale(this Component item, float target, float amount)
        {
            item.transform.InterpolateLocalPlanarScale(target, amount);
        }

	}
}