using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Copy
    {
        static public int CopySub(this Array item, Array array, int dst, int src, int length)
        {
            if (item.IsSubValid(dst, length) && array.IsSubValid(src, length))
            {
                Array.Copy(array, src, item, dst, length);

                return dst + length;
            }

            return dst;
        }

        static public int CopySubsection(this Array item, Array array, int dst, int src_start, int src_end)
        {
            return item.CopySub(array, dst, src_start, src_end - src_start);
        }

        static public int CopyFrom(this Array item, Array array, int dst, int src)
        {
            return item.CopySub(array, dst, src, array.GetLength() - src);
        }
        static public int CopyFrom(this Array item, Array array, int dst)
        {
            return item.CopyFrom(array, dst, 0);
        }
        static public int CopyFrom(this Array item, Array array)
        {
            return item.CopyFrom(array, 0);
        }

        static public Array Copy(this Array item)
        {
            Array copy = item.CreateInstance(item.GetLength());

            copy.CopyFrom(item);
            return copy;
        }
    }
}
