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
    
    static public class EditPropertyArrayExtensions_SetElement
    {
        static public void SetElementValue(this EditProperty_Array item, int index, object value)
        {
            EditProperty_Single_Value property;

            if (item.TryGetElementValue(index, out property))
                property.SetContentValues(value);
        }
    }
}