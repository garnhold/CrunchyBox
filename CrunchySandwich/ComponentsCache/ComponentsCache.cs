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
        private PeriodicWorkScheduler scheduler;

        protected abstract IEnumerable<T> GetComponentsInternal(Component parent);

        public ComponentsCache(Component parent)
        {
            components = new List<T>();
            scheduler = new PeriodicWorkScheduler(
                parent,
                () => ComponentCacheManager.GetInstance().GetCacheLifetime(),
                () => components.Set(GetComponentsInternal(parent))
            );

            scheduler.Execute();
        }

        public ComponentsCache() : this(null) { }

        public ICatalog<T> AsCatalog()
        {
            scheduler.Update();

            return components.AsCatalog();
        }

        public IEnumerator<T> GetEnumerator()
        {
            scheduler.Update();

            return components.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}