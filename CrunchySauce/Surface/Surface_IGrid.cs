using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class Surface_IGrid<T> : Surface<T>
    {
        private IGrid<T> grid;

        public Surface_IGrid(IGrid<T> g)
        {
            grid = g;
        }

        public void MixPigmentAt(int x, int y, T pigment, float coverage, Mixer<T> pigment_mixer)
        {
            T current;

            if (grid.TryGet(x, y, out current))
                grid[x, y] = pigment_mixer.Mix(pigment, current, coverage);
        }

        public void SetPigmentAt(int x, int y, T pigment)
        {
            grid.SetDropped(x, y, pigment);
        }

        public T GetPigmentAt(int x, int y)
        {
            return grid.GetDropped(x, y);
        }

        public int GetWidth()
        {
            return grid.GetWidth();
        }

        public int GetHeight()
        {
            return grid.GetHeight();
        }

        public IEnumerable<VectorI2> GetSurfacePoints()
        {
            for (int y = 0; y < GetHeight(); y++)
            {
                for (int x = 0; x < GetWidth(); x++)
                    yield return new VectorI2(x, y);
            }
        }
    }
}