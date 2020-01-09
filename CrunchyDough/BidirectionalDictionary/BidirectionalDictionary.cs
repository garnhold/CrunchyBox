using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class BidirectionalDictionary<LEFT_TYPE, RIGHT_TYPE> : ICollection<KeyValuePair<LEFT_TYPE, RIGHT_TYPE>>
    {
        private Dictionary<LEFT_TYPE, RIGHT_TYPE> left_to_right;
        private Dictionary<RIGHT_TYPE, LEFT_TYPE> right_to_left;

        public int Count { get{ return left_to_right.Count; } }
        public bool IsReadOnly { get{ return false; } }

        public BidirectionalDictionary()
        {
            left_to_right = new Dictionary<LEFT_TYPE, RIGHT_TYPE>();
            right_to_left = new Dictionary<RIGHT_TYPE, LEFT_TYPE>();
        }

        public BidirectionalDictionary(IEnumerable<KeyValuePair<LEFT_TYPE, RIGHT_TYPE>> v) : this()
        {
            this.AddRange(v);
        }

        public void Clear()
        {
            left_to_right.Clear();
            right_to_left.Clear();
        }

        public void Add(LEFT_TYPE left, RIGHT_TYPE right)
        {
            left_to_right.Add(left, right);
            right_to_left.Add(right, left);
        }
        public void Add(KeyValuePair<LEFT_TYPE, RIGHT_TYPE> pair)
        {
            Add(pair.Key, pair.Value);
        }

        public void Update(LEFT_TYPE left, RIGHT_TYPE right)
        {
            left_to_right[left] = right;
            right_to_left[right] = left;
        }
        public void Update(KeyValuePair<LEFT_TYPE, RIGHT_TYPE> pair)
        {
            Update(pair.Key, pair.Value);
        }

        public bool RemoveByLeft(LEFT_TYPE left)
        {
            RIGHT_TYPE right;

            if (TryGetValueByLeft(left, out right))
            {
                left_to_right.Remove(left);
                right_to_left.Remove(right);

                return true;
            }

            return false;
        }

        public bool RemoveByRight(RIGHT_TYPE right)
        {
            LEFT_TYPE left;

            if (TryGetValueByRight(right, out left))
            {
                left_to_right.Remove(left);
                right_to_left.Remove(right);

                return true;
            }

            return false;
        }

        public bool Remove(KeyValuePair<LEFT_TYPE, RIGHT_TYPE> pair)
        {
            if(Contains(pair))
            {
                left_to_right.Remove(pair.Key);
                right_to_left.Remove(pair.Value);

                return true;
            }

            return false;
        }

        public void CopyTo(KeyValuePair<LEFT_TYPE, RIGHT_TYPE>[] array, int array_index)
        {
            ((IDictionary<LEFT_TYPE, RIGHT_TYPE>)left_to_right).CopyTo(array, array_index);
        }

        public bool Contains(KeyValuePair<LEFT_TYPE, RIGHT_TYPE> pair)
        {
            RIGHT_TYPE right;

            if (TryGetValueByLeft(pair.Key, out right))
            {
                if (pair.Value.Equals(right))
                    return true;
            }

            return false;
        }

        public bool ContainsLeft(LEFT_TYPE left)
        {
            if (left_to_right.ContainsKey(left))
                return true;

            return false;
        }

        public bool ContainsRight(RIGHT_TYPE right)
        {
            if (right_to_left.ContainsKey(right))
                return true;

            return false;
        }

        public bool TryGetValueByLeft(LEFT_TYPE left, out RIGHT_TYPE right)
        {
            return left_to_right.TryGetValue(left, out right);
        }

        public bool TryGetValueByRight(RIGHT_TYPE right, out LEFT_TYPE left)
        {
            return right_to_left.TryGetValue(right, out left);
        }

        public IEnumerator<KeyValuePair<LEFT_TYPE, RIGHT_TYPE>> GetEnumerator()
        {
            return left_to_right.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}