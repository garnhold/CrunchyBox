using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class VariableInstanceExtensions_Elements
    {
        static public Type GetVariableInstanceElementType(this VariableInstance item)
        {
            return item.GetVariableType().GetIEnumerableType();
        }
    }

}