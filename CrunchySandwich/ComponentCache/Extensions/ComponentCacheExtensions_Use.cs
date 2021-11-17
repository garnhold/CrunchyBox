using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class ComponentCacheExtensions_Use
    {
        static public void Use<T>(this ComponentCache<T> item, Process<T> process)
        {
            item.IfNotNull(i => i.GetComponent().IfNotNull(process));
        }
        static public void Use<T>(this ComponentCache<T> item, Process<T> process, Process if_null)
        {
            item.IfNotNull(i => i.GetComponent().IfNotNull(process, if_null), if_null);
        }

        static public J Use<J, T>(this ComponentCache<T> item, Operation<J, T> operation)
        {
            return item.IfNotNull(i => i.GetComponent().IfNotNull(operation));
        }
        static public J Use<J, T>(this ComponentCache<T> item, Operation<J, T> operation, Operation<J> if_null)
        {
            return item.IfNotNull(i => i.GetComponent().IfNotNull(operation, if_null), if_null);
        }
        static public J Use<J, T>(this ComponentCache<T> item, Operation<J, T> operation, J if_null)
        {
            return item.IfNotNull(i => i.GetComponent().IfNotNull(operation, if_null), if_null);
        }
    }
}