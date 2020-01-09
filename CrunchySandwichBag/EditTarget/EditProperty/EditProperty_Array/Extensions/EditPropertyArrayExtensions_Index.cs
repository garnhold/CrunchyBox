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
    
    static public class EditPropertyArrayExtensions_Index
    {
        static public bool IsIndexValid(this EditProperty_Array item, int index)
        {
            int number_elements;

            if (item.TryGetNumberElements(out number_elements))
            {
                if (index >= 0 && index < number_elements)
                    return true;
            }

            return false;
        }
    }
}