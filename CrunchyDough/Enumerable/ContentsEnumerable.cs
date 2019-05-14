using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ContentsEnumerable<T> : IEnumerable<T>
    {
        private IEnumerable<T> enumerable;

        public ContentsEnumerable(IEnumerable<T> e)
        {
            if (e != null)
                enumerable = e;
            else
                enumerable = EmptyEnumerable<T>.INSTANCE;
        }

        public override bool Equals(object obj)
        {
            ContentsEnumerable<T> cast = obj as ContentsEnumerable<T>;

            if (cast != null)
                return this.AreElementsEqual(cast);

            return false;
        }

        public override int GetHashCode()
        {
            return this.GetElementsHashCode();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}