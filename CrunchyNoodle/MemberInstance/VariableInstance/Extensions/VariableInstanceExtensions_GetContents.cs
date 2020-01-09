using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class VariableInstanceExtensions_GetContents
    {
        static public T GetContents<T>(this VariableInstance item)
        {
            return item.GetContents().Convert<T>();
        }
    }

}