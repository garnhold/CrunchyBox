
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
    
    public class CmlContainer_EndPoint_Info : CmlContainer_EndPoint
	{
        private object representation;
        private RepresentationInfo info;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            info.SetValue(execution, representation, value.GetSystemValue());
        }

        protected void InsertInternal(CmlValue_ComponentSourceList value, CmlExecution execution)
        {
            value.GetComponentSources().Process(c => c.SolidifyInto(execution, this));
        }

        protected void InsertInternal(CmlValue_Link value, CmlExecution execution)
        {
            info.LinkValue(execution, representation, value.GetVariableInstance(), value);
        }

        protected void InsertInternal(CmlValue_LinkWithEntity value, CmlExecution execution)
        {
            info.LinkValueWithEntity(execution, representation, value.GetLink().GetVariableInstance(), value.GetEntity(), value.GetLink());
        }

        protected void InsertInternal(CmlValue_Function value, CmlExecution execution)
        {
            info.InjectFunction(execution, representation, value.GetFunctionInstance());
        }

        public CmlContainer_EndPoint_Info(object r, RepresentationInfo i)
        {
            representation = r;
            info = i;
        }
	}
}
