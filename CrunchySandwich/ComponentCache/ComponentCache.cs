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
        private Timer timer;

        private Component parent;

        protected abstract T GetComponentInternal(Component parent);

        private void Touch()
        {
            if (timer.Repeat() || Application.isPlaying == false)
                component = GetComponentInternal(parent);
        }

        public ComponentCache(Component p)
        {
            component = default(T);
            timer = new Timer(ComponentCacheManager.GetInstance().GetCacheLifetime()).StartExpireAndGet();

            parent = p;
        }

        public T GetComponent()
        {
            Touch();

            return component;
        }
    }
}