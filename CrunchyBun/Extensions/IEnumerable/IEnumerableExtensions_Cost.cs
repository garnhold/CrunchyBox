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
            return item.Convert(operation).RunningSum().FindIndexOf(s => s > cost);
        }

        static public T GetElementForCost<T>(this IEnumerable<T> item, double cost, Operation<double, T> operation)
        {
            double current_cost = 0.0;

            foreach (T sub_item in item)
            {
                if (current_cost > cost)
                    return sub_item;

                current_cost += operation(sub_item);
            }

            return default(T);
        }

        static public IEnumerable<IEnumerable<T>> GetCostGroups<T>(this IEnumerable<T> item, double cost, Operation<double, T> operation)
        {
            double group_cost = 0.0;
            List<T> group = new List<T>();

            foreach (T sub_item in item)
            {
                double sub_item_cost = operation(sub_item);

                if (group_cost + sub_item_cost > cost)
                {
                    yield return group;

                    group_cost = 0.0;
                    group = new List<T>();
                }

                group_cost += sub_item_cost;
                group.Add(sub_item);
            }

            if (group.IsNotEmpty())
                yield return group;
        }
    }
}