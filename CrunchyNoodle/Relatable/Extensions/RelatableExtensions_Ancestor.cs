using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class RelatableExtensions_Ancestor
    {
        static public T GetAncestor<T>(this Relatable item, int depth)
        {
            return item.GetSelfAndParents<T>().Get(depth);
        }

        static public IEnumerable<T> GetAncestors<T>(this Relatable item, int depth)
        {
            return item.GetSelfAndParents<T>().Offset(depth);
        }
    }
}