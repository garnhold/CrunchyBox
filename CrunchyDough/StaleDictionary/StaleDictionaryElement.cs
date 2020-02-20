using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StaleDictionaryElement<T>
    {
        private T data;
        private int stale_id;

        public StaleDictionaryElement(T d, int i)
        {
            data = d;
            stale_id = i;
        }

        public void SetData(T d, int i)
        {
            data = d;
            stale_id = i;
        }

        public void Update(int i)
        {
            stale_id = i;
        }

        public bool IsStale(int i)
        {
            if (stale_id != i)
                return true;

            return false;
        }

        public T GetData()
        {
            return data;
        }
    }
}