using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class RadiatingWalker
    {
        private int current_radius;
        private List<RadiatingPoint> points;

        static private RadiatingWalker INSTANCE = new RadiatingWalker();

        static public IEnumerable<VectorI2> Iterator(int radius)
        {
            return INSTANCE.GetPoints(radius);
        }

        private RadiatingWalker()
        {
            current_radius = 0;
            points = new List<RadiatingPoint>();
        }

        public void EnsureRadius(int radius)
        {
            if (radius > current_radius)
            {
                RectI2 old_rect = RectI2Extensions.CreateCenterRectI2(VectorI2.ZERO, new VectorI2(current_radius * 2, current_radius * 2));
                RectI2 new_rect = RectI2Extensions.CreateCenterRectI2(VectorI2.ZERO, new VectorI2(radius * 2, radius * 2));

                new_rect.GetSubtraction(old_rect)
                    .Convert(r => r.GetPoints())
                    .Flatten()
                    .Process(p => points.Add(new RadiatingPoint(p)));

                current_radius = radius;
                points.Sort((x, y) => x.GetDistance().CompareTo(y.GetDistance()));
            }
        }

        public IEnumerable<VectorI2> GetPoints(int radius)
        {
            EnsureRadius(radius);

            foreach (RadiatingPoint point in points)
            {
                if (point.GetDistance() <= radius)
                    yield return point.GetPoint();
            }
        }
    }
}