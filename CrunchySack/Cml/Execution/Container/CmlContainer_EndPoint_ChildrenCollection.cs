
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
    
    public class CmlContainer_EndPoint_ChildrenCollection : CmlContainer_EndPoint
	{
        private object representation;
        private RepresentationInfo_Children children_info;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            children_info.AddRepresentationValue(
                execution,
                representation,
                value.GetSystemValue()
            );
        }

        protected void InsertInternal(CmlValue_ComponentSourceList value, CmlExecution execution)
        {
            value.GetComponentSources().Process(c => c.SolidifyInto(execution, this));
        }

        public CmlContainer_EndPoint_ChildrenCollection(object r, RepresentationInfo_Children i)
        {
            representation = r;
            children_info = i;
        }
	}
}
