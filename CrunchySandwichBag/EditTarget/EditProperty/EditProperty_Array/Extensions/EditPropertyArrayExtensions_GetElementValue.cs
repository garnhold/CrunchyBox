using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditPropertyArrayExtensions_GetElement
    {
        static public bool TryGetElementValue(this EditProperty_Array item, int index, out EditProperty_Value value)
        {
            return item.GetElement(index).Convert<EditProperty_Value>(out value);
        }

        static public bool TryGetElementValue(this EditProperty_Array item, int index, out object value)
        {
            EditProperty_Value property;

            if(item.TryGetElementValue(index, out property))
                return property.TryGetContents(out value);

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