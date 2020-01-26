using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    public class Stamp<T>
    {
        private VectorF2 center;
        private VectorF2 dimensions;

        private List<GridCell<T>> cells;

        private void Construct(VectorF2 c, VectorF2 d, IEnumerable<GridCell<T>> cs)
        {
            center = c;
            dimensions = d;

            cells = cs.ToList();
        }

        private void Construct(int w, int h, VectorF2 c, TryOperation<T, int, int> o)
        {
            center = c;
            dimensions = new VectorF2(w, h);

            cells = new List<GridCell<T>>();

            T output;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    if (o(x, y, out output))
                        cells.Add(new GridCell<T>(x, y, output));
                }
            }
        }

        private void Construct(float r, TryOperation<T, int, int> o)
        {
            int width = (int)(r * 2.0f);

            Construct(width, width, new VectorF2(r, r), o);
        }

        public Stamp(VectorF2 c, VectorF2 d, IEnumerable<GridCell<T>> cs)
        {
            Construct(c, d, cs);
        }

        public Stamp(VectorF2 c, Grid<T> g)
        {
            Construct(c, g.GetDimensionsF2(), g);
        }

        public Stamp(Grid<T> g)
        {
            VectorF2 dimensions = g.GetDimensionsF2();

            Construct(dimensions * 0.5f, dimensions, g);
        }

        public Stamp(int w, int h, VectorF2 c, TryOperation<T, int, int> o)
        {
            Construct(w, h, c, o);
        }

        public Stamp(float r, TryOperation<T, int, int> o)
        {
            Construct(r, o);
        }

        public void Press(VectorF2 position, Process<T, VectorF2> process)
        {
            position -= center;

            cells.Process(c => process(c.GetData(), c.GetPointF2() + position));
        }

        public VectorF2 GetCenter()
        {
            return center;
        }

        public VectorF2 GetDimensions()
        {
            return dimensions;
        }

        public IEnumerable<GridCell<T>> GetCells()
        {
            return cells;
        }
    }
}