using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IEnumerableExtensions_Cost
    {
        static public double GetCost<T>(this IEnumerable<T> item, Operation<double, T> operation)
        {
            return item.Convert(operation).Sum();
        }

        static public int GetIndexForCost<T>(this IEnumerable<T> item, double cost, BoundType type, Operation<double, T> operation)
        {
            double current_cost = 0.0;
            int index = 0;

            foreach (T sub_item in item)
            {
                if (current_cost > cost)
                    break;

                current_cost += operation(sub_item);
                index++;
            }

            if (current_cost == cost)
                return index;

            return type.ConvertBoundType(index - 1, index);
        }

        static public T GetElementForCost<T>(this IEnumerable<T> item, double cost, BoundType type, Operation<double, T> operation)
        {
            double current_cost = 0.0;
            T previous_item = default(T);

            foreach (T sub_item in item)
            {
                if (current_cost > cost)
                    return type.ConvertBoundType(previous_item, sub_item);

                current_cost += operation(sub_item);
                previous_item = sub_item;
            }

            if (current_cost == cost)
                return previous_item;

            return type.ConvertBoundType(previous_item, default(T));
        }
        
        static public IEnumerable<IEnumerable<T>> GetCostGroups<T>(this IEnumerable<T> item, double cost, BoundType type, Operation<double, T> operation)
        {
            double group_cost = 0.0;
            List<T> group = new List<T>();

            switch (type)
            {
                case BoundType.Below:
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
                    break;

                case BoundType.Above:
                    foreach (T sub_item in item)
                    {
                        group_cost += operation(sub_item);
                        group.Add(sub_item);

                        if (group_cost > cost)
                        {
                            yield return group;

                            group_cost = 0.0;
                            group = new List<T>();
                        }
                    }
                    break;

                default: throw new UnaccountedBranchException("type", type);
            }

            if (group.IsNotEmpty())
                yield return group;
        }
    }
}