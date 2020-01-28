using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    public class Stamp<T>
    {
        private VectorF2 center;
        private VectorF2 dimensions;

        private Dictionary<VectorI2, T> points;

        public Stamp(VectorF2 c, VectorF2 d, IEnumerable<KeyValuePair<VectorI2, T>> cs)
        {
            center = c;
            dimensions = d;

            points = cs.ToDictionary();
        }

        public Stamp(int w, int h, VectorF2 c, TryOperation<T, int, int> o)
        {
            center = c;
            dimensions = new VectorF2(w, h);

            points = new Dictionary<VectorI2, T>();

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    T output;

                    if (o(x, y, out output))
                        points.Add(new VectorI2(x, y), output);
                }
            }
        }

        public Stamp(float r, TryOperation<T, int, int> o) : this((int)(r * 2), (int)(r * 2), new VectorF2(r, r) / 2.0f, o) { }

        public Stamp(VectorF2 c, IGrid<T> g) : this(g.GetSize(), c, g.ConvertToKeyValuePairs()) { }
        public Stamp(IGrid<T> g) : this(g.GetSize() * 0.5f, g) { }

        public void Press(VectorF2 position, Process<T, VectorF2> process)
        {
            position -= center;

            points.Process(p => process(p.Value, p.Key + position));
        }

        public VectorF2 GetCenter()
        {
            return center;
        }

        public VectorF2 GetDimensions()
        {
            return dimensions;
        }
    }
}