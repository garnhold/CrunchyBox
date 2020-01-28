using System;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class Brush_Grid<T> : Brush<T>
    {
        private VectorF2 center;
        private Grid<float> grid;

        public Brush_Grid(VectorF2 c, IGrid<float> g)
        {
            center = c;
            grid = g.ToGrid();
        }

        public Brush_Grid(IGrid<float> g) : this(g.GetSize() * 0.5f, g) { }

        public override void Paint(Surface<T> surface, Ink<T> ink, VectorF2 point)
        {
            point -= center;

            grid.ProcessWithIndexs((p, w) => ink.Paint(surface, w, point + p));
        }

        public override float GetWidth()
        {
            return grid.GetSize().GetMaxComponent();
        }
    }
}