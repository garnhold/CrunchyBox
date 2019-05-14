using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ListPoolExtensions_UseEnumerate
    {
        static public IEnumerable<T> UseEnumerate<T>(this ListPool<T> item, Process<List<T>> process)
        {
            using (Pooled<List<T>> pooled = item.Withdraw())
            {
                List<T> list = pooled.Get();

                process(list);

                foreach (T sub_item in list)
                    yield return sub_item;
            }
        }
        static public IEnumerable<T> UseEnumerate<T>(this ListPool<T> item, IEnumerable<T> items, Process<List<T>> process)
        {
            return item.UseEnumerate(delegate(List<T> list) {
                list.Set(items);

                process(list);
            });
        }
    }
}