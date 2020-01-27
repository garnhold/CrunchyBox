using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    
    public class Surface_IList2D<T> : Surface<T>
    {
        private IList2D<T> list;

        public Surface_IList2D(IList2D<T> l)
        {
            list = l;
        }

        public void MixPigmentAt(int x, int y, T pigment, float coverage, Mixer<T> pigment_mixer)
        {
            T current;

            if (list.TryGet(x, y, out current))
                list[x, y] = pigment_mixer.Mix(pigment, current, coverage);
        }

        public void SetPigmentAt(int x, int y, T pigment)
        {
            list.SetDropped(x, y, pigment);
        }

        public T GetPigmentAt(int x, int y)
        {
            return list.GetDropped(x, y);
        }

        public int GetWidth()
        {
            return list.GetWidth();
        }

        public int GetHeight()
        {
            return list.GetHeight();
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