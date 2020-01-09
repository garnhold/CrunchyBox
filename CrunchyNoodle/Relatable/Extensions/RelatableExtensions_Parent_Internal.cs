using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class RelatableExtensions_Parent_Internal
    {
        static public object GetImmediateParent(object item)
        {
            return item.RetrieveMarkedInstanceValue<Object, RelatableParentAttribute>();
        }

        static public IEnumerable<object> GetParents(object item)
        {
            return item.Traverse(i => GetImmediateParent(i));
        }
    }
}