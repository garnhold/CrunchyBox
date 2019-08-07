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

        public ComponentsCache(Component p)
        {
            components = new List<T>();
            limiter = new RateLimiter(ComponentCacheManager.GetInstance().GetCacheLifetime());

            parent = p;
        }

        public IEnumerator<T> GetEnumerator()
        {
            limiter.Process(delegate() {
                components.Set(GetComponentsInternal(parent));
            });

            return components.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}