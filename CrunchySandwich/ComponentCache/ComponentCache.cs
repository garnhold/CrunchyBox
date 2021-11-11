using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class ComponentCache<T>
    {
        private T component;

        private Component parent;
        private Stopwatch stopwatch;

        protected abstract T GetComponentInternal(Component parent);

        private void Touch()
        {
            if (stopwatch.IsStopped() || stopwatch.GetElapsedTime() >= ComponentCacheManager.GetInstance().GetCacheLifetime())
            {
                component = GetComponentInternal(parent);
                stopwatch.Restart();
            }
        }

        public ComponentCache(Component p)
        {
            component = default(T);

            parent = p;
            stopwatch = new Stopwatch();
        }

        public T GetComponent()
        {
            Touch();

            return component;
        }
    }
}