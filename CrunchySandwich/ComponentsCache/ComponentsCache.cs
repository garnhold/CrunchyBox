using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class ComponentsCache<T> : IEnumerable<T>
    {
        private List<T> components;

        private Component parent;
        private Stopwatch stopwatch;

        protected abstract IEnumerable<T> GetComponentsInternal(Component parent);

        private void Touch()
        {
            if (stopwatch.IsStopped() || stopwatch.GetElapsedTime() >= ComponentCacheManager.GetInstance().GetCacheLifetime())
            {
                components.Set(GetComponentsInternal(parent));
                stopwatch.Restart();
            }
        }

        public ComponentsCache(Component p)
        {
            components = new List<T>();

            parent = p;
            stopwatch = new Stopwatch();
        }

        public ComponentsCache() : this(null) { }

        public ICatalog<T> AsCatalog()
        {
            Touch();

            return components.AsCatalog();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Touch();

            return components.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}