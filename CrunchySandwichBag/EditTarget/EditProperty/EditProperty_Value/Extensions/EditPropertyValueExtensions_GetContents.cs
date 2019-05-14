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
    static public class EditPropertyValueExtensions_GetContents
    {
        static public object GetContents(this EditProperty_Value item)
        {
            object value;

            item.TryGetContents(out value);
            return value;
        }
        static public T GetContents<T>(this EditProperty_Value item)
        {
            return item.GetContents().Convert<T>();
        }
    }
}