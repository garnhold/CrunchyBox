
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlReturnSpace
	{
        private Dictionary<string, CmlContainer> returns;

        public CmlReturnSpace()
        {
            returns = new Dictionary<string, CmlContainer>();
        }

        public void RequestReturn(string id, CmlContainer container)
        {
            returns.Add(id, container);
        }
        public void RequestSystemValueReturn(string id, Process<object> process)
        {
            RequestReturn(id, new CmlContainer_Process((e, v) => process(v.ForceSystemValue())));
        }

        public void LogReturn(CmlExecution execution, string id, CmlValue value)
        {
            returns.GetValue(id).IfNotNull(c => c.Insert(execution, value));
        }
        public void LogSystemValueReturn(CmlExecution execution, string id, object value)
        {
            LogReturn(execution, id, new CmlValue_SystemValue(value));
        }
	}
	
}
