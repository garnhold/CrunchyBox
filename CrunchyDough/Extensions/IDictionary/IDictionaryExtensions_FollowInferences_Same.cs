using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IDictionaryExtensions_FollowInferences_Same
    {
        static public IEnumerable<T> FollowInferences<T>(this IDictionary<T, T> item, T value)
        {
            return item.FollowInferences(value, z => z);
        }
        static public IEnumerable<T> FollowInferences<T>(this IDictionary<T, T> item)
        {
            return item.FollowInferences(z => z);
        }
    }
}