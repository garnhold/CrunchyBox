
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
    
    public abstract class CmlContainer
	{
        private CmlValue last_value;

        protected abstract void InsertInternal(CmlExecution execution, CmlValue value);

        public void Insert(CmlExecution execution, CmlValue value)
        {
            InsertInternal(execution, value);

            last_value = value;
        }

        public CmlValue GetLastValue()
        {
            return last_value;
        }
	}
}
