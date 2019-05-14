using System;

using UnityEngine;

namespace CrunchySandwich
{
    public struct RayLine2
    {
        public readonly Vector2 origin;
        public readonly Vector2 terminus;

        public RayLine2(Vector2 o, Vector2 t)
        {
            origin = o;
            terminus = t;
        }

        public Ray2 GetRay()
        {
            return new Ray2(origin, GetDifference());
        }

        public float GetLength()
        {
            return GetDifference().GetMagnitude();
        }

        public Vector2 GetDifference()
        {
            return terminus - origin;
        }

        public Vector2 GetDirection()
        {
            return GetDifference().GetNormalized();
        }

        public Vector2 GetDirection(out float length)
        {
            return GetDifference().GetNormalized(out length);
        }
    }
}