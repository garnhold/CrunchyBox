using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class DelegateExtensions_Combine
    {
        static public Delegate CombineDelegates(this IEnumerable<Delegate> item)
        {
            return item.PerformIteratedBinaryOperation((d1, d2) => Delegate.Combine(d1, d2));
        }
    }
}