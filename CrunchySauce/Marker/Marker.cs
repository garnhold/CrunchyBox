using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sauce
{
    using Dough;
    using Noodle;
    
    public abstract class Marker<T>
    {
        private Utensil<T> utensil;
        private Surface<T> surface;

        public Marker(Utensil<T> u, Surface<T> s)
        {
            utensil = u;
            surface = s;
        }

        public Utensil<T> GetUtensil()
        {
            return utensil;
        }

        public Surface<T> GetSurface()
        {
            return surface;
        }
    }
}