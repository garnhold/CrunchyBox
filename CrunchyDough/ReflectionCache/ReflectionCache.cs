using System;

namespace Crunchy.Dough
{
    static public class ReflectionCache
    {
        static private CacheManager CACHE_MANAGER;
        static public CacheManager Get()
        {
            if (CACHE_MANAGER == null)
                CACHE_MANAGER = new CacheManager();

            return CACHE_MANAGER;
        }
    }
}