using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_Elements
    {
        static public Type GetVariableElementType(this Variable item)
        {
            return item.GetVariableType().GetIEnumerableType();
        }
    }
}