using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    static public class RandBoxExtensions_Sequence
    {
        static public IEnumerable<T> GetSequence<T>(this RandBox<T> item, int length)
        {
            for (int i = 0; i < length; i++)
                yield return item.Get();
        }
    }
}