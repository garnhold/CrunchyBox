using System;

namespace CrunchyDough
{
    static public class TextParsingCache
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