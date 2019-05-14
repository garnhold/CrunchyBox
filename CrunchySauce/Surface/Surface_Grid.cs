using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySauce
{
    public class Surface_Grid<T> : Surface<T>
    {
        private Grid<T> grid;

        public Surface_Grid(Grid<T> g)
        {
            grid = g;
        }

        public void MixPigmentAt(int x, int y, T pigment, float coverage, Mixer<T> pigment_mixer)
        {
            GridCell<T> cell;

            if (grid.TryGetCell(x, y, out cell))
                cell.SetData(pigment_mixer.Mix(pigment, cell.GetData(), coverage));
        }

        public void SetPigmentAt(int x, int y, T pigment)
        {
            GridCell<T> cell;

            if (grid.TryGetCell(x, y, out cell))
                cell.SetData(pigment);
        }

        public T GetPigmentAt(int x, int y)
        {
            GridCell<T> cell;

            if (grid.TryGetCell(x, y, out cell))
                return cell.GetData();

            return default(T);
        }

        public int GetWidth()
        {
            return grid.GetWidth();
        }

        public int GetHeight()
        {
            return grid.GetHeight();
        }

        public IEnumerable<SurfacePoint> GetSurfacePoints()
        {
            return grid.GetCells().Convert(c => c.GetSurfacePoint());
        }
    }
}