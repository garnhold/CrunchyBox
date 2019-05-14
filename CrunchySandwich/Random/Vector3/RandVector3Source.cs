using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class RandVector3Source
    {
        private RandFloatSource source;

        public RandVector3Source(RandFloatSource s)
        {
            source = s;
        }

        public Vector3 Get()
        {
            return new Vector3(
                source.Get(),
                source.Get(),
                source.Get()
            );
        }

        public Vector3 GetMagnitude(Vector3 m)
        {
            return new Vector3(
                source.GetMagnitude(m.x),
                source.GetMagnitude(m.y),
                source.GetMagnitude(m.z)
            );
        }

        public Vector3 GetOffset(Vector3 radius)
        {
            return new Vector3(
                source.GetOffset(radius.x),
                source.GetOffset(radius.y),
                source.GetOffset(radius.z)
            );
        }

        public Vector3 GetVariance(Vector3 center, Vector3 radius)
        {
            return new Vector3(
                source.GetVariance(center.x, radius.x),
                source.GetVariance(center.y, radius.y),
                source.GetVariance(center.z, radius.z)
            );
        }

        public Vector3 GetBetween(Vector3 a, Vector3 b)
        {
            return new Vector3(
                source.GetBetween(a.x, b.x),
                source.GetBetween(a.y, b.y),
                source.GetBetween(a.z, b.z)
            );
        }

        public Vector3 GetWithinBounds(Bounds bounds)
        {
            return GetVariance(bounds.center, bounds.extents);
        }
    }
}