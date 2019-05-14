using System;
using UnityEngine;

using CrunchyBun;

namespace CrunchySandwich
{
    static public class RandVector2
    {
        static public readonly RandVector2Source SOURCE = new RandVector2Source(RandFloat.SOURCE);

        static public Vector2 Get()
        {
            return SOURCE.Get();
        }

        static public Vector2 GetMagnitude(Vector2 m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public Vector2 GetOffset(Vector2 radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public Vector2 GetVariance(Vector2 center, Vector2 radius)
        {
            return SOURCE.GetVariance(center, radius);
        }

        static public Vector2 GetBetween(Vector2 a, Vector2 b)
        {
            return SOURCE.GetBetween(a, b);
        }

        static public Vector2 GetNearLinePointByPercent(Vector2 point1, Vector2 point2, float percent, float radius)
        {
            return SOURCE.GetNearLinePointByPercent(point1, point2, percent, radius);
        }

        static public Vector2 GetNearLinePoint(Vector2 point1, Vector2 point2, float distance, float radius)
        {
            return SOURCE.GetNearLinePoint(point1, point2, distance, radius);
        }

        static public Vector2 GetNearLine(Vector2 point1, Vector2 point2, float radius)
        {
            return SOURCE.GetNearLine(point1, point2, radius);
        }

        static public Vector2 GetWithinRect(Rect rect)
        {
            return SOURCE.GetWithinRect(rect);
        }
    }
}