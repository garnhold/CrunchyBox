using System;

using UnityEngine;

namespace CrunchySandwich
{
    public struct RayLine
    {
        public readonly Vector3 origin;
        public readonly Vector3 terminus;

        public RayLine(Vector3 o, Vector3 t)
        {
            origin = o;
            terminus = t;
        }

        public Ray GetRay()
        {
            return new Ray(origin, GetDifference());
        }

        public float GetLength()
        {
            return GetDifference().GetMagnitude();
        }

        public Vector3 GetDifference()
        {
            return terminus - origin;
        }

        public Vector3 GetDirection()
        {
            return GetDifference().GetNormalized();
        }

        public Vector3 GetDirection(out float length)
        {
            return GetDifference().GetNormalized(out length);
        }
    }
}