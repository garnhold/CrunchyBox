using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Planar_Radial_Adjust
    {
        static public void AdjustPlanarPositionAndRotation(this Transform item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.AdjustPlanarPosition(amount);
            item.SetPlanarRotation(amount.GetAngleInDegrees() + angle_offset);
        }
        static public void AdjustRadialPlanarPosition(this Transform item, float angle, float magnitude)
        {
            item.AdjustPlanarPosition(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude);
        }
        static public void AdjustRadialPlanarPositionAndRotation(this Transform item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.AdjustPlanarPositionAndRotation(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude, angle_offset);
        }

        static public void AdjustLocalPlanarPositionAndRotation(this Transform item, Vector2 amount, float angle_offset = 0.0f)
        {
            item.AdjustLocalPlanarPosition(amount);
            item.SetLocalPlanarRotation(amount.GetAngleInDegrees() + angle_offset);
        }
        static public void AdjustLocalRadialPlanarPosition(this Transform item, float angle, float magnitude)
        {
            item.AdjustLocalPlanarPosition(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude);
        }
        static public void AdjustLocalRadialPlanarPositionAndRotation(this Transform item, float angle, float magnitude, float angle_offset = 0.0f)
        {
            item.AdjustLocalPlanarPositionAndRotation(Vector2Extensions.CreateDirectionFromDegrees(angle) * magnitude);
        }
    }
}