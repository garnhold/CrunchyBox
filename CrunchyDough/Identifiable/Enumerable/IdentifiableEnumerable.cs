using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class IdentifiableEnumerable<T> : Identifiable, IEnumerable<T> where T : Identifiable
    {
        private IEnumerable<T> enumerable;

        public IdentifiableEnumerable(IEnumerable<T> e)
        {
            if (e != null)
                enumerable = e;
            else
                enumerable = EmptyEnumerable<T>.INSTANCE;
        }

        public override bool Equals(object obj)
        {
            IdentifiableEnumerable<T> cast = obj as IdentifiableEnumerable<T>;

            if (cast != null)
                return this.AreElementsEqual(cast);

            return false;
        }

        public override int GetHashCode()
        {
            return this.GetElementsHashCode();
        }

        public string GetIdentity()
        {
            return this.GetElementsIdentity();
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