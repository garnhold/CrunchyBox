using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_GetContents
    {
        static public T GetContents<T>(this Variable item, object target)
        {
            return item.GetContents(target).Convert<T>();
        }
    }
}