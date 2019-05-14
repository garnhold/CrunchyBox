
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
	public class CmlContainer_Values : CmlContainer
	{
        private List<CmlValue> values;

        protected override void InsertInternal(CmlExecution execution, CmlValue value)
        {
            values.Add(value);
        }

        public CmlContainer_Values()
        {
            values = new List<CmlValue>();
        }

        public IEnumerable<CmlValue> GetValues()
        {
            return values;
        }

        public IEnumerable<object> ForceSystemValues()
        {
            return GetValues().Convert(v => v.ForceSystemValue());
        }
	}
}
