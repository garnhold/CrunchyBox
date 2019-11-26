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
        private PeriodicWorkScheduler scheduler;

        protected abstract T GetComponentInternal(Component parent);

        public ComponentCache(Component parent)
        {
            component = default(T);
            scheduler = new PeriodicWorkScheduler(
                parent,
                () => ComponentCacheManager.GetInstance().GetCacheLifetime(),
                () => component = GetComponentInternal(parent)
            );

            scheduler.Execute();
        }

        public T GetComponent()
        {
            scheduler.Update();

            return component;
        }
    }
}