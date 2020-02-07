
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
    
    public class CmlContainer_EndPoint_AttributeCollection : CmlContainer_EndPoint
	{
        private object representation;
        private RepresentationInfo_Attribute attribute_info;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            attribute_info.AddRepresentationValue(execution, representation, value.GetSystemValue());
        }

        protected void InsertInternal(CmlValue_ComponentSourceList value, CmlExecution execution)
        {
            value.GetComponentSources().Process(c => c.SolidifyInto(execution, this));
        }

        public CmlContainer_EndPoint_AttributeCollection(object r, RepresentationInfo_Attribute i)
        {
            representation = r;
            attribute_info = i;
        }
	}
}
