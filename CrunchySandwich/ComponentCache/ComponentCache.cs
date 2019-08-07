using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class ComponentCache<T>
    {
        private T component;
        private RateLimiter limiter;

        private Component parent;

        protected abstract T GetComponentInternal(Component parent);

        public ComponentCache(Component p)
        {
            component = default(T);
            limiter = new RateLimiter(ComponentCacheManager.GetInstance().GetCacheLifetime());

            parent = p;
        }

        public T GetComponent()
        {
            limiter.Process(delegate() {
                component = GetComponentInternal(parent);
            });

            return component;
        }
    }
}