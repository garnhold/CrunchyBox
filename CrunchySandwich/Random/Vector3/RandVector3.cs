using System;
using UnityEngine;

using CrunchyBun;

namespace CrunchySandwich
{
    static public class RandVector3
    {
        static public readonly RandVector3Source SOURCE = new RandVector3Source(RandFloat.SOURCE);

        static public Vector3 Get()
        {
            return SOURCE.Get();
        }

        static public Vector3 GetMagnitude(Vector3 m)
        {
            return SOURCE.GetMagnitude(m);
        }

        static public Vector3 GetOffset(Vector3 radius)
        {
            return SOURCE.GetOffset(radius);
        }

        static public Vector3 GetVariance(Vector3 center, Vector3 radius)
        {
            return SOURCE.GetVariance(center, radius);
        }

        static public Vector3 GetBetween(Vector3 a, Vector3 b)
        {
            return SOURCE.GetBetween(a, b);
        }

        static public Vector3 GetWithinBounds(Bounds bounds)
        {
            return SOURCE.GetWithinBounds(bounds);
        }
    }
}