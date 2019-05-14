﻿using System;

namespace CrunchyDough
{
    public class WeakReference<T> : WeakReference where T : class
    {
        public WeakReference(T obj) : base(obj) { }

        public T Get()
        {
            return this.Get<T>();
        }
    }
}