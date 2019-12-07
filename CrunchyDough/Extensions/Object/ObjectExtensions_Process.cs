using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_Process
    {
        static public void ProcessAs<T>(this object item, Process<T> process)
        {
            T cast;
            if (item.Convert<T>(out cast))
                process(cast);
        }
    }
}