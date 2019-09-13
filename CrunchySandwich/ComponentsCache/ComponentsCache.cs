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
        private Timer timer;

        private Component parent;

        protected abstract IEnumerable<T> GetComponentsInternal(Component parent);

        private void Touch()
        {
            if (timer.Repeat() || Application.isPlaying == false)
                components.Set(GetComponentsInternal(parent));
        }

        public ComponentsCache(Component p)
        {
            components = new List<T>();
            timer = new Timer(ComponentCacheManager.GetInstance().GetCacheLifetime());

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