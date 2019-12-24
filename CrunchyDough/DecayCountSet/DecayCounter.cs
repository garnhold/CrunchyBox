using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayCounter
    {
        private int lifetime;

        public DecayCounter(int l)
        {
            Reset(l);
        }

        public void Reset(int l)
        {
            lifetime = l;
        }

        public bool Decay()
        {
            if (lifetime <= 0)
                return true;

            lifetime--;
            return false;
        }
    }
}