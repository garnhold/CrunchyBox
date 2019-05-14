using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Palette<T> : IEnumerable<KeyValuePair<int, T>>
    {
        private List<T> values;
        private Dictionary<T, int> value_indexs;

        public Palette()
        {
            values = new List<T>();
            value_indexs = new Dictionary<T, int>();
        }

        public bool TryAdd(T value, out int index)
        {
            if (value_indexs.TryGetValue(value, out index) == false)
            {
                values.Add(value);
                index = values.GetFinalIndex();
                value_indexs.Add(value, index);

                return true;
            }

            return false;
        }

        public int Add(T value)
        {
            int index;

            TryAdd(value, out index);
            return index;
        }

        public int GetNumberValues()
        {
            return values.Count;
        }

        public int GetIndex(T value)
        {
            return value_indexs.GetValue(value);
        }

        public T GetValue(int index)
        {
            return values.Get(index);
        }

        public IEnumerable<int> GetIndexs()
        {
            for (int i = 0; i < values.Count; i++)
                yield return i;
        }

        public IEnumerable<T> GetValues()
        {
            return values;
        }

        public IEnumerator<KeyValuePair<int, T>> GetEnumerator()
        {
            for (int i = 0; i < values.Count; i++)
                yield return KeyValuePair.New(i, values[i]);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}