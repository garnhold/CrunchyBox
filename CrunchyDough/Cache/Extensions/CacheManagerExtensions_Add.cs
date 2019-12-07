using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class CacheManagerExtensions_Add
    {
        static public T AddAndGetCache<T>(this CacheManager item, T to_add) where T : Cache
        {
            item.AddCache(to_add);
            return to_add;
        }
    }
}