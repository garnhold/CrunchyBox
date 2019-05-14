using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IEnumerableExtensions_Cost
    {
        static public double GetCost<T>(this IEnumerable<T> item, Operation<double, T> operation)
        {
            return item.Convert(operation).Sum();
        }

        static public double GetCostToIndex<T>(this IEnumerable<T> item, int end_index, Operation<double, T> operation)
        {
            return item.Truncate(end_index).GetCost(operation);
        }

        static public int GetIndexForCost<T>(this IEnumerable<T> item, double cost, Operation<double, T> operation)
        {
            return item.Convert(operation).RunningSum().FindIndexOf(s => s >= cost);
        }
    }
}