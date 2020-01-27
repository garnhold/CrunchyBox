using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class SurfaceSelection<T> : Surface<T>
    {
        private Surface<T> surface;
        private HashSet<VectorI2> points;

        public SurfaceSelection(Surface<T> s)
        {
            surface = s;
            points = new HashSet<VectorI2>();
        }

        public bool Add(VectorI2 point)
        {
            if (surface.IsValidPoint(point))
                return points.Add(point);

            return false;
        }

        public bool Remove(VectorI2 point)
        {
            return points.Remove(point);
        }

        public void MixPigmentAt(int x, int y, T pigment, float weight, Mixer<T> pigment_mixer)
        {
            if (points.Contains(new VectorI2(x, y)))
                surface.MixPigmentAt(x, y, pigment, weight, pigment_mixer);
        }

        public void SetPigmentAt(int x, int y, T pigment)
        {
            if(points.Contains(new VectorI2(x, y)))
                surface.SetPigmentAt(x, y, pigment);
        }

        public T GetPigmentAt(int x, int y)
        {
            if (points.Contains(new VectorI2(x, y)))
                return surface.GetPigmentAt(x, y);

            return default(T);
        }

        public int GetWidth()
        {
            return surface.GetWidth();
        }

        public int GetHeight()
        {
            return surface.GetHeight();
        }

        public IEnumerable<VectorI2> GetSurfacePoints()
        {
            return points;
        }
    }
}