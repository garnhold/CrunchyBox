
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
    
    static public class CmlContainerExtensions_PiggyBack
    {
        static public CmlContainer PiggyBack(this CmlContainer item, Process<CmlExecution, CmlValue> process)
        {
            return new CmlContainer_PiggyBack(item, process);
        }
    }
}
