using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class Cache
    {
        public abstract void Clear();

        private string id;
        private CacheManager cache_manager;

        public Cache(string i)
        {
            id = i;
        }

        public void SetCacheManager(CacheManager manager)
        {
            cache_manager = manager;
        }

        public string GetId()
        {
            return id;
        }

        public bool IsActive()
        {
            return cache_manager.IfNotNull(m => m.IsActive(), true);
        }

        public bool ShouldUseDisk()
        {
            return cache_manager.IfNotNull(m => m.ShouldUseDisk(), true);
        }
    }
}