using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Copy_Resize
    {
        static public Array CopyResize(this Array item, int size)
        {
            Array resized = item.CreateInstance(size);

            Array.Copy(item, 0, resized, 0, size.Min(item.GetLength()));
            return resized;
        }

        static public Array CopyGrow(this Array item)
        {
            return item.CopyResize(item.Length * 2);
        }
    }
}
