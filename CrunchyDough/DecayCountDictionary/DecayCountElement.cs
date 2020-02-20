using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class DecayCountElement<T>
    {
        private T data;
        private int lifetime;

        public DecayCountElement(T d, int l)
        {
            data = d;
            lifetime = l;
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

        public void SetData(T d)
        {
            data = d;
        }

        public T GetData()
        {
            return data;
        }
    }
}