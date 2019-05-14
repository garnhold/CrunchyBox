using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class RandVectorI2Source
    {
        private RandFloatSource source;

        public RandVectorI2Source(RandFloatSource s)
        {
            source = s;
        }

        public VectorI2 Get()
        {
            return new VectorI2(
                source.Get(),
                source.Get()
            );
        }

        public VectorI2 GetMagnitude(VectorI2 m)
        {
            return new VectorI2(
                source.GetMagnitude(m.x),
                source.GetMagnitude(m.y)
            );
        }

        public VectorI2 GetOffset(VectorI2 radius)
        {
            return new VectorI2(
                source.GetOffset(radius.x),
                source.GetOffset(radius.y)
            );
        }

        public VectorI2 GetVariance(VectorI2 center, VectorI2 radius)
        {
            return new VectorI2(
                source.GetVariance(center.x, radius.x),
                source.GetVariance(center.y, radius.y)
            );
        }

        public VectorI2 GetBetween(VectorI2 a, VectorI2 b)
        {
            return new VectorI2(
                source.GetBetween(a.x, b.x),
                source.GetBetween(a.y, b.y)
            );
        }
    }
}