using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class SignalingContainer_Single<T> : SignalingContainer<T>
    {
        private T item;
        private bool is_active;

        public SignalingContainer_Single()
        {
            is_active = false;
        }

        public bool Clear()
        {
            if (is_active)
            {
                if (CanRemove(item))
                {
                    item = default(T);
                    is_active = false;

                    return true;
                }

                return false;
            }

            return true;
        }

        public bool Set(T to_set)
        {
            if (Clear())
            {
                if (CanAdd(to_set))
                {
                    item = to_set;
                    is_active = true;

                    return true;
                }
            }

            return false;
        }

        public bool Remove(T to_remove)
        {
            if (item.EqualsEX(to_remove))
                return Clear();

            return false;
        }

        public T Get()
        {
            return item;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            if (is_active)
                yield return item;
        }
    }
}