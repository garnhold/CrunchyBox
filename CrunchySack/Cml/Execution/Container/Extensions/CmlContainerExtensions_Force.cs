
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class CmlContainerExtensions_Force
    {
        static public object ForceContainedSystemValue(this CmlContainer item)
        {
            return item.GetLastValue().ForceSystemValue();
        }

        static public T ForceContainedSystemValueEX<T>(this CmlContainer item)
        {
            return item.GetLastValue().ForceSystemValueEX<T>();
        }

        static public T ForceContainedSystemValue<T>(this CmlContainer item)
        {
            return item.GetLastValue().ForceSystemValue<T>();
        }
    }
}
