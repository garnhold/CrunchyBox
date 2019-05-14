using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public partial class StaticOrderList<T> : IList<T>
    {
        private bool is_dirty;

        private void Sort()
        {
            if (is_dirty)
            {
                list.Sort(comparer);

                is_dirty = false;
            }
        }

        public void Clear()
        {
            list.Clear();

            is_dirty = true;
        }

        public void Add(T to_add)
        {
            list.Add(to_add);

            is_dirty = true;
        }

        public bool Remove(T to_remove)
        {
            is_dirty = true;

            return list.Remove(to_remove);
        }
    }
}