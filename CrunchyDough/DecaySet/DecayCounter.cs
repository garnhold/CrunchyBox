using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayCounter
    {
        private int life;

        public DecayCounter(int l)
        {
            life = l;
        }

        public void Reset(int l)
        {
            life = l;
        }

        public bool Decay()
        {
            if (life <= 0)
                return true;

            life--;
            return false;
        }
    }
}