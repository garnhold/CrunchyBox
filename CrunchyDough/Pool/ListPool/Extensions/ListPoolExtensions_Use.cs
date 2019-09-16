using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ListPoolExtensions_Use
    {
        static public void Use<T>(this ListPool<T> item, IEnumerable<T> items, Process<List<T>> process)
        {
            item.Use(delegate(List<T> list) {
                list.Set(items);

                process(list);
            });
        }

        static public J Use<J, T>(this ListPool<T> item, IEnumerable<T> items, Operation<J, List<T>> operation)
        {
            return item.Use(delegate(List<T> list) {
                list.Set(items);

                return operation(list);
            });
        }
    }
}