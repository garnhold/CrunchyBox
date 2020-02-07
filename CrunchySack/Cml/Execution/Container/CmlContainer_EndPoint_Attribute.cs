
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
    
    public class CmlContainer_EndPoint_Attribute : CmlContainer_EndPoint
	{
        private object representation;
        private RepresentationInfo_Attribute attribute_info;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            attribute_info.SetRepresentationValue(execution, representation, value.GetSystemValue());
        }

        protected void InsertInternal(CmlValue_ComponentSourceList value, CmlExecution execution)
        {
            CmlContainer container = new CmlContainer_EndPoint_AttributeCollection(representation, attribute_info);

            value.GetComponentSources().Process(c => c.SolidifyInto(execution, container));
        }

        protected void InsertInternal(CmlValue_Link value, CmlExecution execution)
        {
            execution.AddVariableLink(
                value.GetInfoValue("group"),
                attribute_info.CreateVariableLink(execution, representation, value.GetVariableInstance())
            );
        }

        protected void InsertInternal(CmlValue_Function value, CmlExecution execution)
        {
            FunctionSyncro function_syncro = new FunctionSyncro(value.GetFunctionInstance());

            execution.AddFunctionSyncro(function_syncro);
            attribute_info.InjectRepresentationFunction(
                execution,
                representation,
                function_syncro
            );
        }

        public CmlContainer_EndPoint_Attribute(object r, RepresentationInfo_Attribute i)
        {
            representation = r;
            attribute_info = i;
        }
	}
}
