using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class CacheManagerExtensions_CompileTimeCache
    {
        static public CompileTimeCache<T> NewCompileTimeCache<T>(this CacheManager item, string i, Husker<T> h, Operation<T> o)
        {
            return item.AddAndGetCache(new CompileTimeCache<T>(i, h, o));
        }

        static public CompileTimeCache<T, P> NewCompileTimeCache<T, P>(this CacheManager item, string i, Husker<T> h, Operation<T, P> o)
            where P : Identifiable
        {
            return item.AddAndGetCache(new CompileTimeCache<T, P>(i, h, o));
        }

        static public CompileTimeCache<T, P1, P2> NewCompileTimeCache<T, P1, P2>(this CacheManager item, string i, Husker<T> h, Operation<T, P1, P2> o)
            where P1 : Identifiable
            where P2 : Identifiable
        {
            return item.AddAndGetCache(new CompileTimeCache<T, P1, P2>(i, h, o));
        }

        static public CompileTimeCache<T, P1, P2, P3> NewCompileTimeCache<T, P1, P2, P3>(this CacheManager item, string i, Husker<T> h, Operation<T, P1, P2, P3> o)
            where P1 : Identifiable
            where P2 : Identifiable
            where P3 : Identifiable
        {
            return item.AddAndGetCache(new CompileTimeCache<T, P1, P2, P3>(i, h, o));
        }

        static public CompileTimeCache<T, P1, P2, P3, P4> NewCompileTimeCache<T, P1, P2, P3, P4>(this CacheManager item, string i, Husker<T> h, Operation<T, P1, P2, P3, P4> o)
            where P1 : Identifiable
            where P2 : Identifiable
            where P3 : Identifiable
            where P4 : Identifiable
        {
            return item.AddAndGetCache(new CompileTimeCache<T, P1, P2, P3, P4>(i, h, o));
        }
    }
}