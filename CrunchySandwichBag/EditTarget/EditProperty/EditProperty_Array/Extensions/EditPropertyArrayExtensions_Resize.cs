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
    
    static public class EditPropertyArrayExtensions_Resize
    {
        static public void Resize(this EditProperty_Array item, int new_size)
        {
            int current_size;

            if (item.TryGetNumberElements(out current_size))
            {
                if (new_size < 0)
                    new_size = 0;

                if (new_size != current_size)
                {
                    if (new_size > current_size)
                    {
                        for (int i = current_size; i < new_size; i++)
                            item.InsertElement(i);
                    }
                    else
                    {
                        for (int i = current_size - 1; i >= new_size; i--)
                            item.RemoveElement(i);
                    }
                }
            }
        }
    }
}