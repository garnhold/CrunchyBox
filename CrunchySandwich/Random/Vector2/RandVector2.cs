using System;
using UnityEngine;

using CrunchyDough;
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
        //#######################################################

        static public Vector2 GetOnArc(float low_angle, float high_angle, float radius)
        {
            return SOURCE.GetOnArc(low_angle, high_angle, radius);
        }
        static public Vector2 GetOnArc(FloatRange angle, float radius)
        {
            return SOURCE.GetOnArc(angle, radius);
        }

        static public Vector2 GetOnCircle(float radius)
        {
            return SOURCE.GetOnCircle(radius);
        }

        static public Vector2 GetInArc(float low_angle, float high_angle, float low_radius, float high_radius)
        {
            return SOURCE.GetInArc(low_angle, high_angle, low_radius, high_radius);
        }
        static public Vector2 GetInArc(FloatRange angle, float low_radius, float high_radius)
        {
            return SOURCE.GetInArc(angle, low_radius, high_radius);
        }
        static public Vector2 GetInArc(float low_angle, float high_angle, FloatRange radius)
        {
            return SOURCE.GetInArc(low_angle, high_angle, radius);
        }
        static public Vector2 GetInArc(FloatRange angle, FloatRange radius)
        {
            return SOURCE.GetInArc(angle, radius);
        }

        static public Vector2 GetInCircle(float low_radius, float high_radius)
        {
            return SOURCE.GetInCircle(low_radius, high_radius);
        }
        static public Vector2 GetInCircle(FloatRange radius)
        {
            return SOURCE.GetInCircle(radius);
        }

        static public Vector2 GetInCircle(float radius)
        {
            return SOURCE.GetInCircle(radius);
        }

        static public Vector2 GetOnArc(Vector2 center, float low_angle, float high_angle, float radius)
        {
            return SOURCE.GetOnArc(center, low_angle, high_angle, radius);
        }
        static public Vector2 GetOnArc(Vector2 center, FloatRange angle, float radius)
        {
            return SOURCE.GetOnArc(center, angle, radius);
        }

        static public Vector2 GetOnCircle(Vector2 center, float radius)
        {
            return SOURCE.GetOnCircle(center, radius);
        }

        static public Vector2 GetInArc(Vector2 center, float low_angle, float high_angle, float low_radius, float high_radius)
        {
            return SOURCE.GetInArc(center, low_angle, high_angle, low_radius, high_radius);
        }
        static public Vector2 GetInArc(Vector2 center, FloatRange angle, float low_radius, float high_radius)
        {
            return SOURCE.GetInArc(center, angle, low_radius, high_radius);
        }
        static public Vector2 GetInArc(Vector2 center, float low_angle, float high_angle, FloatRange radius)
        {
            return SOURCE.GetInArc(center, low_angle, high_angle, radius);
        }
        static public Vector2 GetInArc(Vector2 center, FloatRange angle, FloatRange radius)
        {
            return SOURCE.GetInArc(center, angle, radius);
        }

        static public Vector2 GetInCircle(Vector2 center, float low_radius, float high_radius)
        {
            return SOURCE.GetInCircle(center, low_radius, high_radius);
        }
        static public Vector2 GetInCircle(Vector2 center, FloatRange radius)
        {
            return SOURCE.GetInCircle(center, radius);
        }

        static public Vector2 GetInCircle(Vector2 center, float radius)
        {
            return SOURCE.GetInCircle(center, radius);
        }
    }
}