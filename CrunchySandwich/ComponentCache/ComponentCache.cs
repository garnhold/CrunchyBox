using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class ComponentCache<T> : IEnumerable<T>
    {
        private List<T> components;
        private RateLimiter limiter;

        private Component component;

        protected abstract IEnumerable<T> GetComponentsInternal(Component component);

        public ComponentCache(Component c)
        {
            components = new List<T>();
            limiter = new RateLimiter(250);

            component = c;
        }

        public IEnumerator<T> GetEnumerator()
        {
            limiter.Process(delegate() {
                components.Set(GetComponentsInternal(component));
            });

            return components.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}