
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
    public class CmlContainer_EndPoint_Children : CmlContainer_EndPoint
	{
        private object representation;
        private RepresentationInfo_Children children_info;

        protected void InsertInternal(CmlValue_SystemValue value, CmlExecution execution)
        {
            children_info.GetEffigyInfo().AddChild(
                representation,
                value.GetSystemValue()
            );
        }

        protected void InsertInternal(CmlValue_ComponentSourceList value, CmlExecution execution)
        {
            CmlContainer container = new CmlContainer_EndPoint_ChildrenCollection(representation, children_info);

            value.GetComponentSources().Process(c => c.SolidifyInto(execution, container));
        }

        protected void InsertInternal(CmlValue_Link value, CmlExecution execution)
        {
            execution.AddEffigyLink(
                value.GetInfoValue("group"),

                new EffigyLink_Collection(
                    execution,
                    new EffigySource_Collection(value.GetVariableInstance()),
                    new EffigyDestination_Collection(representation, children_info.GetEffigyInfo()),
                    new EffigyClassInfo_Dynamic(value.GetInfoValue("layout"))
                )
            );
        }

        protected void InsertInternal(CmlValue_LinkWithEntity value, CmlExecution execution)
        {
            execution.AddEffigyLink(
                value.GetLink().GetInfoValue("group"),

                new EffigyLink_Collection(
                    execution,
                    new EffigySource_Collection(value.GetLink().GetVariableInstance()),
                    new EffigyDestination_Collection(representation, children_info.GetEffigyInfo()),
                    new EffigyClassInfo_Static(value.GetEntity())
                )
            );
        }

        public CmlContainer_EndPoint_Children(object r, RepresentationInfo_Children i)
        {
            representation = r;
            children_info = i;
        }
	}
}
