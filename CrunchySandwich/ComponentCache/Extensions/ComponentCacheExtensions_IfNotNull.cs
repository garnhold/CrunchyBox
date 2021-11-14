using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class ComponentCacheExtensions_IfNotNull
    {
        static public void IfNotNull<T>(this ComponentCache<T> item, Process<T> process)
        {
            item.GetComponent().IfNotNull(process);
        }
        static public void IfNotNull<T>(this ComponentCache<T> item, Process<T> process, Process if_false)
        {
            item.GetComponent().IfNotNull(process, if_false);
        }

        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation)
        {
            return item.GetComponent().IfNotNull(operation);
        }
        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation, Operation<J> if_false)
        {
            return item.GetComponent().IfNotNull(operation, if_false);
        }
        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation, J if_false)
        {
            return item.GetComponent().IfNotNull(operation, if_false);
        }
    }
}