using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ListExtensions_Add
    {
        static public void AddRepeated<T>(this List<T> item, Operation<T> operation, int times)
        {
            item.ReserveAdditional(times);
            item.AddRange(operation.ExecuteRepeated(times));
        }

        static public void AddRepeated<T>(this List<T> item, T to_add, int times)
        {
            item.ReserveAdditional(times);
            item.AddRange(to_add.Repeat(times));
        }

        static public void AddEmptys<T>(this List<T> item, int times)
        {
            item.AddRepeated(default(T), times);
        }
    }
}