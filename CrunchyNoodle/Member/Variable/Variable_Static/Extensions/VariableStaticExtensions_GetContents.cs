using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableStaticExtensions_GetContents
    {
        static public T GetContents<T>(this Variable_Static item)
        {
            return item.GetContents().Convert<T>();
        }
    }
}