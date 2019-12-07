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
    
    static public class EditPropertyArrayExtensions_GetElement
    {
        static public bool TryGetElementValue(this EditProperty_Array item, int index, out EditProperty_Single_Value value)
        {
            return item.GetElement(index).Convert<EditProperty_Single_Value>(out value);
        }

        static public bool TryGetElementValue(this EditProperty_Array item, int index, out object value)
        {
            EditProperty_Single_Value property;

            if(item.TryGetElementValue(index, out property))
                return property.TryGetContentValues(out value);

            value = null;
            return false;
        }

        static public bool TryGetElementValue<T>(this EditProperty_Array item, int index, out T value)
        {
            object temp;

            if (item.TryGetElementValue(index, out temp))
            {
                if (temp.Convert<T>(out value))
                    return true;
            }

            value = default(T);
            return false;
        }
    }
}