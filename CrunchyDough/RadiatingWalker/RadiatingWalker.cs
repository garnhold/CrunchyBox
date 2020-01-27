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

        private void AddBlock(int x1, int y1, int x2, int y2)
        {
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                {
                    points.Add(
                        (float)Math.Sqrt(x.GetSquared() + y.GetSquared()),
                        new VectorI2(x, y)
                    );
                }
            }
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
                AddBlock(radius, radius, -radius, current_radius);
                AddBlock(radius, -current_radius, -radius, radius);

                AddBlock(radius, current_radius, current_radius, -current_radius);
                AddBlock(-current_radius, current_radius, -radius, current_radius);

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