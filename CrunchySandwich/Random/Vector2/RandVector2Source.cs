using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class RandVector2Source
    {
        private RandFloatSource source;

        public RandVector2Source(RandFloatSource s)
        {
            source = s;
        }

        public Vector2 Get()
        {
            return new Vector2(
                source.Get(),
                source.Get()
            );
        }

        public Vector2 GetMagnitude(Vector2 m)
        {
            return new Vector2(
                source.GetMagnitude(m.x),
                source.GetMagnitude(m.y)
            );
        }

        public Vector2 GetOffset(Vector2 radius)
        {
            return new Vector2(
                source.GetOffset(radius.x),
                source.GetOffset(radius.y)
            );
        }

        public Vector2 GetVariance(Vector2 center, Vector2 radius)
        {
            return new Vector2(
                source.GetVariance(center.x, radius.x),
                source.GetVariance(center.y, radius.y)
            );
        }

        public Vector2 GetBetween(Vector2 a, Vector2 b)
        {
            return new Vector2(
                source.GetBetween(a.x, b.x),
                source.GetBetween(a.y, b.y)
            );
        }

        public Vector2 GetWithinRect(Rect rect)
        {
            return GetVariance(rect.center, rect.size * 0.5f);
        }

        public Vector2 GetNearLinePointByPercent(Vector2 point1, Vector2 point2, float percent, float radius)
        {
            return point1.GetPointNearLineByPercent(point2, percent, source.GetOffset(radius));
        }

        public Vector2 GetNearLinePoint(Vector2 point1, Vector2 point2, float distance, float radius)
        {
            return point1.GetPointNearLine(point2, distance, source.GetOffset(radius));
        }

        public Vector2 GetNearLine(Vector2 point1, Vector2 point2, float radius)
        {
            return point1.GetPointNearLineByPercent(point2, source.GetBetween(0.0f, 1.0f), source.GetOffset(radius));
        }

        public Vector2 GetOnArc(float low_angle, float high_angle, float radius)
        {
            return Vector2Extensions.CreateDirectionFromDegrees(source.GetBetween(low_angle, high_angle)) * radius;
        }
        public Vector2 GetOnArc(FloatRange angle, float radius)
        {
            return GetOnArc(angle.x1, angle.x2, radius);
        }

        public Vector2 GetOnCircle(float radius)
        {
            return GetOnArc(0.0f, 360.0f, radius);
        }

        public Vector2 GetInArc(float low_angle, float high_angle, float low_radius, float high_radius)
        {
            return GetOnArc(low_angle, high_angle, source.GetBetween(low_radius, high_radius));
        }
        public Vector2 GetInArc(FloatRange angle, float low_radius, float high_radius)
        {
            return GetInArc(angle.x1, angle.x2, low_radius, high_radius);
        }
        public Vector2 GetInArc(float low_angle, float high_angle, FloatRange radius)
        {
            return GetInArc(low_angle, high_angle, radius.x1, radius.x2);
        }
        public Vector2 GetInArc(FloatRange angle, FloatRange radius)
        {
            return GetInArc(angle.x1, angle.x2, radius.x1, radius.x2);
        }

        public Vector2 GetInCircle(float low_radius, float high_radius)
        {
            return GetInArc(0.0f, 360.0f, low_radius, high_radius);
        }
        public Vector2 GetInCircle(FloatRange radius)
        {
            return GetInCircle(radius.x1, radius.x2);
        }

        public Vector2 GetInCircle(float radius)
        {
            return GetInCircle(0.0f, radius);
        }

        public Vector2 GetOnArc(Vector2 center, float low_angle, float high_angle, float radius)
        {
            return GetOnArc(low_angle, high_angle, radius) + center;
        }
        public Vector2 GetOnArc(Vector2 center, FloatRange angle, float radius)
        {
            return GetOnArc(center, angle.x1, angle.x2, radius);
        }

        public Vector2 GetOnCircle(Vector2 center, float radius)
        {
            return GetOnArc(center, 0.0f, 360.0f, radius);
        }

        public Vector2 GetInArc(Vector2 center, float low_angle, float high_angle, float low_radius, float high_radius)
        {
            return GetOnArc(center, low_angle, high_angle, source.GetBetween(low_radius, high_radius));
        }
        public Vector2 GetInArc(Vector2 center, FloatRange angle, float low_radius, float high_radius)
        {
            return GetInArc(center, angle.x1, angle.x2, low_radius, high_radius);
        }
        public Vector2 GetInArc(Vector2 center, float low_angle, float high_angle, FloatRange radius)
        {
            return GetInArc(center, low_angle, high_angle, radius.x1, radius.x2);
        }
        public Vector2 GetInArc(Vector2 center, FloatRange angle, FloatRange radius)
        {
            return GetInArc(center, angle.x1, angle.x2, radius.x1, radius.x2);
        }

        public Vector2 GetInCircle(Vector2 center, float low_radius, float high_radius)
        {
            return GetInArc(center, 0.0f, 360.0f, low_radius, high_radius);
        }
        public Vector2 GetInCircle(Vector2 center, FloatRange radius)
        {
            return GetInCircle(center, radius.x1, radius.x2);
        }

        public Vector2 GetInCircle(Vector2 center, float radius)
        {
            return GetInCircle(center, 0.0f, radius);
        }
    }
}