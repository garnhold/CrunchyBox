using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Transform_Planar_Radial
    {
		static public void SetLocalPlanarPositionAndRotation(this GameObject item, Vector2 position, float angle_offset = 0.0f)
        {
            item.transform.SetLocalPlanarPositionAndRotation(position, angle_offset);
        }
        static public void SetLocalRadialPlanarPosition(this GameObject item, float angle, float magnitude)
        {
            item.transform.SetLocalRadialPlanarPosition(angle, magnitude);
        }
        static public void SetLocalRadialPlanarPositionAndRotation(this GameObject item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.SetLocalRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

		static public void SetOffsetPlanarPositionAndRotation(this GameObject item, Vector2 position, float angle_offset = 0.0f)
        {
            item.transform.SetOffsetPlanarPositionAndRotation(position, angle_offset);
        }
        static public void SetOffsetRadialPlanarPosition(this GameObject item, float angle, float magnitude)
        {
            item.transform.SetOffsetRadialPlanarPosition(angle, magnitude);
        }
        static public void SetOffsetRadialPlanarPositionAndRotation(this GameObject item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.SetOffsetRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

		static public void SetLocalPlanarPositionAndRotation(this Component item, Vector2 position, float angle_offset = 0.0f)
        {
            item.transform.SetLocalPlanarPositionAndRotation(position, angle_offset);
        }
        static public void SetLocalRadialPlanarPosition(this Component item, float angle, float magnitude)
        {
            item.transform.SetLocalRadialPlanarPosition(angle, magnitude);
        }
        static public void SetLocalRadialPlanarPositionAndRotation(this Component item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.SetLocalRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

		static public void SetOffsetPlanarPositionAndRotation(this Component item, Vector2 position, float angle_offset = 0.0f)
        {
            item.transform.SetOffsetPlanarPositionAndRotation(position, angle_offset);
        }
        static public void SetOffsetRadialPlanarPosition(this Component item, float angle, float magnitude)
        {
            item.transform.SetOffsetRadialPlanarPosition(angle, magnitude);
        }
        static public void SetOffsetRadialPlanarPositionAndRotation(this Component item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.transform.SetOffsetRadialPlanarPositionAndRotation(angle, magnitude, angle_offset);
        }

	}
}