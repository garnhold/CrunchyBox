using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class ComponentsCache<T> : IEnumerable<T>
    {
        private List<T> components;
        private RateLimiter limiter;

        private Component parent;

        protected abstract IEnumerable<T> GetComponentsInternal(Component parent);

        private void Touch()
        {
            limiter.Process(delegate() {
                components.Set(GetComponentsInternal(parent));
            });
        }

        public ComponentsCache(Component p)
        {
            components = new List<T>();
            limiter = new RateLimiter(ComponentCacheManager.GetInstance().GetCacheLifetime());

            parent = p;
        }

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