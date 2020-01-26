using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_Transform_Planar_Radial_Adjust
    {
		static public void AdjustPlanarPositionAndRotation(this GameObject item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.transform.AdjustPlanarPositionAndRotation(amount, angle_offset);
        }
        static public void AdjustRadialPlanarPosition(this GameObject item, float angle, float magnitude)
        {
            item.transform.AdjustRadialPlanarPosition(angle, magnitude);
        }
        static public void AdjustRadialPlanarPositionAndRotation(this GameObject item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.AdjustRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

        static public void AdjustLocalPlanarPositionAndRotation(this GameObject item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.transform.AdjustLocalPlanarPositionAndRotation(amount, angle_offset);
        }
        static public void AdjustLocalRadialPlanarPosition(this GameObject item, float angle, float magnitude)
        {
            item.transform.AdjustLocalRadialPlanarPosition(angle, magnitude);
        }
        static public void AdjustLocalRadialPlanarPositionAndRotation(this GameObject item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.AdjustLocalRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

		static public void AdjustPlanarPositionAndRotation(this Component item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.transform.AdjustPlanarPositionAndRotation(amount, angle_offset);
        }
        static public void AdjustRadialPlanarPosition(this Component item, float angle, float magnitude)
        {
            item.transform.AdjustRadialPlanarPosition(angle, magnitude);
        }
        static public void AdjustRadialPlanarPositionAndRotation(this Component item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.AdjustRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

        static public void AdjustLocalPlanarPositionAndRotation(this Component item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.transform.AdjustLocalPlanarPositionAndRotation(amount, angle_offset);
        }
        static public void AdjustLocalRadialPlanarPosition(this Component item, float angle, float magnitude)
        {
            item.transform.AdjustLocalRadialPlanarPosition(angle, magnitude);
        }
        static public void AdjustLocalRadialPlanarPositionAndRotation(this Component item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.AdjustLocalRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

	}
}