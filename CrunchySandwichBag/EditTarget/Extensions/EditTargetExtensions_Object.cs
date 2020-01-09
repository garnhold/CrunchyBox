using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public class EditTargetExtensions_Object
    {
        static public bool TryGetObject(this EditTarget item, out object obj)
        {
            return item.GetObjects().TryGetOnly(out obj);
        }
        static public bool TryGetObject<T>(this EditTarget item, out T obj, bool allow_null_object = false)
        {
            object temp;

            if (item.TryGetObject(out temp))
            {
                if (temp.Convert<T>(out obj, allow_null_object))
                    return true;
            }

            obj = default(T);
            return false;
        }
    }
}