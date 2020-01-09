using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class SignalingContainer_Collection_List<T> : SignalingContainer_Collection<T>, IList<T>
    {
        private List<T> list;

        public T this[int index] { get { return list[index]; } set { list[index] = value; } }
        public override int Count { get { return list.Count; } }

        public SignalingContainer_Collection_List()
        {
            list = new List<T>();
        }

        public override void Clear()
        {
            list.RemoveAll(them => CanRemove(them));
        }

        public override bool TryAdd(T to_add)
        {
            if (CanAdd(to_add))
            {
                list.Add(to_add);

                return true;
            }

            return false;
        }

        public override bool Remove(T to_remove)
        {
            if (CanRemove(to_remove))
                return list.Remove(to_remove);

            return false;
        }

        public override bool Contains(T item)
        {
            return list.Contains(item);
        }

        public override void CopyTo(T[] array, int array_index)
        {
            list.CopyTo(array, array_index);
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            if (CanRemove(list[index]))
                list.RemoveAt(index);
        }

        public void Insert(int index, T item)
        {
            if (CanAdd(item))
                list.Insert(index, item);
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}