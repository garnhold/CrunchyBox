
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	static public class CmlContainerExtensions_PiggyBack
    {
        static public CmlContainer PiggyBack(this CmlContainer item, Process<CmlExecution, CmlValue> process)
        {
            return new CmlContainer_PiggyBack(item, process);
        }
    }
}
