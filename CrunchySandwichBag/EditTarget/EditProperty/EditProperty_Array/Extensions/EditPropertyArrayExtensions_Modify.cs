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
    
    static public class EditPropertyArrayExtensions_Modify
    {
        static public void InsertElementBefore(this EditProperty_Array item, EditProperty element)
        {
            item.InsertElement(item.GetIndexOfElement(element));
        }

        static public void InsertElementAfter(this EditProperty_Array item, EditProperty element)
        {
            item.InsertElement(item.GetIndexOfElement(element) + 1);
        }

        static public void RemoveElement(this EditProperty_Array item, EditProperty element)
        {
            item.RemoveElement(item.GetIndexOfElement(element));
        }

        static public void MoveElement(this EditProperty_Array item, EditProperty element, int dst)
        {
            item.MoveElement(item.GetIndexOfElement(element), dst);
        }
    }
}