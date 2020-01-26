using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Planar_Radial
    {
        static public void SetLocalPlanarPositionAndRotation(this Transform item, Vector2 position, float angle_offset = 0.0f)
        {
            item.SetLocalPlanarPosition(position);
            item.SetLocalPlanarRotation(item.GetLocalPlanarPosition().GetAngleInDegrees() + angle_offset);
        }
        static public void SetLocalRadialPlanarPosition(this Transform item, float angle, float magnitude)
        {
            item.SetLocalPlanarPosition(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude);
        }
        static public void SetLocalRadialPlanarPositionAndRotation(this Transform item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.SetLocalPlanarPositionAndRotation(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude, angle_offset);
        }

        static public void SetOffsetPlanarPositionAndRotation(this Transform item, Vector2 position, float angle_offset = 0.0f)
        {
            item.SetOffsetPlanarPosition(position);
            item.SetPlanarRotation(item.GetOffsetPlanarPosition().GetAngleInDegrees() + angle_offset);
        }
        static public void SetOffsetRadialPlanarPosition(this Transform item, float angle, float magnitude)
        {
            item.SetOffsetPlanarPosition(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude);
        }
        static public void SetOffsetRadialPlanarPositionAndRotation(this Transform item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.SetOffsetPlanarPositionAndRotation(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude, angle_offset);
        }
    }
}