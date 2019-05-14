using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ProcessCopy
    {
        static public void ProcessCopy<T>(this IEnumerable<T> item, Process<T> process)
        {
            item.ToList().Process(process);
        }
    }
}