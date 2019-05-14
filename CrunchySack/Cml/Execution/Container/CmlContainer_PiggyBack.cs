
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
	public class CmlContainer_PiggyBack : CmlContainer
	{
        private CmlContainer container;
        private Process<CmlExecution, CmlValue> process;

        protected override void InsertInternal(CmlExecution execution, CmlValue value)
        {
            process(execution, value);

            container.Insert(execution, value);
        }

        public CmlContainer_PiggyBack(CmlContainer c, Process<CmlExecution, CmlValue> p)
        {
            container = c;
            process = p;
        }
	}
}
