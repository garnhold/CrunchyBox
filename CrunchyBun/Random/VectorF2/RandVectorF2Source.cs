using System;

namespace Crunchy.Bun
{
    using Dough;
    
    public class RandVectorF2Source
    {
        private RandFloatSource source;

        public RandVectorF2Source(RandFloatSource s)
        {
            source = s;
        }

        public VectorF2 Get()
        {
            return new VectorF2(
                source.Get(),
                source.Get()
            );
        }

        public VectorF2 GetMagnitude(VectorF2 m)
        {
            return new VectorF2(
                source.GetMagnitude(m.x),
                source.GetMagnitude(m.y)
            );
        }

        public VectorF2 GetOffset(VectorF2 radius)
        {
            return new VectorF2(
                source.GetOffset(radius.x),
                source.GetOffset(radius.y)
            );
        }

        public VectorF2 GetVariance(VectorF2 center, VectorF2 radius)
        {
            return new VectorF2(
                source.GetVariance(center.x, radius.x),
                source.GetVariance(center.y, radius.y)
            );
        }

        public VectorF2 GetBetween(VectorF2 a, VectorF2 b)
        {
            return new VectorF2(
                source.GetBetween(a.x, b.x),
                source.GetBetween(a.y, b.y)
            );
        }

        public VectorF2 GetNearLinePointByPercent(VectorF2 point1, VectorF2 point2, float percent, float radius)
        {
            return point1.GetPointNearLineByPercent(point2, percent, source.GetOffset(radius));
        }

        public VectorF2 GetNearLinePoint(VectorF2 point1, VectorF2 point2, float distance, float radius)
        {
            return point1.GetPointNearLine(point2, distance, source.GetOffset(radius));
        }

        public VectorF2 GetNearLine(VectorF2 point1, VectorF2 point2, float radius)
        {
            return point1.GetPointNearLineByPercent(point2, source.GetBetween(0.0f, 1.0f), source.GetOffset(radius));
        }
    }
}