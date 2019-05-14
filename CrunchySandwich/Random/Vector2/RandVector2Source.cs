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
    }
}