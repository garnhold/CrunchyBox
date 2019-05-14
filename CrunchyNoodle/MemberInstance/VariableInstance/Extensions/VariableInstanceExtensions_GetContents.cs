using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class VariableInstanceExtensions_GetContents
    {
        static public T GetContents<T>(this VariableInstance item)
        {
            return item.GetContents().Convert<T>();
        }
    }

}