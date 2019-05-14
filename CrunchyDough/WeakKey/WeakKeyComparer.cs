using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class WeakKeyComparer<T> : IEqualityComparer<object> where T : class
    {
        static public readonly WeakKeyComparer<T> INSTANCE = new WeakKeyComparer<T>();

        private WeakKeyComparer() { }

        public int GetHashCode(object obj)
        {
            return WeakKey<T>.DereferenceHashCode(obj);
        }

        public new bool Equals(object x, object y)
        {
            return WeakKey<T>.DereferenceEquals(x, y);
        }
    }
}