using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_ProcessSandboxed
    {
        static public void ProcessSandboxed<T>(this IEnumerable<T> item, Process<T> process, Process<Exception> exception_process)
        {
            if (item != null)
            {
                foreach (T sub_item in item)
                {
                    try
                    {
                        process(sub_item);
                    }
                    catch (Exception ex)
                    {
                        exception_process(ex);
                    }
                }
            }
        }
    }
}