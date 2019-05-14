using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Pooled<T> : IDisposable
    {
        private T value;
        private Pool<T> pool;

        public Pooled(T v, Pool<T> p)
        {
            value = v;
            pool = p;
        }

        public Pooled(Pool<T> p) : this(default(T), p) { }

        public void Dispose()
        {
            pool.DepositRaw(value);
        }

        public void Set(T v)
        {
            value = v;
        }

        public T Get()
        {
            return value;
        }
    }
}