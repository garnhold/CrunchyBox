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
    static public class EditPropertyArrayExtensions_SetElement
    {
        static public void SetElementValue(this EditProperty_Array item, int index, object value)
        {
            EditProperty_Value property;

            if (item.TryGetElementValue(index, out property))
                property.SetContents(value);
        }
    }
}