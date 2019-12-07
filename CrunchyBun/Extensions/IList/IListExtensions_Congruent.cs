using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IListExtensions_Congruent
    {
        static public T PickACongruent<T>(this IList<T> item, int value, Operation<double, T> operation)
        {
            double total_cost = item.GetCost(operation);

            return item.GetElementForCost(
                value.GetACongruent().GetDoublePercent() * total_cost,
                BoundType.Below,
                operation
            );
        }
    }
}