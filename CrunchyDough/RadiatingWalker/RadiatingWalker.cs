using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class RadiatingWalker
    {
        private int current_radius;
        private SortedList<float, VectorI2> points;

        static private RadiatingWalker INSTANCE = new RadiatingWalker();

        static public IEnumerable<VectorI2> Iterator(int radius)
        {
            return INSTANCE.GetPoints(radius);
        }

        private RadiatingWalker()
        {
            current_radius = 0;
            points = new SortedList<float, VectorI2>();
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
                    .Process(p => points.Add(p.GetMagnitude(), p));

                current_radius = radius;
            }
        }

        public IEnumerable<VectorI2> GetPoints(int radius)
        {
            EnsureRadius(radius);

            foreach (KeyValuePair<float, VectorI2> pair in points)
            {
                if (pair.Key <= radius)
                    yield return pair.Value;
            }
        }
    }
}