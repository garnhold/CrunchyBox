using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public partial class DynamicOrderList<T> : IList<T>
    {
        private void Sort()
        {
            list.Sort(comparer);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Add(T to_add)
        {
            list.Add(to_add);
        }

        public bool Remove(T to_remove)
        {
            return list.Remove(to_remove);
        }
    }
}