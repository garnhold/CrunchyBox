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
            if(item != null)
                item.GetComponent().IfNotNull(process);
        }
        static public void IfNotNull<T>(this ComponentCache<T> item, Process<T> process, Process if_false)
        {
            if (item != null)
                item.GetComponent().IfNotNull(process, if_false);
            else if (if_false != null)
                if_false();

        }

        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation)
        {
            if(item != null)
                return item.GetComponent().IfNotNull(operation);

            return default(J);
        }
        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation, Operation<J> if_false)
        {
            if(item != null)
                return item.GetComponent().IfNotNull(operation, if_false);

            if (if_false != null)
                return if_false();

            return default(J);
        }
        static public J IfNotNull<J, T>(this ComponentCache<T> item, Operation<J, T> operation, J if_false)
        {
            if(item != null)
                return item.GetComponent().IfNotNull(operation, if_false);

            return if_false;
        }
    }
}