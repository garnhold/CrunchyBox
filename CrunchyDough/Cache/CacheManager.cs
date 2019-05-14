using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class CacheManager
    {
        private List<Cache> caches;

        private bool is_active;
        private bool should_use_disk;

        public CacheManager(bool a, bool d)
        {
            caches = new List<Cache>();

            is_active = a;
            should_use_disk = d;
        }

        public CacheManager(bool a) : this(a, true) { }
        public CacheManager() : this(true) { }

        public void ClearCaches()
        {
            caches.Process(c => c.Clear());
        }

        public void AddCache(Cache to_add)
        {
            caches.Add(to_add);
            to_add.SetCacheManager(this);
        }

        public void SetIsActive(bool a)
        {
            is_active = a;
        }
        public void Enable()
        {
            SetIsActive(true);
        }
        public void Disable()
        {
            SetIsActive(false);
        }

        public void SetShouldUseDisk(bool d)
        {
            should_use_disk = d;
        }
        public void EnableDiskUse()
        {
            SetShouldUseDisk(true);
        }
        public void DisableDiskUse()
        {
            SetShouldUseDisk(false);
        }

        public bool IsActive()
        {
            return is_active;
        }

        public bool ShouldUseDisk()
        {
            return should_use_disk;
        }
    }
}