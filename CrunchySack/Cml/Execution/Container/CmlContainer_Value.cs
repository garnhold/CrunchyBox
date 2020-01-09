
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
    
    public class CmlContainer_Value : CmlContainer
	{
        private CmlValue value;

        protected override void InsertInternal(CmlExecution execution, CmlValue v)
        {
            value = v;
        }

        public CmlValue GetValue()
        {
            return value;
        }

        public T GetValue<T>() where T : CmlValue
        {
            return GetValue().Convert<T>();
        }
	}
}
