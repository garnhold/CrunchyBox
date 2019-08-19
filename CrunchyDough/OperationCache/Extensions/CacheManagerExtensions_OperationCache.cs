using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class CacheManagerExtensions_OperationCache
    {
        static public OperationCache<T> NewOperationCache<T>(this CacheManager item, string i, Operation<T> o)
        {
            return item.AddAndGetCache(new OperationCache<T>(i, o));
        }

        static public OperationCache<T, P1> NewOperationCache<T, P1>(this CacheManager item, string i, Operation<T, P1> o)
        {
            return item.AddAndGetCache(new OperationCache<T, P1>(i, o));
        }

        static public OperationCache<T, P1, P2> NewOperationCache<T, P1, P2>(this CacheManager item, string i, Operation<T, P1, P2> o)
        {
            return item.AddAndGetCache(new OperationCache<T, P1, P2>(i, o));
        }

        static public OperationCache<T, P1, P2, P3> NewOperationCache<T, P1, P2, P3>(this CacheManager item, string i, Operation<T, P1, P2, P3> o)
        {
            return item.AddAndGetCache(new OperationCache<T, P1, P2, P3>(i, o));
        }

        static public OperationCache<T, P1, P2, P3, P4> NewOperationCache<T, P1, P2, P3, P4>(this CacheManager item, string i, Operation<T, P1, P2, P3, P4> o)
        {
            return item.AddAndGetCache(new OperationCache<T, P1, P2, P3, P4>(i, o));
        }

        static public OperationCache<T, P1, P2, P3, P4, P5> NewOperationCache<T, P1, P2, P3, P4, P5>(this CacheManager item, string i, Operation<T, P1, P2, P3, P4, P5> o)
        {
            return item.AddAndGetCache(new OperationCache<T, P1, P2, P3, P4, P5>(i, o));
        }
    }
}