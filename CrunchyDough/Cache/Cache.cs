using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class Cache
    {
        public abstract void Clear();

        private CacheManager cache_manager;

        public void SetCacheManager(CacheManager manager)
        {
            cache_manager = manager;
        }

        public bool IsActive()
        {
            if(cache_manager != null)
                return cache_manager.IsActive();

            return true;
        }

        public bool ShouldUseDisk()
        {
            if (cache_manager != null)
                return cache_manager.ShouldUseDisk();

            return true;
        }
    }
}