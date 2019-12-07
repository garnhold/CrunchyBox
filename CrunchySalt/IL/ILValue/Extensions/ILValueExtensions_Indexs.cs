using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Indexs
    {
        static public ILValue GetILIndexed(this ILValue item, ILValue index)
        {
            return new ILIndexed(item, index);
        }

        static public IEnumerable<ILValue> GetILIndexedRange(this ILValue item, int start, int end)
        {
            for (int i = start; i < end; i++)
                yield return item.GetILIndexed(i);
        }
    }
}